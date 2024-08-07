// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Extensions;

    /// <summary>MySQL migration request.</summary>
    public partial class MigrateMySqlRequest :
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMigrateMySqlRequest,
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMigrateMySqlRequestInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResource __proxyOnlyResource = new Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.ProxyOnlyResource();

        /// <summary>Connection string to the remote MySQL database.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inlined)]
        public string ConnectionString { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMigrateMySqlRequestPropertiesInternal)Property).ConnectionString; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMigrateMySqlRequestPropertiesInternal)Property).ConnectionString = value ?? null; }

        /// <summary>Resource Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Id; }

        /// <summary>Kind of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inherited)]
        public string Kind { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Kind; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Kind = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Type = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMigrateMySqlRequestProperties Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMigrateMySqlRequestInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.MigrateMySqlRequestProperties()); set { {_property = value;} } }

        /// <summary>The type of migration operation to be done</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.MySqlMigrationType? MigrationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMigrateMySqlRequestPropertiesInternal)Property).MigrationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMigrateMySqlRequestPropertiesInternal)Property).MigrationType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.MySqlMigrationType)""); }

        /// <summary>Resource Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMigrateMySqlRequestProperties _property;

        /// <summary>MigrateMySqlRequest resource specific properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMigrateMySqlRequestProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.MigrateMySqlRequestProperties()); set => this._property = value; }

        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Type; }

        /// <summary>Creates an new <see cref="MigrateMySqlRequest" /> instance.</summary>
        public MigrateMySqlRequest()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyOnlyResource), __proxyOnlyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyOnlyResource), __proxyOnlyResource);
        }
    }
    /// MySQL migration request.
    public partial interface IMigrateMySqlRequest :
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResource
    {
        /// <summary>Connection string to the remote MySQL database.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Connection string to the remote MySQL database.",
        SerializedName = @"connectionString",
        PossibleTypes = new [] { typeof(string) })]
        string ConnectionString { get; set; }
        /// <summary>The type of migration operation to be done</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of migration operation to be done",
        SerializedName = @"migrationType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.MySqlMigrationType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.MySqlMigrationType? MigrationType { get; set; }

    }
    /// MySQL migration request.
    internal partial interface IMigrateMySqlRequestInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal
    {
        /// <summary>Connection string to the remote MySQL database.</summary>
        string ConnectionString { get; set; }
        /// <summary>The type of migration operation to be done</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.MySqlMigrationType? MigrationType { get; set; }
        /// <summary>MigrateMySqlRequest resource specific properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMigrateMySqlRequestProperties Property { get; set; }

    }
}