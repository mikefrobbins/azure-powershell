// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.Logic
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for WorkflowRunActionRequestHistoriesOperations
    /// </summary>
    public static partial class WorkflowRunActionRequestHistoriesOperationsExtensions
    {
        /// <summary>
        /// List a workflow run request history.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='workflowName'>
        /// The workflow name.
        /// </param>
        /// <param name='runName'>
        /// The workflow run name.
        /// </param>
        /// <param name='actionName'>
        /// The workflow action name.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<RequestHistory> List(this IWorkflowRunActionRequestHistoriesOperations operations, string resourceGroupName, string workflowName, string runName, string actionName)
        {
                return ((IWorkflowRunActionRequestHistoriesOperations)operations).ListAsync(resourceGroupName, workflowName, runName, actionName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// List a workflow run request history.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='workflowName'>
        /// The workflow name.
        /// </param>
        /// <param name='runName'>
        /// The workflow run name.
        /// </param>
        /// <param name='actionName'>
        /// The workflow action name.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<RequestHistory>> ListAsync(this IWorkflowRunActionRequestHistoriesOperations operations, string resourceGroupName, string workflowName, string runName, string actionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, workflowName, runName, actionName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Gets a workflow run request history.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='workflowName'>
        /// The workflow name.
        /// </param>
        /// <param name='runName'>
        /// The workflow run name.
        /// </param>
        /// <param name='actionName'>
        /// The workflow action name.
        /// </param>
        /// <param name='requestHistoryName'>
        /// The request history name.
        /// </param>
        public static RequestHistory Get(this IWorkflowRunActionRequestHistoriesOperations operations, string resourceGroupName, string workflowName, string runName, string actionName, string requestHistoryName)
        {
                return ((IWorkflowRunActionRequestHistoriesOperations)operations).GetAsync(resourceGroupName, workflowName, runName, actionName, requestHistoryName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets a workflow run request history.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='workflowName'>
        /// The workflow name.
        /// </param>
        /// <param name='runName'>
        /// The workflow run name.
        /// </param>
        /// <param name='actionName'>
        /// The workflow action name.
        /// </param>
        /// <param name='requestHistoryName'>
        /// The request history name.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<RequestHistory> GetAsync(this IWorkflowRunActionRequestHistoriesOperations operations, string resourceGroupName, string workflowName, string runName, string actionName, string requestHistoryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workflowName, runName, actionName, requestHistoryName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// List a workflow run request history.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<RequestHistory> ListNext(this IWorkflowRunActionRequestHistoriesOperations operations, string nextPageLink)
        {
                return ((IWorkflowRunActionRequestHistoriesOperations)operations).ListNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// List a workflow run request history.
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
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<RequestHistory>> ListNextAsync(this IWorkflowRunActionRequestHistoriesOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
