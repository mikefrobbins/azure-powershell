---
external help file:
Module Name: Az.Purview
online version: https://learn.microsoft.com/powershell/module/Az.Purview/new-azpurviewazuredataexplorerdatasourceobject
schema: 2.0.0
---

# New-AzPurviewAzureDataExplorerDataSourceObject

## SYNOPSIS
Create an in-memory object for AzureDataExplorerDataSource.

## SYNTAX

```
New-AzPurviewAzureDataExplorerDataSourceObject [-CollectionReferenceName <String>] [-CollectionType <String>]
 [-Endpoint <String>] [-Location <String>] [-ResourceGroup <String>] [-ResourceName <String>]
 [-SubscriptionId <String>] [<CommonParameters>]
```

## DESCRIPTION
Create an in-memory object for AzureDataExplorerDataSource.

## EXAMPLES

### Example 1: Create Azure Data Explorer data source object
```powershell
New-AzPurviewAzureDataExplorerDataSourceObject -CollectionReferenceName 'parv-brs-2' -CollectionType 'CollectionReference' -Endpoint 'https://adxd.australiaeast.kusto.windows.net'
```

```output
CollectionLastModifiedAt :
CollectionReferenceName  : parv-brs-2
CollectionType           : CollectionReference
CreatedAt                :
Endpoint                 : https://adxd.australiaeast.kusto.windows.net
Id                       :
Kind                     : AzureDataExplorer
LastModifiedAt           :
Location                 :
Name                     :
ResourceGroup            :
ResourceName             :
Scan                     :
SubscriptionId           :
```

Create Azure Data Explorer data source object

## PARAMETERS

### -CollectionReferenceName


```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CollectionType


```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Endpoint


```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Location


```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroup


```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceName


```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId


```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.AzureDataExplorerDataSource

## NOTES

## RELATED LINKS

