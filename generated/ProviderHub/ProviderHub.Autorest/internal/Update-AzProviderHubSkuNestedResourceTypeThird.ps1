
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
Update the resource type skus in the given resource type.
.Description
Update the resource type skus in the given resource type.
.Example
{{ Add code here }}
.Example
{{ Add code here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IProviderHubIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuResource
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IProviderHubIdentity>: Identity Parameter
  [Id <String>]: Resource identity path
  [NestedResourceTypeFirst <String>]: The first child resource type.
  [NestedResourceTypeSecond <String>]: The second child resource type.
  [NestedResourceTypeThird <String>]: The third child resource type.
  [NotificationRegistrationName <String>]: The notification registration.
  [ProviderNamespace <String>]: The name of the resource provider hosted within ProviderHub.
  [ResourceType <String>]: The resource type.
  [RolloutName <String>]: The rollout name.
  [Sku <String>]: The SKU.
  [SubscriptionId <String>]: The ID of the target subscription.

PROVIDERREGISTRATIONINPUTOBJECT <IProviderHubIdentity>: Identity Parameter
  [Id <String>]: Resource identity path
  [NestedResourceTypeFirst <String>]: The first child resource type.
  [NestedResourceTypeSecond <String>]: The second child resource type.
  [NestedResourceTypeThird <String>]: The third child resource type.
  [NotificationRegistrationName <String>]: The notification registration.
  [ProviderNamespace <String>]: The name of the resource provider hosted within ProviderHub.
  [ResourceType <String>]: The resource type.
  [RolloutName <String>]: The rollout name.
  [Sku <String>]: The SKU.
  [SubscriptionId <String>]: The ID of the target subscription.

RESOURCETYPEREGISTRATIONINPUTOBJECT <IProviderHubIdentity>: Identity Parameter
  [Id <String>]: Resource identity path
  [NestedResourceTypeFirst <String>]: The first child resource type.
  [NestedResourceTypeSecond <String>]: The second child resource type.
  [NestedResourceTypeThird <String>]: The third child resource type.
  [NotificationRegistrationName <String>]: The notification registration.
  [ProviderNamespace <String>]: The name of the resource provider hosted within ProviderHub.
  [ResourceType <String>]: The resource type.
  [RolloutName <String>]: The rollout name.
  [Sku <String>]: The SKU.
  [SubscriptionId <String>]: The ID of the target subscription.

SKUSETTING <ISkuSetting[]>: .
  Name <String>: 
  [Capability <List<ISkuCapability>>]: 
    Name <String>: 
    Value <String>: 
  [CapacityDefault <Int32?>]: 
  [CapacityMaximum <Int32?>]: 
  [CapacityMinimum <Int32?>]: 
  [CapacityScaleType <String>]: 
  [Cost <List<ISkuCost>>]: 
    MeterId <String>: 
    [ExtendedUnit <String>]: 
    [Quantity <Int32?>]: 
  [Family <String>]: 
  [Kind <String>]: 
  [Location <List<String>>]: 
  [LocationInfo <List<ISkuLocationInfo>>]: 
    Location <String>: 
    [ExtendedLocation <List<String>>]: 
    [Type <String>]: 
    [Zone <List<String>>]: 
    [ZoneDetail <List<ISkuZoneDetail>>]: 
      [Capability <List<ISkuCapability>>]: 
      [Name <List<String>>]: 
  [RequiredFeature <List<String>>]: 
  [RequiredQuotaId <List<String>>]: 
  [Size <String>]: 
  [Tier <String>]: 
.Link
https://learn.microsoft.com/powershell/module/az.providerhub/update-azproviderhubskunestedresourcetypethird
#>
function Update-AzProviderHubSkuNestedResourceTypeThird {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuResource])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaIdentityProviderRegistrationExpanded', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaIdentityResourcetypeRegistrationExpanded3', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Category('Path')]
    [System.String]
    # The first child resource type.
    ${NestedResourceTypeFirst},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaIdentityProviderRegistrationExpanded', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaIdentityResourcetypeRegistrationExpanded2', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaIdentityResourcetypeRegistrationExpanded3', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Category('Path')]
    [System.String]
    # The second child resource type.
    ${NestedResourceTypeSecond},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaIdentityProviderRegistrationExpanded', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaIdentityResourcetypeRegistrationExpanded1', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaIdentityResourcetypeRegistrationExpanded2', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaIdentityResourcetypeRegistrationExpanded3', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Category('Path')]
    [System.String]
    # The third child resource type.
    ${NestedResourceTypeThird},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Category('Path')]
    [System.String]
    # The name of the resource provider hosted within ProviderHub.
    ${ProviderNamespace},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaIdentityProviderRegistrationExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Category('Path')]
    [System.String]
    # The resource type.
    ${ResourceType},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaIdentityProviderRegistrationExpanded', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaIdentityResourcetypeRegistrationExpanded', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaIdentityResourcetypeRegistrationExpanded1', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaIdentityResourcetypeRegistrationExpanded2', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaIdentityResourcetypeRegistrationExpanded3', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Category('Path')]
    [System.String]
    # The SKU.
    ${Sku},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IProviderHubIdentity]
    # Identity Parameter
    ${InputObject},

    [Parameter(ParameterSetName='UpdateViaIdentityProviderRegistrationExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IProviderHubIdentity]
    # Identity Parameter
    ${ProviderRegistrationInputObject},

    [Parameter(ParameterSetName='UpdateViaIdentityResourcetypeRegistrationExpanded', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='UpdateViaIdentityResourcetypeRegistrationExpanded1', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='UpdateViaIdentityResourcetypeRegistrationExpanded2', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='UpdateViaIdentityResourcetypeRegistrationExpanded3', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IProviderHubIdentity]
    # Identity Parameter
    ${ResourcetypeRegistrationInputObject},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.PSArgumentCompleterAttribute("NotSpecified", "Accepted", "Running", "Creating", "Created", "Deleting", "Deleted", "Canceled", "Failed", "Succeeded", "MovingResources", "TransientFailure", "RolloutInProgress")]
    [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Category('Body')]
    [System.String]
    # .
    ${ProvisioningState},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSetting[]]
    # .
    ${SkuSetting},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        
        $testPlayback = $false
        $PSBoundParameters['HttpPipelinePrepend'] | Foreach-Object { if ($_) { $testPlayback = $testPlayback -or ('Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.PipelineMock' -eq $_.Target.GetType().FullName -and 'Playback' -eq $_.Target.Mode) } }

        $mapping = @{
            UpdateExpanded = 'Az.ProviderHub.private\Update-AzProviderHubSkuNestedResourceTypeThird_UpdateExpanded';
            UpdateViaIdentityExpanded = 'Az.ProviderHub.private\Update-AzProviderHubSkuNestedResourceTypeThird_UpdateViaIdentityExpanded';
            UpdateViaIdentityProviderRegistrationExpanded = 'Az.ProviderHub.private\Update-AzProviderHubSkuNestedResourceTypeThird_UpdateViaIdentityProviderRegistrationExpanded';
            UpdateViaIdentityResourcetypeRegistrationExpanded = 'Az.ProviderHub.private\Update-AzProviderHubSkuNestedResourceTypeThird_UpdateViaIdentityResourcetypeRegistrationExpanded';
            UpdateViaIdentityResourcetypeRegistrationExpanded1 = 'Az.ProviderHub.private\Update-AzProviderHubSkuNestedResourceTypeThird_UpdateViaIdentityResourcetypeRegistrationExpanded1';
            UpdateViaIdentityResourcetypeRegistrationExpanded2 = 'Az.ProviderHub.private\Update-AzProviderHubSkuNestedResourceTypeThird_UpdateViaIdentityResourcetypeRegistrationExpanded2';
            UpdateViaIdentityResourcetypeRegistrationExpanded3 = 'Az.ProviderHub.private\Update-AzProviderHubSkuNestedResourceTypeThird_UpdateViaIdentityResourcetypeRegistrationExpanded3';
        }
        if (('UpdateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId') ) {
            if ($testPlayback) {
                $PSBoundParameters['SubscriptionId'] = . (Join-Path $PSScriptRoot '..' 'utils' 'Get-SubscriptionIdTestSafe.ps1')
            } else {
                $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
            }
        }

        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        if ($wrappedCmd -eq $null) {
            $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Function)
        }
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {

        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {

        throw
    }

}
end {
    try {
        $steppablePipeline.End()

    } catch {

        throw
    }
} 
}
