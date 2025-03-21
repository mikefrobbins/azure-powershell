// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Extensions;

    /// <summary>Informatica Serverless Network profile properties update.</summary>
    public partial class ServerlessRuntimeNetworkProfileUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeNetworkProfileUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeNetworkProfileUpdateInternal
    {

        /// <summary>Internal Acessors for NetworkInterfaceConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.INetworkInterfaceConfigurationUpdate Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeNetworkProfileUpdateInternal.NetworkInterfaceConfiguration { get => (this._networkInterfaceConfiguration = this._networkInterfaceConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.NetworkInterfaceConfigurationUpdate()); set { {_networkInterfaceConfiguration = value;} } }

        /// <summary>Backing field for <see cref="NetworkInterfaceConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.INetworkInterfaceConfigurationUpdate _networkInterfaceConfiguration;

        /// <summary>Network Interface Configuration Profile Update</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.INetworkInterfaceConfigurationUpdate NetworkInterfaceConfiguration { get => (this._networkInterfaceConfiguration = this._networkInterfaceConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.NetworkInterfaceConfigurationUpdate()); set => this._networkInterfaceConfiguration = value; }

        /// <summary>Virtual network subnet resource id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string NetworkInterfaceConfigurationSubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.INetworkInterfaceConfigurationUpdateInternal)NetworkInterfaceConfiguration).SubnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.INetworkInterfaceConfigurationUpdateInternal)NetworkInterfaceConfiguration).SubnetId = value ?? null; }

        /// <summary>Virtual network resource id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string NetworkInterfaceConfigurationVnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.INetworkInterfaceConfigurationUpdateInternal)NetworkInterfaceConfiguration).VnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.INetworkInterfaceConfigurationUpdateInternal)NetworkInterfaceConfiguration).VnetId = value ?? null; }

        /// <summary>Virtual network resource guid</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string NetworkInterfaceConfigurationVnetResourceGuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.INetworkInterfaceConfigurationUpdateInternal)NetworkInterfaceConfiguration).VnetResourceGuid; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.INetworkInterfaceConfigurationUpdateInternal)NetworkInterfaceConfiguration).VnetResourceGuid = value ?? null; }

        /// <summary>Creates an new <see cref="ServerlessRuntimeNetworkProfileUpdate" /> instance.</summary>
        public ServerlessRuntimeNetworkProfileUpdate()
        {

        }
    }
    /// Informatica Serverless Network profile properties update.
    public partial interface IServerlessRuntimeNetworkProfileUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.IJsonSerializable
    {
        /// <summary>Virtual network subnet resource id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Virtual network subnet resource id",
        SerializedName = @"subnetId",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkInterfaceConfigurationSubnetId { get; set; }
        /// <summary>Virtual network resource id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Virtual network resource id",
        SerializedName = @"vnetId",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkInterfaceConfigurationVnetId { get; set; }
        /// <summary>Virtual network resource guid</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Virtual network resource guid",
        SerializedName = @"vnetResourceGuid",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkInterfaceConfigurationVnetResourceGuid { get; set; }

    }
    /// Informatica Serverless Network profile properties update.
    internal partial interface IServerlessRuntimeNetworkProfileUpdateInternal

    {
        /// <summary>Network Interface Configuration Profile Update</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.INetworkInterfaceConfigurationUpdate NetworkInterfaceConfiguration { get; set; }
        /// <summary>Virtual network subnet resource id</summary>
        string NetworkInterfaceConfigurationSubnetId { get; set; }
        /// <summary>Virtual network resource id</summary>
        string NetworkInterfaceConfigurationVnetId { get; set; }
        /// <summary>Virtual network resource guid</summary>
        string NetworkInterfaceConfigurationVnetResourceGuid { get; set; }

    }
}