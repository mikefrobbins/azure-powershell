// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Extensions;

    /// <summary>Address Resource Collection</summary>
    public partial class AddressResourceList :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressResourceList,
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressResourceListInternal
    {

        /// <summary>Internal Acessors for Value</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressResource> Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressResourceListInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>Link for the next set of job resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressResource> _value;

        /// <summary>List of address resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressResource> Value { get => this._value; }

        /// <summary>Creates an new <see cref="AddressResourceList" /> instance.</summary>
        public AddressResourceList()
        {

        }
    }
    /// Address Resource Collection
    public partial interface IAddressResourceList :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.IJsonSerializable
    {
        /// <summary>Link for the next set of job resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Link for the next set of job resources.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>List of address resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of address resources.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressResource) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressResource> Value { get;  }

    }
    /// Address Resource Collection
    internal partial interface IAddressResourceListInternal

    {
        /// <summary>Link for the next set of job resources.</summary>
        string NextLink { get; set; }
        /// <summary>List of address resources.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressResource> Value { get; set; }

    }
}