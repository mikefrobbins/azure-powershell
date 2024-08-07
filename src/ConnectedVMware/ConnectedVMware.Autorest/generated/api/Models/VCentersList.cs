// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Extensions;

    /// <summary>List of VCenters.</summary>
    public partial class VCentersList :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IVCentersList,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IVCentersListInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>Url to follow for getting next page of VCenters.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IVCenter> _value;

        /// <summary>Array of VCenters</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IVCenter> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="VCentersList" /> instance.</summary>
        public VCentersList()
        {

        }
    }
    /// List of VCenters.
    public partial interface IVCentersList :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.IJsonSerializable
    {
        /// <summary>Url to follow for getting next page of VCenters.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Url to follow for getting next page of VCenters.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>Array of VCenters</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Array of VCenters",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IVCenter) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IVCenter> Value { get; set; }

    }
    /// List of VCenters.
    internal partial interface IVCentersListInternal

    {
        /// <summary>Url to follow for getting next page of VCenters.</summary>
        string NextLink { get; set; }
        /// <summary>Array of VCenters</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IVCenter> Value { get; set; }

    }
}