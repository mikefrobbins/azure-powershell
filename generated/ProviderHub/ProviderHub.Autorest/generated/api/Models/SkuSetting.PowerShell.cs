// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(SkuSettingTypeConverter))]
    public partial class SkuSetting
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
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.SkuSetting"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSetting" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSetting DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SkuSetting(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.SkuSetting"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSetting" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSetting DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SkuSetting(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SkuSetting" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SkuSetting" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSetting FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.SkuSetting"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SkuSetting(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Capacity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).Capacity = (Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingCapacity) content.GetValueForProperty("Capacity",((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).Capacity, Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.SkuSettingCapacityTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Tier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).Tier = (string) content.GetValueForProperty("Tier",((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).Tier, global::System.Convert.ToString);
            }
            if (content.Contains("Size"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).Size = (string) content.GetValueForProperty("Size",((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).Size, global::System.Convert.ToString);
            }
            if (content.Contains("Family"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).Family = (string) content.GetValueForProperty("Family",((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).Family, global::System.Convert.ToString);
            }
            if (content.Contains("Kind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).Kind = (string) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).Kind, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).Location = (System.Collections.Generic.List<string>) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).Location, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("LocationInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).LocationInfo = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuLocationInfo>) content.GetValueForProperty("LocationInfo",((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).LocationInfo, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuLocationInfo>(__y, Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.SkuLocationInfoTypeConverter.ConvertFrom));
            }
            if (content.Contains("RequiredQuotaId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).RequiredQuotaId = (System.Collections.Generic.List<string>) content.GetValueForProperty("RequiredQuotaId",((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).RequiredQuotaId, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("RequiredFeature"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).RequiredFeature = (System.Collections.Generic.List<string>) content.GetValueForProperty("RequiredFeature",((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).RequiredFeature, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("Cost"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).Cost = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuCost>) content.GetValueForProperty("Cost",((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).Cost, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuCost>(__y, Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.SkuCostTypeConverter.ConvertFrom));
            }
            if (content.Contains("Capability"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).Capability = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuCapability>) content.GetValueForProperty("Capability",((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).Capability, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuCapability>(__y, Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.SkuCapabilityTypeConverter.ConvertFrom));
            }
            if (content.Contains("CapacityMinimum"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).CapacityMinimum = (int?) content.GetValueForProperty("CapacityMinimum",((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).CapacityMinimum, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("CapacityMaximum"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).CapacityMaximum = (int?) content.GetValueForProperty("CapacityMaximum",((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).CapacityMaximum, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("CapacityDefault"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).CapacityDefault = (int?) content.GetValueForProperty("CapacityDefault",((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).CapacityDefault, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("CapacityScaleType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).CapacityScaleType = (string) content.GetValueForProperty("CapacityScaleType",((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).CapacityScaleType, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.SkuSetting"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SkuSetting(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Capacity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).Capacity = (Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingCapacity) content.GetValueForProperty("Capacity",((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).Capacity, Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.SkuSettingCapacityTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Tier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).Tier = (string) content.GetValueForProperty("Tier",((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).Tier, global::System.Convert.ToString);
            }
            if (content.Contains("Size"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).Size = (string) content.GetValueForProperty("Size",((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).Size, global::System.Convert.ToString);
            }
            if (content.Contains("Family"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).Family = (string) content.GetValueForProperty("Family",((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).Family, global::System.Convert.ToString);
            }
            if (content.Contains("Kind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).Kind = (string) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).Kind, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).Location = (System.Collections.Generic.List<string>) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).Location, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("LocationInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).LocationInfo = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuLocationInfo>) content.GetValueForProperty("LocationInfo",((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).LocationInfo, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuLocationInfo>(__y, Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.SkuLocationInfoTypeConverter.ConvertFrom));
            }
            if (content.Contains("RequiredQuotaId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).RequiredQuotaId = (System.Collections.Generic.List<string>) content.GetValueForProperty("RequiredQuotaId",((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).RequiredQuotaId, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("RequiredFeature"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).RequiredFeature = (System.Collections.Generic.List<string>) content.GetValueForProperty("RequiredFeature",((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).RequiredFeature, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("Cost"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).Cost = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuCost>) content.GetValueForProperty("Cost",((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).Cost, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuCost>(__y, Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.SkuCostTypeConverter.ConvertFrom));
            }
            if (content.Contains("Capability"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).Capability = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuCapability>) content.GetValueForProperty("Capability",((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).Capability, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuCapability>(__y, Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.SkuCapabilityTypeConverter.ConvertFrom));
            }
            if (content.Contains("CapacityMinimum"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).CapacityMinimum = (int?) content.GetValueForProperty("CapacityMinimum",((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).CapacityMinimum, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("CapacityMaximum"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).CapacityMaximum = (int?) content.GetValueForProperty("CapacityMaximum",((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).CapacityMaximum, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("CapacityDefault"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).CapacityDefault = (int?) content.GetValueForProperty("CapacityDefault",((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).CapacityDefault, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("CapacityScaleType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).CapacityScaleType = (string) content.GetValueForProperty("CapacityScaleType",((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ISkuSettingInternal)this).CapacityScaleType, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    [System.ComponentModel.TypeConverter(typeof(SkuSettingTypeConverter))]
    public partial interface ISkuSetting

    {

    }
}