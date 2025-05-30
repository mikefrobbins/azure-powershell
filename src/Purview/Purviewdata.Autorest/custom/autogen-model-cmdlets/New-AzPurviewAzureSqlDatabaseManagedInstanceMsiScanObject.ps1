
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
Create an in-memory object for AzureSqlDatabaseManagedInstanceMsiScan.
.Description
Create an in-memory object for AzureSqlDatabaseManagedInstanceMsiScan.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.AzureSqlDatabaseManagedInstanceMsiScan
.Link
https://learn.microsoft.com/powershell/module/Az.Purview/new-AzPurviewAzureSqlDatabaseManagedInstanceMsiScanObject
#>
function New-AzPurviewAzureSqlDatabaseManagedInstanceMsiScanObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.AzureSqlDatabaseManagedInstanceMsiScan')]
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
        $ConnectedViaReferenceName,
        [Parameter()]
        [string]
        $DatabaseName,
        [Parameter()]
        [string]
        $ScanRulesetName,
        [Parameter()]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanRulesetType])]
        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanRulesetType]
        $ScanRulesetType,
        [Parameter()]
        [string]
        $ServerEndpoint,
        [Parameter()]
        [int]
        $Worker,
        [Parameter(Mandatory)]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanAuthorizationType])]
        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanAuthorizationType]
        $Kind
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.AzureSqlDatabaseManagedInstanceMsiScan]::New()

        if ($PSBoundParameters.ContainsKey('CollectionReferenceName')) {
            $Object.CollectionReferenceName = $CollectionReferenceName
        }
        if ($PSBoundParameters.ContainsKey('CollectionType')) {
            $Object.CollectionType = $CollectionType
        }
        if ($PSBoundParameters.ContainsKey('ConnectedViaReferenceName')) {
            $Object.ConnectedViaReferenceName = $ConnectedViaReferenceName
        }
        if ($PSBoundParameters.ContainsKey('DatabaseName')) {
            $Object.DatabaseName = $DatabaseName
        }
        if ($PSBoundParameters.ContainsKey('ScanRulesetName')) {
            $Object.ScanRulesetName = $ScanRulesetName
        }
        if ($PSBoundParameters.ContainsKey('ScanRulesetType')) {
            $Object.ScanRulesetType = $ScanRulesetType
        }
        if ($PSBoundParameters.ContainsKey('ServerEndpoint')) {
            $Object.ServerEndpoint = $ServerEndpoint
        }
        if ($PSBoundParameters.ContainsKey('Worker')) {
            $Object.Worker = $Worker
        }
        if ($PSBoundParameters.ContainsKey('Kind')) {
            $Object.Kind = $Kind
        }
        return $Object
    }
}

