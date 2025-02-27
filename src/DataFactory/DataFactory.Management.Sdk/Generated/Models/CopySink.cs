// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    /// <summary>
    /// A copy activity sink.
    /// </summary>
    [Newtonsoft.Json.JsonObject("CopySink")]
    public partial class CopySink
    {
        /// <summary>
        /// Initializes a new instance of the CopySink class.
        /// </summary>
        public CopySink()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CopySink class.
        /// </summary>

        /// <param name="additionalProperties">A copy activity sink.
        /// </param>

        /// <param name="writeBatchSize">Write batch size. Type: integer (or Expression with resultType integer),
        /// minimum: 0.
        /// </param>

        /// <param name="writeBatchTimeout">Write batch timeout. Type: string (or Expression with resultType string),
        /// pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </param>

        /// <param name="sinkRetryCount">Sink retry count. Type: integer (or Expression with resultType integer).
        /// </param>

        /// <param name="sinkRetryWait">Sink retry wait. Type: string (or Expression with resultType string),
        /// pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </param>

        /// <param name="maxConcurrentConnections">The maximum concurrent connection count for the sink data store. Type:
        /// integer (or Expression with resultType integer).
        /// </param>

        /// <param name="disableMetricsCollection">If true, disable data store metrics collection. Default is false. Type:
        /// boolean (or Expression with resultType boolean).
        /// </param>
        public CopySink(System.Collections.Generic.IDictionary<string, object> additionalProperties = default(System.Collections.Generic.IDictionary<string, object>), object writeBatchSize = default(object), object writeBatchTimeout = default(object), object sinkRetryCount = default(object), object sinkRetryWait = default(object), object maxConcurrentConnections = default(object), object disableMetricsCollection = default(object))

        {
            this.AdditionalProperties = additionalProperties;
            this.WriteBatchSize = writeBatchSize;
            this.WriteBatchTimeout = writeBatchTimeout;
            this.SinkRetryCount = sinkRetryCount;
            this.SinkRetryWait = sinkRetryWait;
            this.MaxConcurrentConnections = maxConcurrentConnections;
            this.DisableMetricsCollection = disableMetricsCollection;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets a copy activity sink.
        /// </summary>
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {get; set; }

        /// <summary>
        /// Gets or sets write batch size. Type: integer (or Expression with resultType
        /// integer), minimum: 0.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "writeBatchSize")]
        public object WriteBatchSize {get; set; }

        /// <summary>
        /// Gets or sets write batch timeout. Type: string (or Expression with
        /// resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "writeBatchTimeout")]
        public object WriteBatchTimeout {get; set; }

        /// <summary>
        /// Gets or sets sink retry count. Type: integer (or Expression with resultType
        /// integer).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sinkRetryCount")]
        public object SinkRetryCount {get; set; }

        /// <summary>
        /// Gets or sets sink retry wait. Type: string (or Expression with resultType
        /// string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sinkRetryWait")]
        public object SinkRetryWait {get; set; }

        /// <summary>
        /// Gets or sets the maximum concurrent connection count for the sink data
        /// store. Type: integer (or Expression with resultType integer).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "maxConcurrentConnections")]
        public object MaxConcurrentConnections {get; set; }

        /// <summary>
        /// Gets or sets if true, disable data store metrics collection. Default is
        /// false. Type: boolean (or Expression with resultType boolean).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "disableMetricsCollection")]
        public object DisableMetricsCollection {get; set; }
    }
}