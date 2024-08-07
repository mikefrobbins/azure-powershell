// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Runtime.Extensions;

    /// <summary>
    /// Properties of RedisEnterprise databases, as opposed to general resource properties like location, tags
    /// </summary>
    public partial class DatabaseProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.IDatabaseProperties,
        Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.IDatabasePropertiesInternal
    {

        /// <summary>Backing field for <see cref="ClientProtocol" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.Protocol? _clientProtocol;

        /// <summary>
        /// Specifies whether redis clients can connect using TLS-encrypted or plaintext redis protocols. Default is TLS-encrypted.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Origin(Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.Protocol? ClientProtocol { get => this._clientProtocol; set => this._clientProtocol = value; }

        /// <summary>Backing field for <see cref="ClusteringPolicy" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ClusteringPolicy? _clusteringPolicy;

        /// <summary>Clustering policy - default is OSSCluster. Specified at create time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Origin(Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ClusteringPolicy? ClusteringPolicy { get => this._clusteringPolicy; set => this._clusteringPolicy = value; }

        /// <summary>Backing field for <see cref="EvictionPolicy" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.EvictionPolicy? _evictionPolicy;

        /// <summary>Redis eviction policy - default is VolatileLRU</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Origin(Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.EvictionPolicy? EvictionPolicy { get => this._evictionPolicy; set => this._evictionPolicy = value; }

        /// <summary>Backing field for <see cref="GeoReplication" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.IDatabasePropertiesGeoReplication _geoReplication;

        /// <summary>Optional set of properties to configure geo replication for this database.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Origin(Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.IDatabasePropertiesGeoReplication GeoReplication { get => (this._geoReplication = this._geoReplication ?? new Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.DatabasePropertiesGeoReplication()); set => this._geoReplication = value; }

        /// <summary>Name for the group of linked database resources</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Origin(Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.PropertyOrigin.Inlined)]
        public string GeoReplicationGroupNickname { get => ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.IDatabasePropertiesGeoReplicationInternal)GeoReplication).GroupNickname; set => ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.IDatabasePropertiesGeoReplicationInternal)GeoReplication).GroupNickname = value ?? null; }

        /// <summary>List of database resources to link with this database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Origin(Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.ILinkedDatabase[] GeoReplicationLinkedDatabase { get => ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.IDatabasePropertiesGeoReplicationInternal)GeoReplication).LinkedDatabase; set => ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.IDatabasePropertiesGeoReplicationInternal)GeoReplication).LinkedDatabase = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for GeoReplication</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.IDatabasePropertiesGeoReplication Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.IDatabasePropertiesInternal.GeoReplication { get => (this._geoReplication = this._geoReplication ?? new Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.DatabasePropertiesGeoReplication()); set { {_geoReplication = value;} } }

        /// <summary>Internal Acessors for Persistence</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.IPersistence Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.IDatabasePropertiesInternal.Persistence { get => (this._persistence = this._persistence ?? new Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.Persistence()); set { {_persistence = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.IDatabasePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for ResourceState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ResourceState? Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.IDatabasePropertiesInternal.ResourceState { get => this._resourceState; set { {_resourceState = value;} } }

        /// <summary>Backing field for <see cref="Module" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.IModule[] _module;

        /// <summary>
        /// Optional set of redis modules to enable in this database - modules can only be added at creation time.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Origin(Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.IModule[] Module { get => this._module; set => this._module = value; }

        /// <summary>Backing field for <see cref="Persistence" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.IPersistence _persistence;

        /// <summary>Persistence settings</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Origin(Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.IPersistence Persistence { get => (this._persistence = this._persistence ?? new Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.Persistence()); set => this._persistence = value; }

        /// <summary>Sets whether AOF is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Origin(Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.PropertyOrigin.Inlined)]
        public bool? PersistenceAofEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.IPersistenceInternal)Persistence).AofEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.IPersistenceInternal)Persistence).AofEnabled = value ?? default(bool); }

        /// <summary>Sets the frequency at which data is written to disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Origin(Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.AofFrequency? PersistenceAofFrequency { get => ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.IPersistenceInternal)Persistence).AofFrequency; set => ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.IPersistenceInternal)Persistence).AofFrequency = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.AofFrequency)""); }

        /// <summary>Sets whether RDB is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Origin(Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.PropertyOrigin.Inlined)]
        public bool? PersistenceRdbEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.IPersistenceInternal)Persistence).RdbEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.IPersistenceInternal)Persistence).RdbEnabled = value ?? default(bool); }

        /// <summary>Sets the frequency at which a snapshot of the database is created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Origin(Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.RdbFrequency? PersistenceRdbFrequency { get => ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.IPersistenceInternal)Persistence).RdbFrequency; set => ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.IPersistenceInternal)Persistence).RdbFrequency = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.RdbFrequency)""); }

        /// <summary>Backing field for <see cref="Port" /> property.</summary>
        private int? _port;

        /// <summary>
        /// TCP port of the database endpoint. Specified at create time. Defaults to an available port.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Origin(Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.PropertyOrigin.Owned)]
        public int? Port { get => this._port; set => this._port = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ProvisioningState? _provisioningState;

        /// <summary>Current provisioning status of the database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Origin(Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="ResourceState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ResourceState? _resourceState;

        /// <summary>Current resource status of the database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Origin(Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ResourceState? ResourceState { get => this._resourceState; }

        /// <summary>Creates an new <see cref="DatabaseProperties" /> instance.</summary>
        public DatabaseProperties()
        {

        }
    }
    /// Properties of RedisEnterprise databases, as opposed to general resource properties like location, tags
    public partial interface IDatabaseProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Specifies whether redis clients can connect using TLS-encrypted or plaintext redis protocols. Default is TLS-encrypted.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies whether redis clients can connect using TLS-encrypted or plaintext redis protocols. Default is TLS-encrypted.",
        SerializedName = @"clientProtocol",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.Protocol) })]
        Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.Protocol? ClientProtocol { get; set; }
        /// <summary>Clustering policy - default is OSSCluster. Specified at create time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Clustering policy - default is OSSCluster. Specified at create time.",
        SerializedName = @"clusteringPolicy",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ClusteringPolicy) })]
        Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ClusteringPolicy? ClusteringPolicy { get; set; }
        /// <summary>Redis eviction policy - default is VolatileLRU</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Redis eviction policy - default is VolatileLRU",
        SerializedName = @"evictionPolicy",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.EvictionPolicy) })]
        Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.EvictionPolicy? EvictionPolicy { get; set; }
        /// <summary>Name for the group of linked database resources</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name for the group of linked database resources",
        SerializedName = @"groupNickname",
        PossibleTypes = new [] { typeof(string) })]
        string GeoReplicationGroupNickname { get; set; }
        /// <summary>List of database resources to link with this database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of database resources to link with this database",
        SerializedName = @"linkedDatabases",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.ILinkedDatabase) })]
        Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.ILinkedDatabase[] GeoReplicationLinkedDatabase { get; set; }
        /// <summary>
        /// Optional set of redis modules to enable in this database - modules can only be added at creation time.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Optional set of redis modules to enable in this database - modules can only be added at creation time.",
        SerializedName = @"modules",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.IModule) })]
        Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.IModule[] Module { get; set; }
        /// <summary>Sets whether AOF is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sets whether AOF is enabled.",
        SerializedName = @"aofEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PersistenceAofEnabled { get; set; }
        /// <summary>Sets the frequency at which data is written to disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sets the frequency at which data is written to disk.",
        SerializedName = @"aofFrequency",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.AofFrequency) })]
        Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.AofFrequency? PersistenceAofFrequency { get; set; }
        /// <summary>Sets whether RDB is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sets whether RDB is enabled.",
        SerializedName = @"rdbEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PersistenceRdbEnabled { get; set; }
        /// <summary>Sets the frequency at which a snapshot of the database is created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sets the frequency at which a snapshot of the database is created.",
        SerializedName = @"rdbFrequency",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.RdbFrequency) })]
        Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.RdbFrequency? PersistenceRdbFrequency { get; set; }
        /// <summary>
        /// TCP port of the database endpoint. Specified at create time. Defaults to an available port.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"TCP port of the database endpoint. Specified at create time. Defaults to an available port.",
        SerializedName = @"port",
        PossibleTypes = new [] { typeof(int) })]
        int? Port { get; set; }
        /// <summary>Current provisioning status of the database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Current provisioning status of the database",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>Current resource status of the database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Current resource status of the database",
        SerializedName = @"resourceState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ResourceState) })]
        Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ResourceState? ResourceState { get;  }

    }
    /// Properties of RedisEnterprise databases, as opposed to general resource properties like location, tags
    internal partial interface IDatabasePropertiesInternal

    {
        /// <summary>
        /// Specifies whether redis clients can connect using TLS-encrypted or plaintext redis protocols. Default is TLS-encrypted.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.Protocol? ClientProtocol { get; set; }
        /// <summary>Clustering policy - default is OSSCluster. Specified at create time.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ClusteringPolicy? ClusteringPolicy { get; set; }
        /// <summary>Redis eviction policy - default is VolatileLRU</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.EvictionPolicy? EvictionPolicy { get; set; }
        /// <summary>Optional set of properties to configure geo replication for this database.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.IDatabasePropertiesGeoReplication GeoReplication { get; set; }
        /// <summary>Name for the group of linked database resources</summary>
        string GeoReplicationGroupNickname { get; set; }
        /// <summary>List of database resources to link with this database</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.ILinkedDatabase[] GeoReplicationLinkedDatabase { get; set; }
        /// <summary>
        /// Optional set of redis modules to enable in this database - modules can only be added at creation time.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.IModule[] Module { get; set; }
        /// <summary>Persistence settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Models.Api20230301Preview.IPersistence Persistence { get; set; }
        /// <summary>Sets whether AOF is enabled.</summary>
        bool? PersistenceAofEnabled { get; set; }
        /// <summary>Sets the frequency at which data is written to disk.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.AofFrequency? PersistenceAofFrequency { get; set; }
        /// <summary>Sets whether RDB is enabled.</summary>
        bool? PersistenceRdbEnabled { get; set; }
        /// <summary>Sets the frequency at which a snapshot of the database is created.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.RdbFrequency? PersistenceRdbFrequency { get; set; }
        /// <summary>
        /// TCP port of the database endpoint. Specified at create time. Defaults to an available port.
        /// </summary>
        int? Port { get; set; }
        /// <summary>Current provisioning status of the database</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>Current resource status of the database</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ResourceState? ResourceState { get; set; }

    }
}