
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create an in-memory object for AzurePostgreSqlDataSource.
.Description
Create an in-memory object for AzurePostgreSqlDataSource.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.AzurePostgreSqlDataSource
.Link
https://learn.microsoft.com/powershell/module/Az.Purview/new-azpurviewazurepostgresqldatasourceobject
#>
function New-AzPurviewAzurePostgreSqlDataSourceObject {
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.ModelCmdletAttribute()]
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.AzurePostgreSqlDataSource')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter()]
        [string]
        $CollectionReferenceName,
        [Parameter()]
        [string]
        $CollectionType,
        [Parameter()]
        [string]
        $Location,
        [Parameter()]
        [int]
        $Port,
        [Parameter()]
        [string]
        $ResourceGroup,
        [Parameter()]
        [string]
        $ResourceName,
        [Parameter()]
        [string]
        $ServerEndpoint,
        [Parameter()]
        [string]
        $SubscriptionId
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.AzurePostgreSqlDataSource]::New()

        if ($PSBoundParameters.ContainsKey('CollectionReferenceName')) {
            $Object.CollectionReferenceName = $CollectionReferenceName
        }
        if ($PSBoundParameters.ContainsKey('CollectionType')) {
            $Object.CollectionType = $CollectionType
        }
        if ($PSBoundParameters.ContainsKey('Location')) {
            $Object.Location = $Location
        }
        if ($PSBoundParameters.ContainsKey('Port')) {
            $Object.Port = $Port
        }
        if ($PSBoundParameters.ContainsKey('ResourceGroup')) {
            $Object.ResourceGroup = $ResourceGroup
        }
        if ($PSBoundParameters.ContainsKey('ResourceName')) {
            $Object.ResourceName = $ResourceName
        }
        if ($PSBoundParameters.ContainsKey('ServerEndpoint')) {
            $Object.ServerEndpoint = $ServerEndpoint
        }
        if ($PSBoundParameters.ContainsKey('SubscriptionId')) {
            $Object.SubscriptionId = $SubscriptionId
        }
        return $Object
    }
}

