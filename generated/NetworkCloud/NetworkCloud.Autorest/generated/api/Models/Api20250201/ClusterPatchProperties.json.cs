// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Extensions;

    /// <summary>ClusterPatchProperties represents the properties of the cluster for patching.</summary>
    public partial class ClusterPatchProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject into a new instance of <see cref="ClusterPatchProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ClusterPatchProperties(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_aggregatorOrSingleRackDefinition = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject>("aggregatorOrSingleRackDefinition"), out var __jsonAggregatorOrSingleRackDefinition) ? Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.RackDefinition.FromJson(__jsonAggregatorOrSingleRackDefinition) : AggregatorOrSingleRackDefinition;}
            {_analyticsOutputSetting = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject>("analyticsOutputSettings"), out var __jsonAnalyticsOutputSettings) ? Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.AnalyticsOutputSettings.FromJson(__jsonAnalyticsOutputSettings) : AnalyticsOutputSetting;}
            {_clusterServicePrincipal = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject>("clusterServicePrincipal"), out var __jsonClusterServicePrincipal) ? Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ServicePrincipalInformation.FromJson(__jsonClusterServicePrincipal) : ClusterServicePrincipal;}
            {_commandOutputSetting = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject>("commandOutputSettings"), out var __jsonCommandOutputSettings) ? Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.CommandOutputSettings.FromJson(__jsonCommandOutputSettings) : CommandOutputSetting;}
            {_computeDeploymentThreshold = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject>("computeDeploymentThreshold"), out var __jsonComputeDeploymentThreshold) ? Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ValidationThreshold.FromJson(__jsonComputeDeploymentThreshold) : ComputeDeploymentThreshold;}
            {_runtimeProtectionConfiguration = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject>("runtimeProtectionConfiguration"), out var __jsonRuntimeProtectionConfiguration) ? Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.RuntimeProtectionConfiguration.FromJson(__jsonRuntimeProtectionConfiguration) : RuntimeProtectionConfiguration;}
            {_secretArchive = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject>("secretArchive"), out var __jsonSecretArchive) ? Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ClusterSecretArchive.FromJson(__jsonSecretArchive) : SecretArchive;}
            {_secretArchiveSetting = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject>("secretArchiveSettings"), out var __jsonSecretArchiveSettings) ? Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.SecretArchiveSettings.FromJson(__jsonSecretArchiveSettings) : SecretArchiveSetting;}
            {_updateStrategy = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject>("updateStrategy"), out var __jsonUpdateStrategy) ? Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ClusterUpdateStrategy.FromJson(__jsonUpdateStrategy) : UpdateStrategy;}
            {_vulnerabilityScanningSetting = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject>("vulnerabilityScanningSettings"), out var __jsonVulnerabilityScanningSettings) ? Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.VulnerabilityScanningSettingsPatch.FromJson(__jsonVulnerabilityScanningSettings) : VulnerabilityScanningSetting;}
            {_clusterLocation = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonString>("clusterLocation"), out var __jsonClusterLocation) ? (string)__jsonClusterLocation : (string)ClusterLocation;}
            {_computeRackDefinition = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonArray>("computeRackDefinitions"), out var __jsonComputeRackDefinitions) ? If( __jsonComputeRackDefinitions as Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IRackDefinition[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IRackDefinition) (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.RackDefinition.FromJson(__u) )) ))() : null : ComputeRackDefinition;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterPatchProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterPatchProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterPatchProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject json ? new ClusterPatchProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="ClusterPatchProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ClusterPatchProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._aggregatorOrSingleRackDefinition ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode) this._aggregatorOrSingleRackDefinition.ToJson(null,serializationMode) : null, "aggregatorOrSingleRackDefinition" ,container.Add );
            AddIf( null != this._analyticsOutputSetting ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode) this._analyticsOutputSetting.ToJson(null,serializationMode) : null, "analyticsOutputSettings" ,container.Add );
            AddIf( null != this._clusterServicePrincipal ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode) this._clusterServicePrincipal.ToJson(null,serializationMode) : null, "clusterServicePrincipal" ,container.Add );
            AddIf( null != this._commandOutputSetting ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode) this._commandOutputSetting.ToJson(null,serializationMode) : null, "commandOutputSettings" ,container.Add );
            AddIf( null != this._computeDeploymentThreshold ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode) this._computeDeploymentThreshold.ToJson(null,serializationMode) : null, "computeDeploymentThreshold" ,container.Add );
            AddIf( null != this._runtimeProtectionConfiguration ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode) this._runtimeProtectionConfiguration.ToJson(null,serializationMode) : null, "runtimeProtectionConfiguration" ,container.Add );
            AddIf( null != this._secretArchive ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode) this._secretArchive.ToJson(null,serializationMode) : null, "secretArchive" ,container.Add );
            AddIf( null != this._secretArchiveSetting ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode) this._secretArchiveSetting.ToJson(null,serializationMode) : null, "secretArchiveSettings" ,container.Add );
            AddIf( null != this._updateStrategy ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode) this._updateStrategy.ToJson(null,serializationMode) : null, "updateStrategy" ,container.Add );
            AddIf( null != this._vulnerabilityScanningSetting ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode) this._vulnerabilityScanningSetting.ToJson(null,serializationMode) : null, "vulnerabilityScanningSettings" ,container.Add );
            AddIf( null != (((object)this._clusterLocation)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonString(this._clusterLocation.ToString()) : null, "clusterLocation" ,container.Add );
            if (null != this._computeRackDefinition)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.XNodeArray();
                foreach( var __x in this._computeRackDefinition )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("computeRackDefinitions",__w);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}