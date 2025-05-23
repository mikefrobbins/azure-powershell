// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Extensions;

    /// <summary>Managed Identity properties.</summary>
    public partial class AmlFilesystemIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Models.IAmlFilesystemIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Models.IAmlFilesystemIdentityInternal
    {

        /// <summary>Internal Acessors for PrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Models.IAmlFilesystemIdentityInternal.PrincipalId { get => this._principalId; set { {_principalId = value;} } }

        /// <summary>Internal Acessors for TenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Models.IAmlFilesystemIdentityInternal.TenantId { get => this._tenantId; set { {_tenantId = value;} } }

        /// <summary>Backing field for <see cref="PrincipalId" /> property.</summary>
        private string _principalId;

        /// <summary>The principal ID for the user-assigned identity of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageCache.PropertyOrigin.Owned)]
        public string PrincipalId { get => this._principalId; }

        /// <summary>Backing field for <see cref="TenantId" /> property.</summary>
        private string _tenantId;

        /// <summary>The tenant ID associated with the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageCache.PropertyOrigin.Owned)]
        public string TenantId { get => this._tenantId; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The type of identity used for the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageCache.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Backing field for <see cref="UserAssignedIdentity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Models.IUserAssignedIdentities _userAssignedIdentity;

        /// <summary>
        /// A dictionary where each key is a user assigned identity resource ID, and each key's value is an empty dictionary.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageCache.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Models.IUserAssignedIdentities UserAssignedIdentity { get => (this._userAssignedIdentity = this._userAssignedIdentity ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Models.UserAssignedIdentities()); set => this._userAssignedIdentity = value; }

        /// <summary>Creates an new <see cref="AmlFilesystemIdentity" /> instance.</summary>
        public AmlFilesystemIdentity()
        {

        }
    }
    /// Managed Identity properties.
    public partial interface IAmlFilesystemIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.IJsonSerializable
    {
        /// <summary>The principal ID for the user-assigned identity of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The principal ID for the user-assigned identity of the resource.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalId { get;  }
        /// <summary>The tenant ID associated with the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The tenant ID associated with the resource.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string TenantId { get;  }
        /// <summary>The type of identity used for the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of identity used for the resource.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.StorageCache.PSArgumentCompleterAttribute("UserAssigned", "None")]
        string Type { get; set; }
        /// <summary>
        /// A dictionary where each key is a user assigned identity resource ID, and each key's value is an empty dictionary.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A dictionary where each key is a user assigned identity resource ID, and each key's value is an empty dictionary.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Models.IUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Models.IUserAssignedIdentities UserAssignedIdentity { get; set; }

    }
    /// Managed Identity properties.
    internal partial interface IAmlFilesystemIdentityInternal

    {
        /// <summary>The principal ID for the user-assigned identity of the resource.</summary>
        string PrincipalId { get; set; }
        /// <summary>The tenant ID associated with the resource.</summary>
        string TenantId { get; set; }
        /// <summary>The type of identity used for the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.StorageCache.PSArgumentCompleterAttribute("UserAssigned", "None")]
        string Type { get; set; }
        /// <summary>
        /// A dictionary where each key is a user assigned identity resource ID, and each key's value is an empty dictionary.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Models.IUserAssignedIdentities UserAssignedIdentity { get; set; }

    }
}