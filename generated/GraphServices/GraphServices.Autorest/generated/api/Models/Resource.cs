// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Runtime.Extensions;

    /// <summary>An Azure resource.</summary>
    public partial class Resource :
        Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IResource,
        Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IResourceInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Azure resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.GraphServices.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>Location of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.GraphServices.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IResourceInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IResourceInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IResourceInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Azure resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.GraphServices.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IResourceTags _tag;

        /// <summary>resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.GraphServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IResourceTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.ResourceTags()); set => this._tag = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Azure resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.GraphServices.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="Resource" /> instance.</summary>
        public Resource()
        {

        }
    }
    /// An Azure resource.
    public partial interface IResource :
        Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Runtime.IJsonSerializable
    {
        /// <summary>Azure resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Azure resource ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>Location of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Location of the resource.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>Azure resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Azure resource name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IResourceTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IResourceTags Tag { get; set; }
        /// <summary>Azure resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Azure resource type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// An Azure resource.
    internal partial interface IResourceInternal

    {
        /// <summary>Azure resource ID.</summary>
        string Id { get; set; }
        /// <summary>Location of the resource.</summary>
        string Location { get; set; }
        /// <summary>Azure resource name.</summary>
        string Name { get; set; }
        /// <summary>resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IResourceTags Tag { get; set; }
        /// <summary>Azure resource type.</summary>
        string Type { get; set; }

    }
}