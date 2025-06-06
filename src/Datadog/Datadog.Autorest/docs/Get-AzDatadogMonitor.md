---
external help file:
Module Name: Az.Datadog
online version: https://learn.microsoft.com/powershell/module/az.datadog/get-azdatadogmonitor
schema: 2.0.0
---

# Get-AzDatadogMonitor

## SYNOPSIS
Get the properties of a specific monitor resource.

## SYNTAX

### List (Default)
```
Get-AzDatadogMonitor [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### Get
```
Get-AzDatadogMonitor -Name <String> -ResourceGroupName <String> [-SubscriptionId <String[]>]
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-AzDatadogMonitor -InputObject <IDatadogIdentity> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### List1
```
Get-AzDatadogMonitor -ResourceGroupName <String> [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

## DESCRIPTION
Get the properties of a specific monitor resource.

## EXAMPLES

### Example 1: List all monitor resources under a subscription
```powershell
Get-AzDatadogMonitor
```

```output
Location    Name         Type
--------    ----         ----
eastus2euap Datadog microsoft.Datadog/monitors
```

This command lists all monitor resources under a subscription.

### Example 2: List monitor resources under a resource group
```powershell
Get-AzDatadogMonitor -ResourceGroupName azure-rg-Datadog
```

```output
Location    Name         Type
--------    ----         ----
eastus2euap Datadog microsoft.Datadog/monitors
```

This command lists all monitor resources under a resource group.

### Example 3: Get the properties of a specific monitor resource
```powershell
Get-AzDatadogMonitor -ResourceGroupName azure-rg-Datadog -Name Datadog
```

```output
Location    Name         Type
--------    ----         ----
eastus2euap Datadog microsoft.Datadog/monitors
```

This command gets the properties of a specific monitor resource.

### Example 4: Get the properties of a specific monitor resource by pipeline
```powershell
Get-AzDatadogMonitor -ResourceGroupName azure-rg-Datadog -Name Datadog | Get-AzDatadogMonitor
```

```output
Location    Name         Type
--------    ----         ----
eastus2euap Datadog microsoft.Datadog/monitors
```

This command gets the properties of a specific monitor resource by pipeline.

## PARAMETERS

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

### -InputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Datadog.Models.IDatadogIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Name
Monitor resource name

```yaml
Type: System.String
Parameter Sets: Get
Aliases: MonitorName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.
The name is case insensitive.

```yaml
Type: System.String
Parameter Sets: Get, List1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The ID of the target subscription.

```yaml
Type: System.String[]
Parameter Sets: Get, List, List1
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Datadog.Models.IDatadogIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Datadog.Models.IDatadogMonitorResource

## NOTES

## RELATED LINKS

