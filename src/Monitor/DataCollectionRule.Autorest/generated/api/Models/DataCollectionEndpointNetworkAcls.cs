// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.Extensions;

    /// <summary>Network access control rules for the endpoints.</summary>
    public partial class DataCollectionEndpointNetworkAcls :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointNetworkAcls,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointNetworkAclsInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.INetworkRuleSet"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.INetworkRuleSet __networkRuleSet = new Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.NetworkRuleSet();

        /// <summary>
        /// The configuration to set whether network access from public internet to the endpoints are allowed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PropertyOrigin.Inherited)]
        public string PublicNetworkAccess { get => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.INetworkRuleSetInternal)__networkRuleSet).PublicNetworkAccess; set => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.INetworkRuleSetInternal)__networkRuleSet).PublicNetworkAccess = value ?? null; }

        /// <summary>Creates an new <see cref="DataCollectionEndpointNetworkAcls" /> instance.</summary>
        public DataCollectionEndpointNetworkAcls()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__networkRuleSet), __networkRuleSet);
            await eventListener.AssertObjectIsValid(nameof(__networkRuleSet), __networkRuleSet);
        }
    }
    /// Network access control rules for the endpoints.
    public partial interface IDataCollectionEndpointNetworkAcls :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.INetworkRuleSet
    {

    }
    /// Network access control rules for the endpoints.
    internal partial interface IDataCollectionEndpointNetworkAclsInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.INetworkRuleSetInternal
    {

    }
}