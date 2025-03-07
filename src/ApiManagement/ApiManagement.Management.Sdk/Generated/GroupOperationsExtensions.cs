// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.ApiManagement
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for GroupOperations
    /// </summary>
    public static partial class GroupOperationsExtensions
    {
        /// <summary>
        /// Lists a collection of groups defined within a service instance.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='odataQuery'>
        /// 
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<GroupContract> ListByService(this IGroupOperations operations, string resourceGroupName, string serviceName, Microsoft.Rest.Azure.OData.ODataQuery<GroupContract> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<GroupContract>))
        {
                return ((IGroupOperations)operations).ListByServiceAsync(resourceGroupName, serviceName, odataQuery).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Lists a collection of groups defined within a service instance.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='odataQuery'>
        /// 
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<GroupContract>> ListByServiceAsync(this IGroupOperations operations, string resourceGroupName, string serviceName, Microsoft.Rest.Azure.OData.ODataQuery<GroupContract> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<GroupContract>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListByServiceWithHttpMessagesAsync(resourceGroupName, serviceName, odataQuery, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Gets the entity state (Etag) version of the group specified by its
        /// identifier.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='groupId'>
        /// Group identifier. Must be unique in the current API Management service
        /// instance.
        /// </param>
        public static bool GetEntityTag(this IGroupOperations operations, string resourceGroupName, string serviceName, string groupId)
        {
                return ((IGroupOperations)operations).GetEntityTagAsync(resourceGroupName, serviceName, groupId).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the entity state (Etag) version of the group specified by its
        /// identifier.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='groupId'>
        /// Group identifier. Must be unique in the current API Management service
        /// instance.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<bool> GetEntityTagAsync(this IGroupOperations operations, string resourceGroupName, string serviceName, string groupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetEntityTagWithHttpMessagesAsync(resourceGroupName, serviceName, groupId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Gets the details of the group specified by its identifier.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='groupId'>
        /// Group identifier. Must be unique in the current API Management service
        /// instance.
        /// </param>
        public static GroupContract Get(this IGroupOperations operations, string resourceGroupName, string serviceName, string groupId)
        {
                return ((IGroupOperations)operations).GetAsync(resourceGroupName, serviceName, groupId).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the details of the group specified by its identifier.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='groupId'>
        /// Group identifier. Must be unique in the current API Management service
        /// instance.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<GroupContract> GetAsync(this IGroupOperations operations, string resourceGroupName, string serviceName, string groupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serviceName, groupId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Creates or Updates a group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='groupId'>
        /// Group identifier. Must be unique in the current API Management service
        /// instance.
        /// </param>
        /// <param name='ifMatch'>
        /// ETag of the Entity. Not required when creating an entity, but required when
        /// updating an entity.
        /// </param>
        public static GroupContract CreateOrUpdate(this IGroupOperations operations, string resourceGroupName, string serviceName, string groupId, GroupCreateParameters parameters, string ifMatch = default(string))
        {
                return ((IGroupOperations)operations).CreateOrUpdateAsync(resourceGroupName, serviceName, groupId, parameters, ifMatch).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates or Updates a group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='groupId'>
        /// Group identifier. Must be unique in the current API Management service
        /// instance.
        /// </param>
        /// <param name='ifMatch'>
        /// ETag of the Entity. Not required when creating an entity, but required when
        /// updating an entity.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<GroupContract> CreateOrUpdateAsync(this IGroupOperations operations, string resourceGroupName, string serviceName, string groupId, GroupCreateParameters parameters, string ifMatch = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serviceName, groupId, parameters, ifMatch, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Updates the details of the group specified by its identifier.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='groupId'>
        /// Group identifier. Must be unique in the current API Management service
        /// instance.
        /// </param>
        /// <param name='ifMatch'>
        /// ETag of the Entity. ETag should match the current entity state from the
        /// header response of the GET request or it should be * for unconditional
        /// update.
        /// </param>
        public static GroupContract Update(this IGroupOperations operations, string resourceGroupName, string serviceName, string groupId, string ifMatch, GroupUpdateParameters parameters)
        {
                return ((IGroupOperations)operations).UpdateAsync(resourceGroupName, serviceName, groupId, ifMatch, parameters).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Updates the details of the group specified by its identifier.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='groupId'>
        /// Group identifier. Must be unique in the current API Management service
        /// instance.
        /// </param>
        /// <param name='ifMatch'>
        /// ETag of the Entity. ETag should match the current entity state from the
        /// header response of the GET request or it should be * for unconditional
        /// update.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<GroupContract> UpdateAsync(this IGroupOperations operations, string resourceGroupName, string serviceName, string groupId, string ifMatch, GroupUpdateParameters parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, serviceName, groupId, ifMatch, parameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Deletes specific group of the API Management service instance.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='groupId'>
        /// Group identifier. Must be unique in the current API Management service
        /// instance.
        /// </param>
        /// <param name='ifMatch'>
        /// ETag of the Entity. ETag should match the current entity state from the
        /// header response of the GET request or it should be * for unconditional
        /// update.
        /// </param>
        public static void Delete(this IGroupOperations operations, string resourceGroupName, string serviceName, string groupId, string ifMatch)
        {
                ((IGroupOperations)operations).DeleteAsync(resourceGroupName, serviceName, groupId, ifMatch).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes specific group of the API Management service instance.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='groupId'>
        /// Group identifier. Must be unique in the current API Management service
        /// instance.
        /// </param>
        /// <param name='ifMatch'>
        /// ETag of the Entity. ETag should match the current entity state from the
        /// header response of the GET request or it should be * for unconditional
        /// update.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task DeleteAsync(this IGroupOperations operations, string resourceGroupName, string serviceName, string groupId, string ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serviceName, groupId, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// Lists a collection of groups defined within a service instance.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<GroupContract> ListByServiceNext(this IGroupOperations operations, string nextPageLink)
        {
                return ((IGroupOperations)operations).ListByServiceNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Lists a collection of groups defined within a service instance.
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
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<GroupContract>> ListByServiceNextAsync(this IGroupOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListByServiceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
