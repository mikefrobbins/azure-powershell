// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Ssh.Helpers.Network
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for PublicIPAddressesOperations
    /// </summary>
    public static partial class PublicIPAddressesOperationsExtensions
    {
        /// <summary>
        /// Gets the specified public IP address in a specified resource group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='publicIpAddressName'>
        /// The name of the public IP address.
        /// </param>
        /// <param name='expand'>
        /// Expands referenced resources.
        /// </param>
        public static PublicIPAddress Get(this IPublicIPAddressesOperations operations, string resourceGroupName, string publicIpAddressName, string expand = default(string))
        {
                return ((IPublicIPAddressesOperations)operations).GetAsync(resourceGroupName, publicIpAddressName, expand).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the specified public IP address in a specified resource group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='publicIpAddressName'>
        /// The name of the public IP address.
        /// </param>
        /// <param name='expand'>
        /// Expands referenced resources.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<PublicIPAddress> GetAsync(this IPublicIPAddressesOperations operations, string resourceGroupName, string publicIpAddressName, string expand = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, publicIpAddressName, expand, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
