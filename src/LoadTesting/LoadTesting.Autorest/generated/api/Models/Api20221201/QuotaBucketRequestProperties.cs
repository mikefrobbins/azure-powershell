// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api20221201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Runtime.Extensions;

    /// <summary>New quota request request properties.</summary>
    public partial class QuotaBucketRequestProperties :
        Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api20221201.IQuotaBucketRequestProperties,
        Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api20221201.IQuotaBucketRequestPropertiesInternal
    {

        /// <summary>Backing field for <see cref="CurrentQuota" /> property.</summary>
        private int? _currentQuota;

        /// <summary>Current quota limit of the quota bucket.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Origin(Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.PropertyOrigin.Owned)]
        public int? CurrentQuota { get => this._currentQuota; set => this._currentQuota = value; }

        /// <summary>Backing field for <see cref="CurrentUsage" /> property.</summary>
        private int? _currentUsage;

        /// <summary>Current quota usage of the quota bucket.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Origin(Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.PropertyOrigin.Owned)]
        public int? CurrentUsage { get => this._currentUsage; set => this._currentUsage = value; }

        /// <summary>Backing field for <see cref="Dimension" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api20221201.IQuotaBucketRequestPropertiesDimensions _dimension;

        /// <summary>Dimensions for new quota request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Origin(Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api20221201.IQuotaBucketRequestPropertiesDimensions Dimension { get => (this._dimension = this._dimension ?? new Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api20221201.QuotaBucketRequestPropertiesDimensions()); set => this._dimension = value; }

        /// <summary>Location dimension for new quota request of the quota bucket.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Origin(Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.PropertyOrigin.Inlined)]
        public string DimensionLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api20221201.IQuotaBucketRequestPropertiesDimensionsInternal)Dimension).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api20221201.IQuotaBucketRequestPropertiesDimensionsInternal)Dimension).Location = value ?? null; }

        /// <summary>Subscription Id dimension for new quota request of the quota bucket.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Origin(Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.PropertyOrigin.Inlined)]
        public string DimensionSubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api20221201.IQuotaBucketRequestPropertiesDimensionsInternal)Dimension).SubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api20221201.IQuotaBucketRequestPropertiesDimensionsInternal)Dimension).SubscriptionId = value ?? null; }

        /// <summary>Internal Acessors for Dimension</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api20221201.IQuotaBucketRequestPropertiesDimensions Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api20221201.IQuotaBucketRequestPropertiesInternal.Dimension { get => (this._dimension = this._dimension ?? new Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api20221201.QuotaBucketRequestPropertiesDimensions()); set { {_dimension = value;} } }

        /// <summary>Backing field for <see cref="NewQuota" /> property.</summary>
        private int? _newQuota;

        /// <summary>New quota limit of the quota bucket.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Origin(Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.PropertyOrigin.Owned)]
        public int? NewQuota { get => this._newQuota; set => this._newQuota = value; }

        /// <summary>Creates an new <see cref="QuotaBucketRequestProperties" /> instance.</summary>
        public QuotaBucketRequestProperties()
        {

        }
    }
    /// New quota request request properties.
    public partial interface IQuotaBucketRequestProperties :
        Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Runtime.IJsonSerializable
    {
        /// <summary>Current quota limit of the quota bucket.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Current quota limit of the quota bucket.",
        SerializedName = @"currentQuota",
        PossibleTypes = new [] { typeof(int) })]
        int? CurrentQuota { get; set; }
        /// <summary>Current quota usage of the quota bucket.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Current quota usage of the quota bucket.",
        SerializedName = @"currentUsage",
        PossibleTypes = new [] { typeof(int) })]
        int? CurrentUsage { get; set; }
        /// <summary>Location dimension for new quota request of the quota bucket.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Location dimension for new quota request of the quota bucket.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string DimensionLocation { get; set; }
        /// <summary>Subscription Id dimension for new quota request of the quota bucket.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Subscription Id dimension for new quota request of the quota bucket.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string DimensionSubscriptionId { get; set; }
        /// <summary>New quota limit of the quota bucket.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"New quota limit of the quota bucket.",
        SerializedName = @"newQuota",
        PossibleTypes = new [] { typeof(int) })]
        int? NewQuota { get; set; }

    }
    /// New quota request request properties.
    internal partial interface IQuotaBucketRequestPropertiesInternal

    {
        /// <summary>Current quota limit of the quota bucket.</summary>
        int? CurrentQuota { get; set; }
        /// <summary>Current quota usage of the quota bucket.</summary>
        int? CurrentUsage { get; set; }
        /// <summary>Dimensions for new quota request.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api20221201.IQuotaBucketRequestPropertiesDimensions Dimension { get; set; }
        /// <summary>Location dimension for new quota request of the quota bucket.</summary>
        string DimensionLocation { get; set; }
        /// <summary>Subscription Id dimension for new quota request of the quota bucket.</summary>
        string DimensionSubscriptionId { get; set; }
        /// <summary>New quota limit of the quota bucket.</summary>
        int? NewQuota { get; set; }

    }
}