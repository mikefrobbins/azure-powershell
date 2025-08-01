// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Runtime.Extensions;

    /// <summary>Properties that need to be specified to create a new pipeline group instance.</summary>
    public partial class PipelineGroupProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IPipelineGroupProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IPipelineGroupPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Exporter" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IExporter> _exporter;

        /// <summary>The exporters specified for a pipeline group instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IExporter> Exporter { get => this._exporter; set => this._exporter = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IPipelineGroupPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for Service</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IService Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IPipelineGroupPropertiesInternal.Service { get => (this._service = this._service ?? new Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.Service()); set { {_service = value;} } }

        /// <summary>Internal Acessors for ServicePersistence</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IPersistenceConfigurations Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IPipelineGroupPropertiesInternal.ServicePersistence { get => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IServiceInternal)Service).Persistence; set => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IServiceInternal)Service).Persistence = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="NetworkingConfiguration" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.INetworkingConfiguration> _networkingConfiguration;

        /// <summary>Networking configurations for the pipeline group instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.INetworkingConfiguration> NetworkingConfiguration { get => this._networkingConfiguration; set => this._networkingConfiguration = value; }

        /// <summary>The name of the mounted persistent volume.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.PropertyOrigin.Inlined)]
        public string PersistencePersistentVolumeName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IServiceInternal)Service).PersistencePersistentVolumeName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IServiceInternal)Service).PersistencePersistentVolumeName = value ?? null; }

        /// <summary>Backing field for <see cref="Processor" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IProcessor> _processor;

        /// <summary>The processors specified for a pipeline group instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IProcessor> Processor { get => this._processor; set => this._processor = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>
        /// The provisioning state of a pipeline group instance. Set to Succeeded if everything is healthy.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="Receiver" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IReceiver> _receiver;

        /// <summary>The receivers specified for a pipeline group instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IReceiver> Receiver { get => this._receiver; set => this._receiver = value; }

        /// <summary>Backing field for <see cref="Replica" /> property.</summary>
        private int? _replica;

        /// <summary>Defines the amount of replicas of the pipeline group instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.PropertyOrigin.Owned)]
        public int? Replica { get => this._replica; set => this._replica = value; }

        /// <summary>Backing field for <see cref="Service" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IService _service;

        /// <summary>The service section for a given pipeline group instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IService Service { get => (this._service = this._service ?? new Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.Service()); set => this._service = value; }

        /// <summary>Pipelines belonging to a given pipeline group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IPipeline> ServicePipeline { get => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IServiceInternal)Service).Pipeline; set => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IServiceInternal)Service).Pipeline = value ; }

        /// <summary>Creates an new <see cref="PipelineGroupProperties" /> instance.</summary>
        public PipelineGroupProperties()
        {

        }
    }
    /// Properties that need to be specified to create a new pipeline group instance.
    public partial interface IPipelineGroupProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Runtime.IJsonSerializable
    {
        /// <summary>The exporters specified for a pipeline group instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The exporters specified for a pipeline group instance.",
        SerializedName = @"exporters",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IExporter) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IExporter> Exporter { get; set; }
        /// <summary>Networking configurations for the pipeline group instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Networking configurations for the pipeline group instance.",
        SerializedName = @"networkingConfigurations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.INetworkingConfiguration) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.INetworkingConfiguration> NetworkingConfiguration { get; set; }
        /// <summary>The name of the mounted persistent volume.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the mounted persistent volume.",
        SerializedName = @"persistentVolumeName",
        PossibleTypes = new [] { typeof(string) })]
        string PersistencePersistentVolumeName { get; set; }
        /// <summary>The processors specified for a pipeline group instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The processors specified for a pipeline group instance.",
        SerializedName = @"processors",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IProcessor) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IProcessor> Processor { get; set; }
        /// <summary>
        /// The provisioning state of a pipeline group instance. Set to Succeeded if everything is healthy.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The provisioning state of a pipeline group instance. Set to Succeeded if everything is healthy.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Creating", "Deleting")]
        string ProvisioningState { get;  }
        /// <summary>The receivers specified for a pipeline group instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The receivers specified for a pipeline group instance.",
        SerializedName = @"receivers",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IReceiver) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IReceiver> Receiver { get; set; }
        /// <summary>Defines the amount of replicas of the pipeline group instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Defines the amount of replicas of the pipeline group instance.",
        SerializedName = @"replicas",
        PossibleTypes = new [] { typeof(int) })]
        int? Replica { get; set; }
        /// <summary>Pipelines belonging to a given pipeline group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Pipelines belonging to a given pipeline group.",
        SerializedName = @"pipelines",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IPipeline) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IPipeline> ServicePipeline { get; set; }

    }
    /// Properties that need to be specified to create a new pipeline group instance.
    internal partial interface IPipelineGroupPropertiesInternal

    {
        /// <summary>The exporters specified for a pipeline group instance.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IExporter> Exporter { get; set; }
        /// <summary>Networking configurations for the pipeline group instance.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.INetworkingConfiguration> NetworkingConfiguration { get; set; }
        /// <summary>The name of the mounted persistent volume.</summary>
        string PersistencePersistentVolumeName { get; set; }
        /// <summary>The processors specified for a pipeline group instance.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IProcessor> Processor { get; set; }
        /// <summary>
        /// The provisioning state of a pipeline group instance. Set to Succeeded if everything is healthy.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Creating", "Deleting")]
        string ProvisioningState { get; set; }
        /// <summary>The receivers specified for a pipeline group instance.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IReceiver> Receiver { get; set; }
        /// <summary>Defines the amount of replicas of the pipeline group instance.</summary>
        int? Replica { get; set; }
        /// <summary>The service section for a given pipeline group instance.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IService Service { get; set; }
        /// <summary>Persistence options to all pipelines in the instance.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IPersistenceConfigurations ServicePersistence { get; set; }
        /// <summary>Pipelines belonging to a given pipeline group.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IPipeline> ServicePipeline { get; set; }

    }
}