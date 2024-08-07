// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    public partial class MonitorEmailNotificationSettings :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitorEmailNotificationSettings,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitorEmailNotificationSettingsInternal
    {

        /// <summary>Backing field for <see cref="Email" /> property.</summary>
        private string[] _email;

        /// <summary>The email recipient list which has a limitation of 499 characters in total.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string[] Email { get => this._email; set => this._email = value; }

        /// <summary>Creates an new <see cref="MonitorEmailNotificationSettings" /> instance.</summary>
        public MonitorEmailNotificationSettings()
        {

        }
    }
    public partial interface IMonitorEmailNotificationSettings :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>The email recipient list which has a limitation of 499 characters in total.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The email recipient list which has a limitation of 499 characters in total.",
        SerializedName = @"emails",
        PossibleTypes = new [] { typeof(string) })]
        string[] Email { get; set; }

    }
    internal partial interface IMonitorEmailNotificationSettingsInternal

    {
        /// <summary>The email recipient list which has a limitation of 499 characters in total.</summary>
        string[] Email { get; set; }

    }
}