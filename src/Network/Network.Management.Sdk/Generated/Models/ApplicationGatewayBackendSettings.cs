// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// Backend address pool settings of an application gateway.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class ApplicationGatewayBackendSettings : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayBackendSettings class.
        /// </summary>
        public ApplicationGatewayBackendSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayBackendSettings class.
        /// </summary>

        /// <param name="id">Resource ID.
        /// </param>

        /// <param name="name">Name of the backend settings that is unique within an Application Gateway.
        /// </param>

        /// <param name="etag">A unique read-only string that changes whenever the resource is updated.
        /// </param>

        /// <param name="type">Type of the resource.
        /// </param>

        /// <param name="provisioningState">The provisioning state of the backend HTTP settings resource.
        /// Possible values include: &#39;Failed&#39;, &#39;Succeeded&#39;, &#39;Canceled&#39;, &#39;Creating&#39;,
        /// &#39;Updating&#39;, &#39;Deleting&#39;</param>

        /// <param name="port">The destination port on the backend.
        /// </param>

        /// <param name="protocol">The protocol used to communicate with the backend.
        /// Possible values include: &#39;Http&#39;, &#39;Https&#39;, &#39;Tcp&#39;, &#39;Tls&#39;</param>

        /// <param name="timeout">Connection timeout in seconds. Application Gateway will fail the request if
        /// response is not received within ConnectionTimeout. Acceptable values are
        /// from 1 second to 86400 seconds.
        /// </param>

        /// <param name="probe">Probe resource of an application gateway.
        /// </param>

        /// <param name="trustedRootCertificates">Array of references to application gateway trusted root certificates.
        /// </param>

        /// <param name="hostName">Server name indication to be sent to the backend servers for Tls protocol.
        /// </param>

        /// <param name="pickHostNameFromBackendAddress">Whether to pick server name indication from the host name of the backend
        /// server for Tls protocol. Default value is false.
        /// </param>
        public ApplicationGatewayBackendSettings(string id = default(string), string name = default(string), string etag = default(string), string type = default(string), string provisioningState = default(string), int? port = default(int?), string protocol = default(string), int? timeout = default(int?), SubResource probe = default(SubResource), System.Collections.Generic.IList<SubResource> trustedRootCertificates = default(System.Collections.Generic.IList<SubResource>), string hostName = default(string), bool? pickHostNameFromBackendAddress = default(bool?))

        : base(id)
        {
            this.Name = name;
            this.Etag = etag;
            this.Type = type;
            this.ProvisioningState = provisioningState;
            this.Port = port;
            this.Protocol = protocol;
            this.Timeout = timeout;
            this.Probe = probe;
            this.TrustedRootCertificates = trustedRootCertificates;
            this.HostName = hostName;
            this.PickHostNameFromBackendAddress = pickHostNameFromBackendAddress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets name of the backend settings that is unique within an
        /// Application Gateway.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource is
        /// updated.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "etag")]
        public string Etag {get; private set; }

        /// <summary>
        /// Gets type of the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type {get; private set; }

        /// <summary>
        /// Gets the provisioning state of the backend HTTP settings resource. Possible values include: &#39;Failed&#39;, &#39;Succeeded&#39;, &#39;Canceled&#39;, &#39;Creating&#39;, &#39;Updating&#39;, &#39;Deleting&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState {get; private set; }

        /// <summary>
        /// Gets or sets the destination port on the backend.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.port")]
        public int? Port {get; set; }

        /// <summary>
        /// Gets or sets the protocol used to communicate with the backend. Possible values include: &#39;Http&#39;, &#39;Https&#39;, &#39;Tcp&#39;, &#39;Tls&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.protocol")]
        public string Protocol {get; set; }

        /// <summary>
        /// Gets or sets connection timeout in seconds. Application Gateway will fail
        /// the request if response is not received within ConnectionTimeout.
        /// Acceptable values are from 1 second to 86400 seconds.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.timeout")]
        public int? Timeout {get; set; }

        /// <summary>
        /// Gets or sets probe resource of an application gateway.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.probe")]
        public SubResource Probe {get; set; }

        /// <summary>
        /// Gets or sets array of references to application gateway trusted root
        /// certificates.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.trustedRootCertificates")]
        public System.Collections.Generic.IList<SubResource> TrustedRootCertificates {get; set; }

        /// <summary>
        /// Gets or sets server name indication to be sent to the backend servers for
        /// Tls protocol.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.hostName")]
        public string HostName {get; set; }

        /// <summary>
        /// Gets or sets whether to pick server name indication from the host name of
        /// the backend server for Tls protocol. Default value is false.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.pickHostNameFromBackendAddress")]
        public bool? PickHostNameFromBackendAddress {get; set; }
    }
}