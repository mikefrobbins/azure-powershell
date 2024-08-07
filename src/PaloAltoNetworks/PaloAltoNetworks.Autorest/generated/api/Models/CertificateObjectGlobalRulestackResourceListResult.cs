// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Runtime.Extensions;

    /// <summary>The response of a CertificateObjectGlobalRulestackResource list operation.</summary>
    public partial class CertificateObjectGlobalRulestackResourceListResult :
        Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.ICertificateObjectGlobalRulestackResourceListResult,
        Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.ICertificateObjectGlobalRulestackResourceListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Origin(Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.ICertificateObjectGlobalRulestackResource> _value;

        /// <summary>The items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Origin(Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.ICertificateObjectGlobalRulestackResource> Value { get => this._value; set => this._value = value; }

        /// <summary>
        /// Creates an new <see cref="CertificateObjectGlobalRulestackResourceListResult" /> instance.
        /// </summary>
        public CertificateObjectGlobalRulestackResourceListResult()
        {

        }
    }
    /// The response of a CertificateObjectGlobalRulestackResource list operation.
    public partial interface ICertificateObjectGlobalRulestackResourceListResult :
        Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Runtime.IJsonSerializable
    {
        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The link to the next page of items",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The items on this page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.ICertificateObjectGlobalRulestackResource) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.ICertificateObjectGlobalRulestackResource> Value { get; set; }

    }
    /// The response of a CertificateObjectGlobalRulestackResource list operation.
    internal partial interface ICertificateObjectGlobalRulestackResourceListResultInternal

    {
        /// <summary>The link to the next page of items</summary>
        string NextLink { get; set; }
        /// <summary>The items on this page</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.ICertificateObjectGlobalRulestackResource> Value { get; set; }

    }
}