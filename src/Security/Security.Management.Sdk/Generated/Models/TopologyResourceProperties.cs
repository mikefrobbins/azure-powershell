// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Security.Models
{
    using System.Linq;

    public partial class TopologyResourceProperties
    {
        /// <summary>
        /// Initializes a new instance of the TopologyResourceProperties class.
        /// </summary>
        public TopologyResourceProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TopologyResourceProperties class.
        /// </summary>

        /// <param name="calculatedDateTime">The UTC time on which the topology was calculated
        /// </param>

        /// <param name="topologyResources">Azure resources which are part of this topology resource
        /// </param>
        public TopologyResourceProperties(System.DateTime? calculatedDateTime = default(System.DateTime?), System.Collections.Generic.IList<TopologySingleResource> topologyResources = default(System.Collections.Generic.IList<TopologySingleResource>))

        {
            this.CalculatedDateTime = calculatedDateTime;
            this.TopologyResources = topologyResources;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets the UTC time on which the topology was calculated
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "calculatedDateTime")]
        public System.DateTime? CalculatedDateTime {get; private set; }

        /// <summary>
        /// Gets azure resources which are part of this topology resource
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "topologyResources")]
        public System.Collections.Generic.IList<TopologySingleResource> TopologyResources {get; private set; }
    }
}