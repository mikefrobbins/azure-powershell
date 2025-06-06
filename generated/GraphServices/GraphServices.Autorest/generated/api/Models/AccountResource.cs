// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Runtime.Extensions;

    /// <summary>Account details</summary>
    public partial class AccountResource :
        Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResource,
        Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.Resource();

        /// <summary>Customer owned application ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.GraphServices.PropertyOrigin.Inlined)]
        public string AppId { get => ((Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourcePropertiesInternal)Property).AppId; set => ((Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourcePropertiesInternal)Property).AppId = value ?? null; }

        /// <summary>Billing Plan Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.GraphServices.PropertyOrigin.Inlined)]
        public string BillingPlanId { get => ((Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourcePropertiesInternal)Property).BillingPlanId; }

        /// <summary>Azure resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.GraphServices.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IResourceInternal)__resource).Id; }

        /// <summary>Location of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.GraphServices.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IResourceInternal)__resource).Location = value ?? null; }

        /// <summary>Internal Acessors for BillingPlanId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourceInternal.BillingPlanId { get => ((Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourcePropertiesInternal)Property).BillingPlanId; set => ((Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourcePropertiesInternal)Property).BillingPlanId = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourceProperties Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.AccountResourceProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourcePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourcePropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourceSystemData Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourceInternal.SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.AccountResourceSystemData()); set { {_systemData = value;} } }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourceSystemDataInternal)SystemData).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourceSystemDataInternal)SystemData).CreatedAt = value; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourceSystemDataInternal)SystemData).CreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourceSystemDataInternal)SystemData).CreatedByType = value; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourceSystemDataInternal)SystemData).LastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourceSystemDataInternal)SystemData).LastModifiedAt = value; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourceSystemDataInternal)SystemData).LastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourceSystemDataInternal)SystemData).LastModifiedByType = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IResourceInternal)__resource).Type = value; }

        /// <summary>Azure resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.GraphServices.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourceProperties _property;

        /// <summary>Property bag from billing account</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.GraphServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourceProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.AccountResourceProperties()); set => this._property = value; }

        /// <summary>Provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.GraphServices.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourcePropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.GraphServices.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Backing field for <see cref="SystemData" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourceSystemData _systemData;

        /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.GraphServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourceSystemData SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.AccountResourceSystemData()); }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.GraphServices.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourceSystemDataInternal)SystemData).CreatedAt; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.GraphServices.PropertyOrigin.Inlined)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourceSystemDataInternal)SystemData).CreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.GraphServices.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourceSystemDataInternal)SystemData).LastModifiedAt; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.GraphServices.PropertyOrigin.Inlined)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourceSystemDataInternal)SystemData).LastModifiedByType; }

        /// <summary>resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.GraphServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IResourceInternal)__resource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IResourceInternal)__resource).Tag = value ?? null /* model class */; }

        /// <summary>Azure resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.GraphServices.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="AccountResource" /> instance.</summary>
        public AccountResource()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Account details
    public partial interface IAccountResource :
        Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IResource
    {
        /// <summary>Customer owned application ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Customer owned application ID",
        SerializedName = @"appId",
        PossibleTypes = new [] { typeof(string) })]
        string AppId { get; set; }
        /// <summary>Billing Plan Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Billing Plan Id",
        SerializedName = @"billingPlanId",
        PossibleTypes = new [] { typeof(string) })]
        string BillingPlanId { get;  }
        /// <summary>Provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning state.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.GraphServices.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled")]
        string ProvisioningState { get;  }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The timestamp of resource creation (UTC).",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataCreatedAt { get;  }
        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The type of identity that created the resource.",
        SerializedName = @"createdByType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.GraphServices.PSArgumentCompleterAttribute("User", "Application", "ManagedIdentity", "Key")]
        string SystemDataCreatedByType { get;  }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The timestamp of resource last modification (UTC)",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataLastModifiedAt { get;  }
        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The type of identity that last modified the resource.",
        SerializedName = @"lastModifiedByType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.GraphServices.PSArgumentCompleterAttribute("User", "Application", "ManagedIdentity", "Key")]
        string SystemDataLastModifiedByType { get;  }

    }
    /// Account details
    internal partial interface IAccountResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IResourceInternal
    {
        /// <summary>Customer owned application ID</summary>
        string AppId { get; set; }
        /// <summary>Billing Plan Id</summary>
        string BillingPlanId { get; set; }
        /// <summary>Property bag from billing account</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourceProperties Property { get; set; }
        /// <summary>Provisioning state.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.GraphServices.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled")]
        string ProvisioningState { get; set; }
        /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GraphServices.Models.IAccountResourceSystemData SystemData { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.GraphServices.PSArgumentCompleterAttribute("User", "Application", "ManagedIdentity", "Key")]
        string SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.GraphServices.PSArgumentCompleterAttribute("User", "Application", "ManagedIdentity", "Key")]
        string SystemDataLastModifiedByType { get; set; }

    }
}