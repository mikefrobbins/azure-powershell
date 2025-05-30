---
external help file: Microsoft.Azure.PowerShell.Cmdlets.Network.dll-Help.xml
Module Name: Az.Network
online version: https://learn.microsoft.com/powershell/module/az.network/new-azfirewallpolicynetworkrule
schema: 2.0.0
---

# New-AzFirewallPolicyNetworkRule

## SYNOPSIS
Create a new Azure Firewall Policy Network Rule

## SYNTAX

### SourceAddress
```
New-AzFirewallPolicyNetworkRule -Name <String> [-Description <String>] -SourceAddress <String[]>
 [-DestinationAddress <String[]>] [-DestinationIpGroup <String[]>] -DestinationPort <String[]>
 [-DestinationFqdn <String[]>] -Protocol <String[]> [-DefaultProfile <IAzureContextContainer>]
 [<CommonParameters>]
```

### SourceIpGroup
```
New-AzFirewallPolicyNetworkRule -Name <String> [-Description <String>] -SourceIpGroup <String[]>
 [-DestinationAddress <String[]>] [-DestinationIpGroup <String[]>] -DestinationPort <String[]>
 [-DestinationFqdn <String[]>] -Protocol <String[]> [-DefaultProfile <IAzureContextContainer>]
 [<CommonParameters>]
```

## DESCRIPTION
The **New-AzFirewallPolicyNetworkRule** cmdlet creates a Network rule for a Azure Firewall Policy.

## EXAMPLES

### Example 1
```powershell
New-AzFirewallPolicyNetworkRule -Name NRC1 -Protocol "TCP" -SourceAddress "192.168.0.0/16" -DestinationAddress * -DestinationPort *
```

This example creates an network rule with the source address, protocol , destination address and destination port

## PARAMETERS

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: Microsoft.Azure.Commands.Common.Authentication.Abstractions.Core.IAzureContextContainer
Parameter Sets: (All)
Aliases: AzContext, AzureRmContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
The description of the rule

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

### -DestinationAddress
The destination addresses of the rule

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DestinationFqdn
The destination FQDN of the rule

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DestinationIpGroup
The destination ipgroups of the rule

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DestinationPort
The destination ports of the rule

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
The name of the Network Rule

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Protocol
The protocols of the rule

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:
Accepted values: Any, TCP, UDP, ICMP

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SourceAddress
The source addresses of the rule

```yaml
Type: System.String[]
Parameter Sets: SourceAddress
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SourceIpGroup
The source ipgroups of the rule

```yaml
Type: System.String[]
Parameter Sets: SourceIpGroup
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### None

## OUTPUTS

### Microsoft.Azure.Commands.Network.Models.PSAzureFirewallNetworkRule

## NOTES

## RELATED LINKS
