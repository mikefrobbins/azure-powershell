// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// The properties of a packet capture session.
    /// </summary>
    public partial class PacketCaptureResultProperties : PacketCaptureParameters
    {
        /// <summary>
        /// Initializes a new instance of the PacketCaptureResultProperties class.
        /// </summary>
        public PacketCaptureResultProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PacketCaptureResultProperties class.
        /// </summary>

        /// <param name="target">The ID of the targeted resource, only AzureVM and AzureVMSS as target type
        /// are currently supported.
        /// </param>

        /// <param name="scope">A list of AzureVMSS instances which can be included or excluded to run
        /// packet capture. If both included and excluded are empty, then the packet
        /// capture will run on all instances of AzureVMSS.
        /// </param>

        /// <param name="targetType">Target type of the resource provided.
        /// Possible values include: &#39;AzureVM&#39;, &#39;AzureVMSS&#39;</param>

        /// <param name="bytesToCapturePerPacket">Number of bytes captured per packet, the remaining bytes are truncated.
        /// </param>

        /// <param name="totalBytesPerSession">Maximum size of the capture output.
        /// </param>

        /// <param name="timeLimitInSeconds">Maximum duration of the capture session in seconds.
        /// </param>

        /// <param name="storageLocation">The storage location for a packet capture session.
        /// </param>

        /// <param name="filters">A list of packet capture filters.
        /// </param>

        /// <param name="continuousCapture">This continuous capture is a nullable boolean, which can hold &#39;null&#39;,
        /// &#39;true&#39; or &#39;false&#39; value. If we do not pass this parameter, it would be
        /// consider as &#39;null&#39;, default value is &#39;null&#39;.
        /// </param>

        /// <param name="captureSettings">The capture setting holds the &#39;FileCount&#39;, &#39;FileSizeInBytes&#39;,
        /// &#39;SessionTimeLimitInSeconds&#39; values.
        /// </param>

        /// <param name="provisioningState">The provisioning state of the packet capture session.
        /// Possible values include: &#39;Failed&#39;, &#39;Succeeded&#39;, &#39;Canceled&#39;, &#39;Creating&#39;,
        /// &#39;Updating&#39;, &#39;Deleting&#39;</param>
        public PacketCaptureResultProperties(string target, PacketCaptureStorageLocation storageLocation, PacketCaptureMachineScope scope = default(PacketCaptureMachineScope), PacketCaptureTargetType? targetType = default(PacketCaptureTargetType?), long? bytesToCapturePerPacket = default(long?), long? totalBytesPerSession = default(long?), int? timeLimitInSeconds = default(int?), System.Collections.Generic.IList<PacketCaptureFilter> filters = default(System.Collections.Generic.IList<PacketCaptureFilter>), bool? continuousCapture = default(bool?), PacketCaptureSettings captureSettings = default(PacketCaptureSettings), string provisioningState = default(string))

        : base(target, storageLocation, scope, targetType, bytesToCapturePerPacket, totalBytesPerSession, timeLimitInSeconds, filters, continuousCapture, captureSettings)
        {
            this.ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets the provisioning state of the packet capture session. Possible values include: &#39;Failed&#39;, &#39;Succeeded&#39;, &#39;Canceled&#39;, &#39;Creating&#39;, &#39;Updating&#39;, &#39;Deleting&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState {get; private set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();

        }
    }
}