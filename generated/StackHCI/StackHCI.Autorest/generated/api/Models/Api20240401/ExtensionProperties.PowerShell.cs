// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401
{
    using Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.PowerShell;

    /// <summary>Status of Arc Extension for a particular node in HCI Cluster.</summary>
    [System.ComponentModel.TypeConverter(typeof(ExtensionPropertiesTypeConverter))]
    public partial class ExtensionProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ExtensionProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ExtensionProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ExtensionProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ExtensionProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ExtensionProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ExtensionProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ExtensionParameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ExtensionParameter = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionParameters) content.GetValueForProperty("ExtensionParameter",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ExtensionParameter, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ExtensionParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("AggregateState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).AggregateState = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ExtensionAggregateState?) content.GetValueForProperty("AggregateState",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).AggregateState, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ExtensionAggregateState.CreateFrom);
            }
            if (content.Contains("PerNodeExtensionDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).PerNodeExtensionDetail = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IPerNodeExtensionState[]) content.GetValueForProperty("PerNodeExtensionDetail",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).PerNodeExtensionDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IPerNodeExtensionState>(__y, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.PerNodeExtensionStateTypeConverter.ConvertFrom));
            }
            if (content.Contains("ManagedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ManagedBy = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ExtensionManagedBy?) content.GetValueForProperty("ManagedBy",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ManagedBy, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ExtensionManagedBy.CreateFrom);
            }
            if (content.Contains("ExtensionParameterPublisher"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ExtensionParameterPublisher = (string) content.GetValueForProperty("ExtensionParameterPublisher",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ExtensionParameterPublisher, global::System.Convert.ToString);
            }
            if (content.Contains("ExtensionParameterType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ExtensionParameterType = (string) content.GetValueForProperty("ExtensionParameterType",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ExtensionParameterType, global::System.Convert.ToString);
            }
            if (content.Contains("ExtensionParameterSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ExtensionParameterSetting = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionParametersSettings) content.GetValueForProperty("ExtensionParameterSetting",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ExtensionParameterSetting, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ExtensionParametersSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ExtensionParameterProtectedSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ExtensionParameterProtectedSetting = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionParametersProtectedSettings) content.GetValueForProperty("ExtensionParameterProtectedSetting",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ExtensionParameterProtectedSetting, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ExtensionParametersProtectedSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ExtensionParameterForceUpdateTag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ExtensionParameterForceUpdateTag = (string) content.GetValueForProperty("ExtensionParameterForceUpdateTag",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ExtensionParameterForceUpdateTag, global::System.Convert.ToString);
            }
            if (content.Contains("ExtensionParameterTypeHandlerVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ExtensionParameterTypeHandlerVersion = (string) content.GetValueForProperty("ExtensionParameterTypeHandlerVersion",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ExtensionParameterTypeHandlerVersion, global::System.Convert.ToString);
            }
            if (content.Contains("ExtensionParameterAutoUpgradeMinorVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ExtensionParameterAutoUpgradeMinorVersion = (bool?) content.GetValueForProperty("ExtensionParameterAutoUpgradeMinorVersion",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ExtensionParameterAutoUpgradeMinorVersion, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ExtensionParameterEnableAutomaticUpgrade"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ExtensionParameterEnableAutomaticUpgrade = (bool?) content.GetValueForProperty("ExtensionParameterEnableAutomaticUpgrade",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ExtensionParameterEnableAutomaticUpgrade, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ExtensionProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ExtensionProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ExtensionParameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ExtensionParameter = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionParameters) content.GetValueForProperty("ExtensionParameter",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ExtensionParameter, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ExtensionParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("AggregateState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).AggregateState = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ExtensionAggregateState?) content.GetValueForProperty("AggregateState",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).AggregateState, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ExtensionAggregateState.CreateFrom);
            }
            if (content.Contains("PerNodeExtensionDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).PerNodeExtensionDetail = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IPerNodeExtensionState[]) content.GetValueForProperty("PerNodeExtensionDetail",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).PerNodeExtensionDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IPerNodeExtensionState>(__y, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.PerNodeExtensionStateTypeConverter.ConvertFrom));
            }
            if (content.Contains("ManagedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ManagedBy = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ExtensionManagedBy?) content.GetValueForProperty("ManagedBy",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ManagedBy, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ExtensionManagedBy.CreateFrom);
            }
            if (content.Contains("ExtensionParameterPublisher"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ExtensionParameterPublisher = (string) content.GetValueForProperty("ExtensionParameterPublisher",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ExtensionParameterPublisher, global::System.Convert.ToString);
            }
            if (content.Contains("ExtensionParameterType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ExtensionParameterType = (string) content.GetValueForProperty("ExtensionParameterType",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ExtensionParameterType, global::System.Convert.ToString);
            }
            if (content.Contains("ExtensionParameterSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ExtensionParameterSetting = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionParametersSettings) content.GetValueForProperty("ExtensionParameterSetting",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ExtensionParameterSetting, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ExtensionParametersSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ExtensionParameterProtectedSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ExtensionParameterProtectedSetting = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionParametersProtectedSettings) content.GetValueForProperty("ExtensionParameterProtectedSetting",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ExtensionParameterProtectedSetting, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ExtensionParametersProtectedSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ExtensionParameterForceUpdateTag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ExtensionParameterForceUpdateTag = (string) content.GetValueForProperty("ExtensionParameterForceUpdateTag",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ExtensionParameterForceUpdateTag, global::System.Convert.ToString);
            }
            if (content.Contains("ExtensionParameterTypeHandlerVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ExtensionParameterTypeHandlerVersion = (string) content.GetValueForProperty("ExtensionParameterTypeHandlerVersion",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ExtensionParameterTypeHandlerVersion, global::System.Convert.ToString);
            }
            if (content.Contains("ExtensionParameterAutoUpgradeMinorVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ExtensionParameterAutoUpgradeMinorVersion = (bool?) content.GetValueForProperty("ExtensionParameterAutoUpgradeMinorVersion",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ExtensionParameterAutoUpgradeMinorVersion, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ExtensionParameterEnableAutomaticUpgrade"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ExtensionParameterEnableAutomaticUpgrade = (bool?) content.GetValueForProperty("ExtensionParameterEnableAutomaticUpgrade",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionPropertiesInternal)this).ExtensionParameterEnableAutomaticUpgrade, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ExtensionProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ExtensionProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Status of Arc Extension for a particular node in HCI Cluster.
    [System.ComponentModel.TypeConverter(typeof(ExtensionPropertiesTypeConverter))]
    public partial interface IExtensionProperties

    {

    }
}