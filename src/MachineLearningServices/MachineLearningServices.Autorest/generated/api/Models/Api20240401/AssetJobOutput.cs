// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>Asset output type.</summary>
    public partial class AssetJobOutput :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAssetJobOutput,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAssetJobOutputInternal
    {

        /// <summary>Backing field for <see cref="Mode" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.OutputDeliveryMode? _mode;

        /// <summary>Output Asset Delivery Mode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.OutputDeliveryMode? Mode { get => this._mode; set => this._mode = value; }

        /// <summary>Backing field for <see cref="Uri" /> property.</summary>
        private string _uri;

        /// <summary>Output Asset URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string Uri { get => this._uri; set => this._uri = value; }

        /// <summary>Creates an new <see cref="AssetJobOutput" /> instance.</summary>
        public AssetJobOutput()
        {

        }
    }
    /// Asset output type.
    public partial interface IAssetJobOutput :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>Output Asset Delivery Mode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Output Asset Delivery Mode.",
        SerializedName = @"mode",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.OutputDeliveryMode) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.OutputDeliveryMode? Mode { get; set; }
        /// <summary>Output Asset URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Output Asset URI.",
        SerializedName = @"uri",
        PossibleTypes = new [] { typeof(string) })]
        string Uri { get; set; }

    }
    /// Asset output type.
    internal partial interface IAssetJobOutputInternal

    {
        /// <summary>Output Asset Delivery Mode.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.OutputDeliveryMode? Mode { get; set; }
        /// <summary>Output Asset URI.</summary>
        string Uri { get; set; }

    }
}