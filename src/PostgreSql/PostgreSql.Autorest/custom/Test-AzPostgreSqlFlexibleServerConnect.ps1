  
# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

function Test-AzPostgreSqlFlexibleServerConnect {
    [OutputType([System.String])]
    [CmdletBinding(DefaultParameterSetName='Test', PositionalBinding=$false)]
    [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Description('Test out the connection to the database server')]
    param(
        [Parameter(ParameterSetName='Test', Mandatory, HelpMessage = 'The name of the server to connect.')]
        [Parameter(ParameterSetName='TestAndQuery', Mandatory, HelpMessage = 'The name of the server to connect.')]
        [Alias('ServerName')]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Path')]
        [System.String]
        ${Name},

        [Parameter(ParameterSetName='Test', Mandatory, HelpMessage = 'The name of the resource group that contains the resource, You can obtain this value from the Azure Resource Manager API or the portal.')]
        [Parameter(ParameterSetName='TestAndQuery', Mandatory, HelpMessage = 'The name of the resource group that contains the resource, You can obtain this value from the Azure Resource Manager API or the portal.')]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Path')]
        [System.String]
        ${ResourceGroupName},

        [Parameter(HelpMessage = 'The database name to connect.')]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Path')]
        [System.String]
        ${DatabaseName},

        [Parameter(ParameterSetName='TestViaIdentityAndQuery', Mandatory, HelpMessage = 'The query for the database to test')]
        [Parameter(ParameterSetName='TestAndQuery', Mandatory, HelpMessage = 'The query for the database to test')]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Path')]
        [System.String]
        ${QueryText},

        [Parameter(HelpMessage = 'The timeout in seconds for query execution. Valid range is 1-31536000 seconds.')]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Body')]
        [ValidateRange(1, 31536000)]
        [System.Int32]
        ${Timeout},

        [Parameter(ParameterSetName='TestViaIdentity', Mandatory, ValueFromPipeline, HelpMessage = 'The server to connect.')]
        [Parameter(ParameterSetName='TestViaIdentityAndQuery', Mandatory, ValueFromPipeline, HelpMessage = 'The server to connect.')]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.IPostgreSqlIdentity]
        ${InputObject},

        [Parameter(HelpMessage = 'Administrator username for the server. Once set, it cannot be changed.')]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Body')]
        [System.String]
        ${AdministratorUserName},

        [Parameter(Mandatory, HelpMessage = 'The password of the administrator. Minimum 8 characters and maximum 128 characters. Password must contain characters from three of the following categories: English uppercase letters, English lowercase letters, numbers, and non-alphanumeric characters.')]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Body')]
        [System.Security.SecureString]
        [ValidateNotNullOrEmpty()]
        ${AdministratorLoginPassword},

        [Parameter(HelpMessage = 'The credentials, account, tenant, and subscription used for communication with Azure.')]
        [Alias('AzureRMContext', 'AzureCredential')]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Azure')]
        [System.Management.Automation.PSObject]
        ${DefaultProfile},

        [Parameter(DontShow, HelpMessage = 'Wait for .NET debugger to attach.')]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        ${Break},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be appended to the front of the pipeline.
        ${HttpPipelineAppend},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be prepended to the front of the pipeline.
        ${HttpPipelinePrepend},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Runtime')]
        [System.Uri]
        # The URI for the proxy server to use.
        ${Proxy},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Runtime')]
        [System.Management.Automation.PSCredential]
        # Credentials for a proxy server to use for the remote call.
        ${ProxyCredential},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Use the default credentials for the proxy.
        ${ProxyUseDefaultCredentials}
    )

    process {
        if (!(Get-Module -ListAvailable -Name SimplySQL)){
            Write-Error "This cmdlet requires SimplySQL module. Please install the module first by running Install-Module -Name SimplySQL."
            exit
        }
        Import-Module SimplySQL
        
        $Query = [string]::Empty
        if ($PSBoundParameters.ContainsKey('QueryText')) {
            $Query = $PSBoundParameters.QueryText
            $null = $PSBoundParameters.Remove('QueryText')
        }

        $TimeoutValue = 0
        if ($PSBoundParameters.ContainsKey('Timeout')) {
            $TimeoutValue = $PSBoundParameters.Timeout
            $null = $PSBoundParameters.Remove('Timeout')
        }

        $DatabaseName = [string]::Empty
        if ($PSBoundParameters.ContainsKey('DatabaseName')) {
            $DatabaseName = $PSBoundParameters.DatabaseName
            $null = $PSBoundParameters.Remove('DatabaseName')
        }

        $AdministratorUserName = [string]::Empty
        if ($PSBoundParameters.ContainsKey('AdministratorUserName')) {
            $AdministratorUserName = $PSBoundParameters.AdministratorUserName
            $null = $PSBoundParameters.Remove('AdministratorUserName')
        }

        $Password = . "$PSScriptRoot/../utils/Unprotect-SecureString.ps1" $PSBoundParameters['AdministratorLoginPassword']
        $null = $PSBoundParameters.Remove('AdministratorLoginPassword')
        

        $Server = Az.PostgreSql\Get-AzPostgreSqlFlexibleServer @PSBoundParameters
        $HostAddr = $Server.FullyQualifiedDomainName
        if ([string]::IsNullOrEmpty($AdministratorUserName)) {
            $AdministratorUserName = $Server.AdministratorLogin
        }

        if ($Server.NetworkPublicNetworkAccess -eq 'Disabled'){
            Write-Host "You have to run the test cmdlet in the subnet your server is linked."
        }

        # Create PSCredential object for database connection
        $SecurePassword = ConvertTo-SecureString -String $Password -AsPlainText -Force
        $Credential = New-Object System.Management.Automation.PSCredential($AdministratorUserName, $SecurePassword)
        
        try {
            $DbToUse = if ([string]::IsNullOrEmpty($DatabaseName)) { "postgres" } else { $DatabaseName }
            $OpenConnParams = @{
                Database    = $DbToUse
                Server      = $HostAddr
                Credential  = $Credential
                SSLMode     = 'Require'
                WarningAction = 'SilentlyContinue'
            }
            if ($TimeoutValue -gt 0) {
                $OpenConnParams['CommandTimeout'] = $TimeoutValue
            }
            Open-PostGreConnection @OpenConnParams
            
        } catch {
            Write-Host $_.Exception.GetType().FullName
            Write-Host $_.Exception.Message
            exit
        }

        if (![string]::IsNullOrEmpty($Query)) {
            Invoke-SqlQuery -Query $Query -WarningAction 'silentlycontinue'           
        }
        else {
            $Msg = "The connection testing to {0} was successful!" -f $HostAddr
            Write-Host $Msg
        }
    }
}