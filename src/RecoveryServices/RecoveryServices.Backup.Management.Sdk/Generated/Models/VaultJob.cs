// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// Vault level Job
    /// </summary>
    [Newtonsoft.Json.JsonObject("VaultJob")]
    public partial class VaultJob : Job
    {
        /// <summary>
        /// Initializes a new instance of the VaultJob class.
        /// </summary>
        public VaultJob()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VaultJob class.
        /// </summary>

        /// <param name="entityFriendlyName">Friendly name of the entity on which the current job is executing.
        /// </param>

        /// <param name="backupManagementType">Backup management type to execute the current job.
        /// Possible values include: &#39;Invalid&#39;, &#39;AzureIaasVM&#39;, &#39;MAB&#39;, &#39;DPM&#39;,
        /// &#39;AzureBackupServer&#39;, &#39;AzureSql&#39;, &#39;AzureStorage&#39;, &#39;AzureWorkload&#39;,
        /// &#39;DefaultBackup&#39;</param>

        /// <param name="operation">The operation name.
        /// </param>

        /// <param name="status">Job status.
        /// </param>

        /// <param name="startTime">The start time.
        /// </param>

        /// <param name="endTime">The end time.
        /// </param>

        /// <param name="activityId">ActivityId of job.
        /// </param>

        /// <param name="duration">Time elapsed during the execution of this job.
        /// </param>

        /// <param name="actionsInfo">Gets or sets the state/actions applicable on this job like cancel/retry.
        /// </param>

        /// <param name="errorDetails">Error details on execution of this job.
        /// </param>

        /// <param name="extendedInfo">Additional information about the job.
        /// </param>
        public VaultJob(string entityFriendlyName = default(string), string backupManagementType = default(string), string operation = default(string), string status = default(string), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), string activityId = default(string), System.TimeSpan? duration = default(System.TimeSpan?), System.Collections.Generic.IList<JobSupportedAction?> actionsInfo = default(System.Collections.Generic.IList<JobSupportedAction?>), System.Collections.Generic.IList<VaultJobErrorInfo> errorDetails = default(System.Collections.Generic.IList<VaultJobErrorInfo>), VaultJobExtendedInfo extendedInfo = default(VaultJobExtendedInfo))

        : base(entityFriendlyName, backupManagementType, operation, status, startTime, endTime, activityId)
        {
            this.Duration = duration;
            this.ActionsInfo = actionsInfo;
            this.ErrorDetails = errorDetails;
            this.ExtendedInfo = extendedInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets time elapsed during the execution of this job.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "duration")]
        public System.TimeSpan? Duration {get; set; }

        /// <summary>
        /// Gets or sets gets or sets the state/actions applicable on this job like
        /// cancel/retry.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "actionsInfo")]
        public System.Collections.Generic.IList<JobSupportedAction?> ActionsInfo {get; set; }

        /// <summary>
        /// Gets or sets error details on execution of this job.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "errorDetails")]
        public System.Collections.Generic.IList<VaultJobErrorInfo> ErrorDetails {get; set; }

        /// <summary>
        /// Gets or sets additional information about the job.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "extendedInfo")]
        public VaultJobExtendedInfo ExtendedInfo {get; set; }
    }
}