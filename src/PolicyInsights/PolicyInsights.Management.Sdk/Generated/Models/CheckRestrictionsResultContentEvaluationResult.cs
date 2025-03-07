// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.PolicyInsights.Models
{
    using System.Linq;

    /// <summary>
    /// Evaluation results for the provided partial resource content.
    /// </summary>
    public partial class CheckRestrictionsResultContentEvaluationResult
    {
        /// <summary>
        /// Initializes a new instance of the CheckRestrictionsResultContentEvaluationResult class.
        /// </summary>
        public CheckRestrictionsResultContentEvaluationResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CheckRestrictionsResultContentEvaluationResult class.
        /// </summary>

        /// <param name="policyEvaluations">Policy evaluation results against the given resource content. This will
        /// indicate if the partial content that was provided will be denied as-is.
        /// </param>
        public CheckRestrictionsResultContentEvaluationResult(System.Collections.Generic.IList<PolicyEvaluationResult> policyEvaluations = default(System.Collections.Generic.IList<PolicyEvaluationResult>))

        {
            this.PolicyEvaluations = policyEvaluations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets policy evaluation results against the given resource content.
        /// This will indicate if the partial content that was provided will be denied
        /// as-is.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "policyEvaluations")]
        public System.Collections.Generic.IList<PolicyEvaluationResult> PolicyEvaluations {get; set; }
    }
}