// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.StorageSync.Models
{
    using System.Linq;

    /// <summary>
    /// Operation status object
    /// </summary>
    public partial class LocationOperationStatus
    {
        /// <summary>
        /// Initializes a new instance of the LocationOperationStatus class.
        /// </summary>
        public LocationOperationStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LocationOperationStatus class.
        /// </summary>

        /// <param name="id">Operation resource Id
        /// </param>

        /// <param name="name">Operation Id
        /// </param>

        /// <param name="status">Operation status
        /// </param>

        /// <param name="startTime">Start time of the operation
        /// </param>

        /// <param name="endTime">End time of the operation
        /// </param>

        /// <param name="error">Error details.
        /// </param>

        /// <param name="percentComplete">Percent complete.
        /// </param>
        public LocationOperationStatus(string id = default(string), string name = default(string), string status = default(string), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), StorageSyncApiError error = default(StorageSyncApiError), int? percentComplete = default(int?))

        {
            this.Id = id;
            this.Name = name;
            this.Status = status;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Error = error;
            this.PercentComplete = percentComplete;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets operation resource Id
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id {get; private set; }

        /// <summary>
        /// Gets operation Id
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; private set; }

        /// <summary>
        /// Gets operation status
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        public string Status {get; private set; }

        /// <summary>
        /// Gets start time of the operation
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime {get; private set; }

        /// <summary>
        /// Gets end time of the operation
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime {get; private set; }

        /// <summary>
        /// Gets error details.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "error")]
        public StorageSyncApiError Error {get; private set; }

        /// <summary>
        /// Gets percent complete.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "percentComplete")]
        public int? PercentComplete {get; private set; }
    }
}