// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using System.Linq;

    /// <summary>
    /// Parameters to indicate the information about the restore.
    /// </summary>
    public partial class ResourceRestoreParameters : RestoreParametersBase
    {
        /// <summary>
        /// Initializes a new instance of the ResourceRestoreParameters class.
        /// </summary>
        public ResourceRestoreParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceRestoreParameters class.
        /// </summary>

        /// <param name="restoreSource">The id of the restorable database account from which the restore has to be
        /// initiated. For example:
        /// /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{restorableDatabaseAccountName}
        /// </param>

        /// <param name="restoreTimestampInUtc">Time to which the account has to be restored (ISO-8601 format).
        /// </param>

        /// <param name="restoreWithTtlDisabled">Specifies whether the restored account will have Time-To-Live disabled upon
        /// the successful restore.
        /// </param>
        public ResourceRestoreParameters(string restoreSource = default(string), System.DateTime? restoreTimestampInUtc = default(System.DateTime?), bool? restoreWithTtlDisabled = default(bool?))

        : base(restoreSource, restoreTimestampInUtc, restoreWithTtlDisabled)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}