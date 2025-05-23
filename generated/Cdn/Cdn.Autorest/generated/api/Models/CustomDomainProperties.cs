// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>The JSON object that contains the properties of the custom domain to create.</summary>
    public partial class CustomDomainProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ICustomDomainProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ICustomDomainPropertiesInternal
    {

        /// <summary>Backing field for <see cref="CustomHttpsParameter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ICustomDomainHttpsParameters _customHttpsParameter;

        /// <summary>Certificate parameters for securing custom HTTPS</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ICustomDomainHttpsParameters CustomHttpsParameter { get => (this._customHttpsParameter = this._customHttpsParameter ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.CustomDomainHttpsParameters()); set => this._customHttpsParameter = value; }

        /// <summary>Backing field for <see cref="CustomHttpsProvisioningState" /> property.</summary>
        private string _customHttpsProvisioningState;

        /// <summary>Provisioning status of the custom domain.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string CustomHttpsProvisioningState { get => this._customHttpsProvisioningState; }

        /// <summary>Backing field for <see cref="CustomHttpsProvisioningSubstate" /> property.</summary>
        private string _customHttpsProvisioningSubstate;

        /// <summary>
        /// Provisioning substate shows the progress of custom HTTPS enabling/disabling process step by step.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string CustomHttpsProvisioningSubstate { get => this._customHttpsProvisioningSubstate; }

        /// <summary>Backing field for <see cref="HostName" /> property.</summary>
        private string _hostName;

        /// <summary>The host name of the custom domain. Must be a domain name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string HostName { get => this._hostName; set => this._hostName = value; }

        /// <summary>Internal Acessors for CustomHttpsProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ICustomDomainPropertiesInternal.CustomHttpsProvisioningState { get => this._customHttpsProvisioningState; set { {_customHttpsProvisioningState = value;} } }

        /// <summary>Internal Acessors for CustomHttpsProvisioningSubstate</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ICustomDomainPropertiesInternal.CustomHttpsProvisioningSubstate { get => this._customHttpsProvisioningSubstate; set { {_customHttpsProvisioningSubstate = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ICustomDomainPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for ResourceState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ICustomDomainPropertiesInternal.ResourceState { get => this._resourceState; set { {_resourceState = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Provisioning status of Custom Https of the custom domain.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="ResourceState" /> property.</summary>
        private string _resourceState;

        /// <summary>Resource status of the custom domain.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string ResourceState { get => this._resourceState; }

        /// <summary>Backing field for <see cref="ValidationData" /> property.</summary>
        private string _validationData;

        /// <summary>
        /// Special validation or data may be required when delivering CDN to some regions due to local compliance reasons. E.g. ICP
        /// license number of a custom domain is required to deliver content in China.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string ValidationData { get => this._validationData; set => this._validationData = value; }

        /// <summary>Creates an new <see cref="CustomDomainProperties" /> instance.</summary>
        public CustomDomainProperties()
        {

        }
    }
    /// The JSON object that contains the properties of the custom domain to create.
    public partial interface ICustomDomainProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable
    {
        /// <summary>Certificate parameters for securing custom HTTPS</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Certificate parameters for securing custom HTTPS",
        SerializedName = @"customHttpsParameters",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ICustomDomainHttpsParameters) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ICustomDomainHttpsParameters CustomHttpsParameter { get; set; }
        /// <summary>Provisioning status of the custom domain.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning status of the custom domain.",
        SerializedName = @"customHttpsProvisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Cdn.PSArgumentCompleterAttribute("Enabling", "Enabled", "Disabling", "Disabled", "Failed")]
        string CustomHttpsProvisioningState { get;  }
        /// <summary>
        /// Provisioning substate shows the progress of custom HTTPS enabling/disabling process step by step.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning substate shows the progress of custom HTTPS enabling/disabling process step by step.",
        SerializedName = @"customHttpsProvisioningSubstate",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Cdn.PSArgumentCompleterAttribute("SubmittingDomainControlValidationRequest", "PendingDomainControlValidationREquestApproval", "DomainControlValidationRequestApproved", "DomainControlValidationRequestRejected", "DomainControlValidationRequestTimedOut", "IssuingCertificate", "DeployingCertificate", "CertificateDeployed", "DeletingCertificate", "CertificateDeleted")]
        string CustomHttpsProvisioningSubstate { get;  }
        /// <summary>The host name of the custom domain. Must be a domain name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The host name of the custom domain. Must be a domain name.",
        SerializedName = @"hostName",
        PossibleTypes = new [] { typeof(string) })]
        string HostName { get; set; }
        /// <summary>Provisioning status of Custom Https of the custom domain.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning status of Custom Https of the custom domain.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Cdn.PSArgumentCompleterAttribute("Enabling", "Enabled", "Disabling", "Disabled", "Failed")]
        string ProvisioningState { get;  }
        /// <summary>Resource status of the custom domain.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Resource status of the custom domain.",
        SerializedName = @"resourceState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Cdn.PSArgumentCompleterAttribute("Creating", "Active", "Deleting")]
        string ResourceState { get;  }
        /// <summary>
        /// Special validation or data may be required when delivering CDN to some regions due to local compliance reasons. E.g. ICP
        /// license number of a custom domain is required to deliver content in China.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Special validation or data may be required when delivering CDN to some regions due to local compliance reasons. E.g. ICP license number of a custom domain is required to deliver content in China.",
        SerializedName = @"validationData",
        PossibleTypes = new [] { typeof(string) })]
        string ValidationData { get; set; }

    }
    /// The JSON object that contains the properties of the custom domain to create.
    internal partial interface ICustomDomainPropertiesInternal

    {
        /// <summary>Certificate parameters for securing custom HTTPS</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ICustomDomainHttpsParameters CustomHttpsParameter { get; set; }
        /// <summary>Provisioning status of the custom domain.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Cdn.PSArgumentCompleterAttribute("Enabling", "Enabled", "Disabling", "Disabled", "Failed")]
        string CustomHttpsProvisioningState { get; set; }
        /// <summary>
        /// Provisioning substate shows the progress of custom HTTPS enabling/disabling process step by step.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Cdn.PSArgumentCompleterAttribute("SubmittingDomainControlValidationRequest", "PendingDomainControlValidationREquestApproval", "DomainControlValidationRequestApproved", "DomainControlValidationRequestRejected", "DomainControlValidationRequestTimedOut", "IssuingCertificate", "DeployingCertificate", "CertificateDeployed", "DeletingCertificate", "CertificateDeleted")]
        string CustomHttpsProvisioningSubstate { get; set; }
        /// <summary>The host name of the custom domain. Must be a domain name.</summary>
        string HostName { get; set; }
        /// <summary>Provisioning status of Custom Https of the custom domain.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Cdn.PSArgumentCompleterAttribute("Enabling", "Enabled", "Disabling", "Disabled", "Failed")]
        string ProvisioningState { get; set; }
        /// <summary>Resource status of the custom domain.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Cdn.PSArgumentCompleterAttribute("Creating", "Active", "Deleting")]
        string ResourceState { get; set; }
        /// <summary>
        /// Special validation or data may be required when delivering CDN to some regions due to local compliance reasons. E.g. ICP
        /// license number of a custom domain is required to deliver content in China.
        /// </summary>
        string ValidationData { get; set; }

    }
}