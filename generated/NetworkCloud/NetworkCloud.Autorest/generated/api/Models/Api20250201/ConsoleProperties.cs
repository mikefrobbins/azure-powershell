// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Extensions;

    /// <summary>ConsoleProperties represents the properties of the virtual machine console.</summary>
    public partial class ConsoleProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IConsoleProperties,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IConsolePropertiesInternal
    {

        /// <summary>Backing field for <see cref="DetailedStatus" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ConsoleDetailedStatus? _detailedStatus;

        /// <summary>The more detailed status of the console.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ConsoleDetailedStatus? DetailedStatus { get => this._detailedStatus; }

        /// <summary>Backing field for <see cref="DetailedStatusMessage" /> property.</summary>
        private string _detailedStatusMessage;

        /// <summary>The descriptive message about the current detailed status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public string DetailedStatusMessage { get => this._detailedStatusMessage; }

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ConsoleEnabled _enabled;

        /// <summary>The indicator of whether the console access is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ConsoleEnabled Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>Backing field for <see cref="Expiration" /> property.</summary>
        private global::System.DateTime? _expiration;

        /// <summary>The date and time after which the key will be disallowed access.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public global::System.DateTime? Expiration { get => this._expiration; set => this._expiration = value; }

        /// <summary>Internal Acessors for DetailedStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ConsoleDetailedStatus? Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IConsolePropertiesInternal.DetailedStatus { get => this._detailedStatus; set { {_detailedStatus = value;} } }

        /// <summary>Internal Acessors for DetailedStatusMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IConsolePropertiesInternal.DetailedStatusMessage { get => this._detailedStatusMessage; set { {_detailedStatusMessage = value;} } }

        /// <summary>Internal Acessors for PrivateLinkServiceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IConsolePropertiesInternal.PrivateLinkServiceId { get => this._privateLinkServiceId; set { {_privateLinkServiceId = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ConsoleProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IConsolePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for SshPublicKey</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ISshPublicKey Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IConsolePropertiesInternal.SshPublicKey { get => (this._sshPublicKey = this._sshPublicKey ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.SshPublicKey()); set { {_sshPublicKey = value;} } }

        /// <summary>Internal Acessors for VirtualMachineAccessId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IConsolePropertiesInternal.VirtualMachineAccessId { get => this._virtualMachineAccessId; set { {_virtualMachineAccessId = value;} } }

        /// <summary>Backing field for <see cref="PrivateLinkServiceId" /> property.</summary>
        private string _privateLinkServiceId;

        /// <summary>
        /// The resource ID of the private link service that is used to provide virtual machine console access.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public string PrivateLinkServiceId { get => this._privateLinkServiceId; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ConsoleProvisioningState? _provisioningState;

        /// <summary>The provisioning state of the virtual machine console.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ConsoleProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="SshPublicKey" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ISshPublicKey _sshPublicKey;

        /// <summary>
        /// The SSH public key that will be provisioned for user access. The user is expected to have the corresponding SSH private
        /// key for logging in.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ISshPublicKey SshPublicKey { get => (this._sshPublicKey = this._sshPublicKey ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.SshPublicKey()); set => this._sshPublicKey = value; }

        /// <summary>The SSH public key data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Inlined)]
        public string SshPublicKeyData { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ISshPublicKeyInternal)SshPublicKey).KeyData; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ISshPublicKeyInternal)SshPublicKey).KeyData = value ; }

        /// <summary>Backing field for <see cref="VirtualMachineAccessId" /> property.</summary>
        private string _virtualMachineAccessId;

        /// <summary>
        /// The unique identifier for the virtual machine that is used to access the console.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public string VirtualMachineAccessId { get => this._virtualMachineAccessId; }

        /// <summary>Creates an new <see cref="ConsoleProperties" /> instance.</summary>
        public ConsoleProperties()
        {

        }
    }
    /// ConsoleProperties represents the properties of the virtual machine console.
    public partial interface IConsoleProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.IJsonSerializable
    {
        /// <summary>The more detailed status of the console.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The more detailed status of the console.",
        SerializedName = @"detailedStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ConsoleDetailedStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ConsoleDetailedStatus? DetailedStatus { get;  }
        /// <summary>The descriptive message about the current detailed status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The descriptive message about the current detailed status.",
        SerializedName = @"detailedStatusMessage",
        PossibleTypes = new [] { typeof(string) })]
        string DetailedStatusMessage { get;  }
        /// <summary>The indicator of whether the console access is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The indicator of whether the console access is enabled.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ConsoleEnabled) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ConsoleEnabled Enabled { get; set; }
        /// <summary>The date and time after which the key will be disallowed access.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The date and time after which the key will be disallowed access.",
        SerializedName = @"expiration",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? Expiration { get; set; }
        /// <summary>
        /// The resource ID of the private link service that is used to provide virtual machine console access.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resource ID of the private link service that is used to provide virtual machine console access.",
        SerializedName = @"privateLinkServiceId",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkServiceId { get;  }
        /// <summary>The provisioning state of the virtual machine console.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the virtual machine console.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ConsoleProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ConsoleProvisioningState? ProvisioningState { get;  }
        /// <summary>The SSH public key data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The SSH public key data.",
        SerializedName = @"keyData",
        PossibleTypes = new [] { typeof(string) })]
        string SshPublicKeyData { get; set; }
        /// <summary>
        /// The unique identifier for the virtual machine that is used to access the console.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The unique identifier for the virtual machine that is used to access the console.",
        SerializedName = @"virtualMachineAccessId",
        PossibleTypes = new [] { typeof(string) })]
        string VirtualMachineAccessId { get;  }

    }
    /// ConsoleProperties represents the properties of the virtual machine console.
    internal partial interface IConsolePropertiesInternal

    {
        /// <summary>The more detailed status of the console.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ConsoleDetailedStatus? DetailedStatus { get; set; }
        /// <summary>The descriptive message about the current detailed status.</summary>
        string DetailedStatusMessage { get; set; }
        /// <summary>The indicator of whether the console access is enabled.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ConsoleEnabled Enabled { get; set; }
        /// <summary>The date and time after which the key will be disallowed access.</summary>
        global::System.DateTime? Expiration { get; set; }
        /// <summary>
        /// The resource ID of the private link service that is used to provide virtual machine console access.
        /// </summary>
        string PrivateLinkServiceId { get; set; }
        /// <summary>The provisioning state of the virtual machine console.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ConsoleProvisioningState? ProvisioningState { get; set; }
        /// <summary>
        /// The SSH public key that will be provisioned for user access. The user is expected to have the corresponding SSH private
        /// key for logging in.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ISshPublicKey SshPublicKey { get; set; }
        /// <summary>The SSH public key data.</summary>
        string SshPublicKeyData { get; set; }
        /// <summary>
        /// The unique identifier for the virtual machine that is used to access the console.
        /// </summary>
        string VirtualMachineAccessId { get; set; }

    }
}