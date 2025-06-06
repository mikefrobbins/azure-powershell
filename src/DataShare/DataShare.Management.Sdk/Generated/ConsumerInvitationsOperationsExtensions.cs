// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.DataShare
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for ConsumerInvitationsOperations
    /// </summary>
    public static partial class ConsumerInvitationsOperationsExtensions
    {
        /// <summary>
        /// Reject an invitation
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='location'>
        /// Location of the invitation
        /// </param>
        public static ConsumerInvitation RejectInvitation(this IConsumerInvitationsOperations operations, string location, ConsumerInvitation invitation)
        {
                return ((IConsumerInvitationsOperations)operations).RejectInvitationAsync(location, invitation).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Reject an invitation
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='location'>
        /// Location of the invitation
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<ConsumerInvitation> RejectInvitationAsync(this IConsumerInvitationsOperations operations, string location, ConsumerInvitation invitation, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.RejectInvitationWithHttpMessagesAsync(location, invitation, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Get an invitation
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='location'>
        /// Location of the invitation
        /// </param>
        /// <param name='invitationId'>
        /// An invitation id
        /// </param>
        public static ConsumerInvitation Get(this IConsumerInvitationsOperations operations, string location, string invitationId)
        {
                return ((IConsumerInvitationsOperations)operations).GetAsync(location, invitationId).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get an invitation
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='location'>
        /// Location of the invitation
        /// </param>
        /// <param name='invitationId'>
        /// An invitation id
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<ConsumerInvitation> GetAsync(this IConsumerInvitationsOperations operations, string location, string invitationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(location, invitationId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Lists invitations
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='skipToken'>
        /// The continuation token
        /// </param>
        public static Microsoft.Rest.Azure.IPage<ConsumerInvitation> ListInvitations(this IConsumerInvitationsOperations operations, string skipToken = default(string))
        {
                return ((IConsumerInvitationsOperations)operations).ListInvitationsAsync(skipToken).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Lists invitations
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='skipToken'>
        /// The continuation token
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<ConsumerInvitation>> ListInvitationsAsync(this IConsumerInvitationsOperations operations, string skipToken = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListInvitationsWithHttpMessagesAsync(skipToken, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Lists invitations
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<ConsumerInvitation> ListInvitationsNext(this IConsumerInvitationsOperations operations, string nextPageLink)
        {
                return ((IConsumerInvitationsOperations)operations).ListInvitationsNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Lists invitations
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<ConsumerInvitation>> ListInvitationsNextAsync(this IConsumerInvitationsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListInvitationsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
