// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Extensions;

    /// <summary>virtualNetworkAddress resource properties</summary>
    public partial class VirtualNetworkAddressProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IVirtualNetworkAddressProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IVirtualNetworkAddressPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Domain" /> property.</summary>
        private string _domain;

        /// <summary>Virtual network address fully qualified domain name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Origin(Microsoft.Azure.PowerShell.Cmdlets.Oracle.PropertyOrigin.Owned)]
        public string Domain { get => this._domain; }

        /// <summary>Backing field for <see cref="IPAddress" /> property.</summary>
        private string _iPAddress;

        /// <summary>Virtual network Address address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Origin(Microsoft.Azure.PowerShell.Cmdlets.Oracle.PropertyOrigin.Owned)]
        public string IPAddress { get => this._iPAddress; set => this._iPAddress = value; }

        /// <summary>Backing field for <see cref="LifecycleDetail" /> property.</summary>
        private string _lifecycleDetail;

        /// <summary>
        /// Additional information about the current lifecycle state of the application virtual IP (VIP) address.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Origin(Microsoft.Azure.PowerShell.Cmdlets.Oracle.PropertyOrigin.Owned)]
        public string LifecycleDetail { get => this._lifecycleDetail; }

        /// <summary>Backing field for <see cref="LifecycleState" /> property.</summary>
        private string _lifecycleState;

        /// <summary>virtual network address lifecycle state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Origin(Microsoft.Azure.PowerShell.Cmdlets.Oracle.PropertyOrigin.Owned)]
        public string LifecycleState { get => this._lifecycleState; }

        /// <summary>Internal Acessors for Domain</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IVirtualNetworkAddressPropertiesInternal.Domain { get => this._domain; set { {_domain = value;} } }

        /// <summary>Internal Acessors for LifecycleDetail</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IVirtualNetworkAddressPropertiesInternal.LifecycleDetail { get => this._lifecycleDetail; set { {_lifecycleDetail = value;} } }

        /// <summary>Internal Acessors for LifecycleState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IVirtualNetworkAddressPropertiesInternal.LifecycleState { get => this._lifecycleState; set { {_lifecycleState = value;} } }

        /// <summary>Internal Acessors for Ocid</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IVirtualNetworkAddressPropertiesInternal.Ocid { get => this._ocid; set { {_ocid = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IVirtualNetworkAddressPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for TimeAssigned</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IVirtualNetworkAddressPropertiesInternal.TimeAssigned { get => this._timeAssigned; set { {_timeAssigned = value;} } }

        /// <summary>Backing field for <see cref="Ocid" /> property.</summary>
        private string _ocid;

        /// <summary>Application VIP OCID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Origin(Microsoft.Azure.PowerShell.Cmdlets.Oracle.PropertyOrigin.Owned)]
        public string Ocid { get => this._ocid; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Azure resource provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Origin(Microsoft.Azure.PowerShell.Cmdlets.Oracle.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="TimeAssigned" /> property.</summary>
        private global::System.DateTime? _timeAssigned;

        /// <summary>
        /// The date and time when the create operation for the application virtual IP (VIP) address completed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Origin(Microsoft.Azure.PowerShell.Cmdlets.Oracle.PropertyOrigin.Owned)]
        public global::System.DateTime? TimeAssigned { get => this._timeAssigned; }

        /// <summary>Backing field for <see cref="VMOcid" /> property.</summary>
        private string _vMOcid;

        /// <summary>Virtual Machine OCID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Origin(Microsoft.Azure.PowerShell.Cmdlets.Oracle.PropertyOrigin.Owned)]
        public string VMOcid { get => this._vMOcid; set => this._vMOcid = value; }

        /// <summary>Creates an new <see cref="VirtualNetworkAddressProperties" /> instance.</summary>
        public VirtualNetworkAddressProperties()
        {

        }
    }
    /// virtualNetworkAddress resource properties
    public partial interface IVirtualNetworkAddressProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.IJsonSerializable
    {
        /// <summary>Virtual network address fully qualified domain name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Virtual network address fully qualified domain name.",
        SerializedName = @"domain",
        PossibleTypes = new [] { typeof(string) })]
        string Domain { get;  }
        /// <summary>Virtual network Address address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Virtual network Address address.",
        SerializedName = @"ipAddress",
        PossibleTypes = new [] { typeof(string) })]
        string IPAddress { get; set; }
        /// <summary>
        /// Additional information about the current lifecycle state of the application virtual IP (VIP) address.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Additional information about the current lifecycle state of the application virtual IP (VIP) address.",
        SerializedName = @"lifecycleDetails",
        PossibleTypes = new [] { typeof(string) })]
        string LifecycleDetail { get;  }
        /// <summary>virtual network address lifecycle state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"virtual network address lifecycle state.",
        SerializedName = @"lifecycleState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Oracle.PSArgumentCompleterAttribute("Provisioning", "Available", "Terminating", "Terminated", "Failed")]
        string LifecycleState { get;  }
        /// <summary>Application VIP OCID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Application VIP OCID.",
        SerializedName = @"ocid",
        PossibleTypes = new [] { typeof(string) })]
        string Ocid { get;  }
        /// <summary>Azure resource provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Azure resource provisioning state.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Oracle.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning")]
        string ProvisioningState { get;  }
        /// <summary>
        /// The date and time when the create operation for the application virtual IP (VIP) address completed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The date and time when the create operation for the application virtual IP (VIP) address completed.",
        SerializedName = @"timeAssigned",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? TimeAssigned { get;  }
        /// <summary>Virtual Machine OCID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Virtual Machine OCID.",
        SerializedName = @"vmOcid",
        PossibleTypes = new [] { typeof(string) })]
        string VMOcid { get; set; }

    }
    /// virtualNetworkAddress resource properties
    internal partial interface IVirtualNetworkAddressPropertiesInternal

    {
        /// <summary>Virtual network address fully qualified domain name.</summary>
        string Domain { get; set; }
        /// <summary>Virtual network Address address.</summary>
        string IPAddress { get; set; }
        /// <summary>
        /// Additional information about the current lifecycle state of the application virtual IP (VIP) address.
        /// </summary>
        string LifecycleDetail { get; set; }
        /// <summary>virtual network address lifecycle state.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Oracle.PSArgumentCompleterAttribute("Provisioning", "Available", "Terminating", "Terminated", "Failed")]
        string LifecycleState { get; set; }
        /// <summary>Application VIP OCID.</summary>
        string Ocid { get; set; }
        /// <summary>Azure resource provisioning state.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Oracle.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning")]
        string ProvisioningState { get; set; }
        /// <summary>
        /// The date and time when the create operation for the application virtual IP (VIP) address completed.
        /// </summary>
        global::System.DateTime? TimeAssigned { get; set; }
        /// <summary>Virtual Machine OCID.</summary>
        string VMOcid { get; set; }

    }
}