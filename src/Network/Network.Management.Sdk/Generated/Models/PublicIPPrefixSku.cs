// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// SKU of a public IP prefix.
    /// </summary>
    public partial class PublicIPPrefixSku
    {
        /// <summary>
        /// Initializes a new instance of the PublicIPPrefixSku class.
        /// </summary>
        public PublicIPPrefixSku()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PublicIPPrefixSku class.
        /// </summary>

        /// <param name="name">Name of a public IP prefix SKU.
        /// Possible values include: &#39;Standard&#39;, &#39;StandardV2&#39;</param>

        /// <param name="tier">Tier of a public IP prefix SKU.
        /// Possible values include: &#39;Regional&#39;, &#39;Global&#39;</param>
        public PublicIPPrefixSku(string name = default(string), string tier = default(string))

        {
            this.Name = name;
            this.Tier = tier;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets name of a public IP prefix SKU. Possible values include: &#39;Standard&#39;, &#39;StandardV2&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; set; }

        /// <summary>
        /// Gets or sets tier of a public IP prefix SKU. Possible values include: &#39;Regional&#39;, &#39;Global&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tier")]
        public string Tier {get; set; }
    }
}