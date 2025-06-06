// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Extensions;

    public partial class SubscriptionLifecycleNotificationSpecifications :
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISubscriptionLifecycleNotificationSpecifications,
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISubscriptionLifecycleNotificationSpecificationsInternal
    {

        /// <summary>Backing field for <see cref="SoftDeleteTtl" /> property.</summary>
        private global::System.TimeSpan? _softDeleteTtl;

        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.PropertyOrigin.Owned)]
        public global::System.TimeSpan? SoftDeleteTtl { get => this._softDeleteTtl; set => this._softDeleteTtl = value; }

        /// <summary>Backing field for <see cref="SubscriptionStateOverrideAction" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISubscriptionStateOverrideAction> _subscriptionStateOverrideAction;

        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISubscriptionStateOverrideAction> SubscriptionStateOverrideAction { get => this._subscriptionStateOverrideAction; set => this._subscriptionStateOverrideAction = value; }

        /// <summary>
        /// Creates an new <see cref="SubscriptionLifecycleNotificationSpecifications" /> instance.
        /// </summary>
        public SubscriptionLifecycleNotificationSpecifications()
        {

        }
    }
    public partial interface ISubscriptionLifecycleNotificationSpecifications :
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"softDeleteTTL",
        PossibleTypes = new [] { typeof(global::System.TimeSpan) })]
        global::System.TimeSpan? SoftDeleteTtl { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"subscriptionStateOverrideActions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISubscriptionStateOverrideAction) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISubscriptionStateOverrideAction> SubscriptionStateOverrideAction { get; set; }

    }
    internal partial interface ISubscriptionLifecycleNotificationSpecificationsInternal

    {
        global::System.TimeSpan? SoftDeleteTtl { get; set; }

        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISubscriptionStateOverrideAction> SubscriptionStateOverrideAction { get; set; }

    }
}