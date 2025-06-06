---
external help file:
Module Name: Az.SelfHelp
online version: https://learn.microsoft.com/powershell/module/az.selfhelp/new-azselfhelpdiagnostic
schema: 2.0.0
---

# New-AzSelfHelpDiagnostic

## SYNOPSIS
create a diagnostic for the specific resource using solutionId and requiredInputs* from discovery solutions.
\<br/\>Diagnostics are powerful solutions that access product resources or other relevant data and provide the root cause of the issue and the steps to address the issue.\<br/\>\<br/\> \<b\>Note: \</b\> ‘requiredInputs’ from Discovery solutions response must be passed via ‘additionalParameters’ as an input to Diagnostics API.

## SYNTAX

### CreateExpanded (Default)
```
New-AzSelfHelpDiagnostic -Scope <String> -SResourceName <String> [-GlobalParameter <Hashtable>]
 [-Insight <IDiagnosticInvocation[]>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-AzSelfHelpDiagnostic -InputObject <ISelfHelpIdentity> [-GlobalParameter <Hashtable>]
 [-Insight <IDiagnosticInvocation[]>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaJsonFilePath
```
New-AzSelfHelpDiagnostic -Scope <String> -SResourceName <String> -JsonFilePath <String>
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaJsonString
```
New-AzSelfHelpDiagnostic -Scope <String> -SResourceName <String> -JsonString <String>
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
create a diagnostic for the specific resource using solutionId and requiredInputs* from discovery solutions.
\<br/\>Diagnostics are powerful solutions that access product resources or other relevant data and provide the root cause of the issue and the steps to address the issue.\<br/\>\<br/\> \<b\>Note: \</b\> ‘requiredInputs’ from Discovery solutions response must be passed via ‘additionalParameters’ as an input to Diagnostics API.

## EXAMPLES

### Example 1: Create Diagnostic for a KeyVault resource.
```powershell
$insightsToInvoke = [ordered]@{
                "solutionId" = "Demo2InsightV2"
            }
New-AzSelfHelpDiagnostic -Scope "/subscriptions/6bded6d5-a6af-43e1-96d3-bf71f6f5f8ba/resourceGroups/aravind-test-resources/providers/Microsoft.KeyVault/vaults/ab-tests-kv-an" -SResourceName ab-test-973 -Insight $insightsToInvoke
```

```output
Name        SystemDataCreatedAt SystemDataCreatedBy SystemDataCreatedByType SystemDataLastModifiedAt SystemDataLastModifiedBy SystemDataLastModifiedByType ResourceGroupName
----        ------------------- ------------------- ----------------------- ------------------------ ------------------------ ---------------------------- -----------------
ab-test-973                                                                                                                                                aravind-test-reso…
```

Creates a diagnostic for a KeyVault resource.

## PARAMETERS

### -AsJob
Run the command as a job

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The DefaultProfile parameter is not functional.
Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GlobalParameter
Global parameters is an optional map which can be used to add key and value to request body to improve the diagnostics results

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISelfHelpIdentity
Parameter Sets: CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Insight
SolutionIds that are needed to be invoked.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticInvocation[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JsonFilePath
Path of Json file supplied to the Create operation

```yaml
Type: System.String
Parameter Sets: CreateViaJsonFilePath
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JsonString
Json string supplied to the Create operation

```yaml
Type: System.String
Parameter Sets: CreateViaJsonString
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NoWait
Run the command asynchronously

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Scope
scope = resourceUri of affected resource.\<br/\> For example: /subscriptions/0d0fcd2e-c4fd-4349-8497-200edb3923c6/resourcegroups/myresourceGroup/providers/Microsoft.KeyVault/vaults/test-keyvault-non-read

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaJsonFilePath, CreateViaJsonString
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SResourceName
Unique resource name for insight resources

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaJsonFilePath, CreateViaJsonString
Aliases: DiagnosticsResourceName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISelfHelpIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticResource

## NOTES

## RELATED LINKS

