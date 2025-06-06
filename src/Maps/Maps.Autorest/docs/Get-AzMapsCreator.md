---
external help file:
Module Name: Az.Maps
online version: https://learn.microsoft.com/powershell/module/az.maps/get-azmapscreator
schema: 2.0.0
---

# Get-AzMapsCreator

## SYNOPSIS
Get a Maps Creator resource.

## SYNTAX

### List (Default)
```
Get-AzMapsCreator -AccountName <String> -ResourceGroupName <String> [-SubscriptionId <String[]>]
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### Get
```
Get-AzMapsCreator -AccountName <String> -Name <String> -ResourceGroupName <String>
 [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-AzMapsCreator -InputObject <IMapsIdentity> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### GetViaIdentityAccount
```
Get-AzMapsCreator -AccountInputObject <IMapsIdentity> -Name <String> [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

## DESCRIPTION
Get a Maps Creator resource.

## EXAMPLES

### Example 1: List all Maps Creator resources under a Maps Account
```powershell
Get-AzMapsCreator -ResourceGroupName azure-rg-test -AccountName pwsh-mapsAccount02 -Name creator-01
```

```output
Location Name       Type
-------- ----       ----
eastus2  creator-01 Microsoft.Maps/accounts/creators
```

This command lists Maps Creator resources under a Maps Account.

### Example 2: Get a Maps Creator resource
```powershell
Get-AzMapsCreator -ResourceGroupName azure-rg-test -AccountName pwsh-mapsAccount02 -Name creator-01
```

```output
Location Name       Type
-------- ----       ----
eastus2  creator-01 Microsoft.Maps/accounts/creators
```

This command gets a Maps Creator resource.

### Example 3: Get a Maps Creator resource by pipeline
```powershell
New-AzMapsCreator -ResourceGroupName azure-rg-test -AccountName pwsh-mapsAccount02 -Name creator-01 -Location eastus2 -StorageUnit 3 | Get-AzMapsCreator
```

```output
Location Name       Type
-------- ----       ----
eastus2  creator-01 Microsoft.Maps/accounts/creators
```

This command gets a Maps Creator resource by pipeline.

## PARAMETERS

### -AccountInputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Maps.Models.IMapsIdentity
Parameter Sets: GetViaIdentityAccount
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -AccountName
The name of the Maps Account.

```yaml
Type: System.String
Parameter Sets: Get, List
Aliases:

Required: True
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

### -InputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Maps.Models.IMapsIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Name
The name of the Maps Creator instance.

```yaml
Type: System.String
Parameter Sets: Get, GetViaIdentityAccount
Aliases: CreatorName

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
Parameter Sets: Get, List
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
Parameter Sets: Get, List
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

### Microsoft.Azure.PowerShell.Cmdlets.Maps.Models.IMapsIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Maps.Models.ICreator

## NOTES

## RELATED LINKS

