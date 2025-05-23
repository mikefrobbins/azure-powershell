// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System.Linq;

    /// <summary>
    /// Recovery plan A2A failover input.
    /// </summary>
    [Newtonsoft.Json.JsonObject("A2A")]
    public partial class RecoveryPlanA2AFailoverInput : RecoveryPlanProviderSpecificFailoverInput
    {
        /// <summary>
        /// Initializes a new instance of the RecoveryPlanA2AFailoverInput class.
        /// </summary>
        public RecoveryPlanA2AFailoverInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RecoveryPlanA2AFailoverInput class.
        /// </summary>

        /// <param name="recoveryPointType">The recovery point type.
        /// Possible values include: &#39;Latest&#39;, &#39;LatestApplicationConsistent&#39;,
        /// &#39;LatestCrashConsistent&#39;, &#39;LatestProcessed&#39;</param>

        /// <param name="cloudServiceCreationOption">A value indicating whether to use recovery cloud service for TFO or not.
        /// </param>

        /// <param name="multiVMSyncPointOption">A value indicating whether multi VM sync enabled VMs should use multi VM
        /// sync points for failover.
        /// Possible values include: &#39;UseMultiVmSyncRecoveryPoint&#39;,
        /// &#39;UsePerVmRecoveryPoint&#39;</param>
        public RecoveryPlanA2AFailoverInput(string recoveryPointType, string cloudServiceCreationOption = default(string), string multiVMSyncPointOption = default(string))

        {
            this.RecoveryPointType = recoveryPointType;
            this.CloudServiceCreationOption = cloudServiceCreationOption;
            this.MultiVMSyncPointOption = multiVMSyncPointOption;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the recovery point type. Possible values include: &#39;Latest&#39;, &#39;LatestApplicationConsistent&#39;, &#39;LatestCrashConsistent&#39;, &#39;LatestProcessed&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryPointType")]
        public string RecoveryPointType {get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use recovery cloud service for
        /// TFO or not.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "cloudServiceCreationOption")]
        public string CloudServiceCreationOption {get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether multi VM sync enabled VMs should
        /// use multi VM sync points for failover. Possible values include: &#39;UseMultiVmSyncRecoveryPoint&#39;, &#39;UsePerVmRecoveryPoint&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "multiVmSyncPointOption")]
        public string MultiVMSyncPointOption {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.RecoveryPointType == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "RecoveryPointType");
            }



        }
    }
}