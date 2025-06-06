// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Extensions;

    /// <summary>Marketplace Subscription</summary>
    public partial class MarketplaceSaaSInfoMarketplaceSubscription :
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IMarketplaceSaaSInfoMarketplaceSubscription,
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IMarketplaceSaaSInfoMarketplaceSubscriptionInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Marketplace Subscription Id. This is a GUID-formatted string.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>
        /// Creates an new <see cref="MarketplaceSaaSInfoMarketplaceSubscription" /> instance.
        /// </summary>
        public MarketplaceSaaSInfoMarketplaceSubscription()
        {

        }
    }
    /// Marketplace Subscription
    public partial interface IMarketplaceSaaSInfoMarketplaceSubscription :
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.IJsonSerializable
    {
        /// <summary>Marketplace Subscription Id. This is a GUID-formatted string.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Marketplace Subscription Id. This is a GUID-formatted string.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

    }
    /// Marketplace Subscription
    internal partial interface IMarketplaceSaaSInfoMarketplaceSubscriptionInternal

    {
        /// <summary>Marketplace Subscription Id. This is a GUID-formatted string.</summary>
        string Id { get; set; }

    }
}