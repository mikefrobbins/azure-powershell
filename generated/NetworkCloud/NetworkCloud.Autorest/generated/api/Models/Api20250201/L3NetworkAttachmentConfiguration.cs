// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Extensions;

    /// <summary>
    /// L3NetworkAttachmentConfiguration represents the configuration of the attachment of a Layer 3 network.
    /// </summary>
    public partial class L3NetworkAttachmentConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IL3NetworkAttachmentConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IL3NetworkAttachmentConfigurationInternal
    {

        /// <summary>Backing field for <see cref="IpamEnabled" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.L3NetworkConfigurationIpamEnabled? _ipamEnabled;

        /// <summary>
        /// The indication of whether this network will or will not perform IP address management and allocate IP addresses when attached.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.L3NetworkConfigurationIpamEnabled? IpamEnabled { get => this._ipamEnabled; set => this._ipamEnabled = value; }

        /// <summary>Backing field for <see cref="NetworkId" /> property.</summary>
        private string _networkId;

        /// <summary>The resource ID of the network that is being configured for attachment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public string NetworkId { get => this._networkId; set => this._networkId = value; }

        /// <summary>Backing field for <see cref="PluginType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.KubernetesPluginType? _pluginType;

        /// <summary>The indicator of how this network will be utilized by the Kubernetes cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.KubernetesPluginType? PluginType { get => this._pluginType; set => this._pluginType = value; }

        /// <summary>Creates an new <see cref="L3NetworkAttachmentConfiguration" /> instance.</summary>
        public L3NetworkAttachmentConfiguration()
        {

        }
    }
    /// L3NetworkAttachmentConfiguration represents the configuration of the attachment of a Layer 3 network.
    public partial interface IL3NetworkAttachmentConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The indication of whether this network will or will not perform IP address management and allocate IP addresses when attached.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The indication of whether this network will or will not perform IP address management and allocate IP addresses when attached.",
        SerializedName = @"ipamEnabled",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.L3NetworkConfigurationIpamEnabled) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.L3NetworkConfigurationIpamEnabled? IpamEnabled { get; set; }
        /// <summary>The resource ID of the network that is being configured for attachment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The resource ID of the network that is being configured for attachment.",
        SerializedName = @"networkId",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkId { get; set; }
        /// <summary>The indicator of how this network will be utilized by the Kubernetes cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The indicator of how this network will be utilized by the Kubernetes cluster.",
        SerializedName = @"pluginType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.KubernetesPluginType) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.KubernetesPluginType? PluginType { get; set; }

    }
    /// L3NetworkAttachmentConfiguration represents the configuration of the attachment of a Layer 3 network.
    internal partial interface IL3NetworkAttachmentConfigurationInternal

    {
        /// <summary>
        /// The indication of whether this network will or will not perform IP address management and allocate IP addresses when attached.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.L3NetworkConfigurationIpamEnabled? IpamEnabled { get; set; }
        /// <summary>The resource ID of the network that is being configured for attachment.</summary>
        string NetworkId { get; set; }
        /// <summary>The indicator of how this network will be utilized by the Kubernetes cluster.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.KubernetesPluginType? PluginType { get; set; }

    }
}