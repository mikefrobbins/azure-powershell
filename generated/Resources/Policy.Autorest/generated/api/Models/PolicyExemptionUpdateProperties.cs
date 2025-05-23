// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Policy.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Extensions;

    /// <summary>The policy exemption properties for Patch request.</summary>
    public partial class PolicyExemptionUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyExemptionUpdateProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyExemptionUpdatePropertiesInternal
    {

        /// <summary>Backing field for <see cref="AssignmentScopeValidation" /> property.</summary>
        private string _assignmentScopeValidation;

        /// <summary>The option whether validate the exemption is at or under the assignment scope.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Owned)]
        public string AssignmentScopeValidation { get => this._assignmentScopeValidation; set => this._assignmentScopeValidation = value; }

        /// <summary>Backing field for <see cref="ResourceSelector" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IResourceSelector> _resourceSelector;

        /// <summary>The resource selector list to filter policies by resource properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IResourceSelector> ResourceSelector { get => this._resourceSelector; set => this._resourceSelector = value; }

        /// <summary>Creates an new <see cref="PolicyExemptionUpdateProperties" /> instance.</summary>
        public PolicyExemptionUpdateProperties()
        {

        }
    }
    /// The policy exemption properties for Patch request.
    public partial interface IPolicyExemptionUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.IJsonSerializable
    {
        /// <summary>The option whether validate the exemption is at or under the assignment scope.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The option whether validate the exemption is at or under the assignment scope.",
        SerializedName = @"assignmentScopeValidation",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Policy.PSArgumentCompleterAttribute("Default", "DoNotValidate")]
        string AssignmentScopeValidation { get; set; }
        /// <summary>The resource selector list to filter policies by resource properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The resource selector list to filter policies by resource properties.",
        SerializedName = @"resourceSelectors",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IResourceSelector) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IResourceSelector> ResourceSelector { get; set; }

    }
    /// The policy exemption properties for Patch request.
    internal partial interface IPolicyExemptionUpdatePropertiesInternal

    {
        /// <summary>The option whether validate the exemption is at or under the assignment scope.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Policy.PSArgumentCompleterAttribute("Default", "DoNotValidate")]
        string AssignmentScopeValidation { get; set; }
        /// <summary>The resource selector list to filter policies by resource properties.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IResourceSelector> ResourceSelector { get; set; }

    }
}