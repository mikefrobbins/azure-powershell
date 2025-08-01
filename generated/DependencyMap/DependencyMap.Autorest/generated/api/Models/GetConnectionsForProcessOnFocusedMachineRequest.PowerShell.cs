// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Runtime.PowerShell;

    /// <summary>GetConnectionsForProcessOnFocusedMachine request model</summary>
    [System.ComponentModel.TypeConverter(typeof(GetConnectionsForProcessOnFocusedMachineRequestTypeConverter))]
    public partial class GetConnectionsForProcessOnFocusedMachineRequest
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.GetConnectionsForProcessOnFocusedMachineRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequest"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequest DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new GetConnectionsForProcessOnFocusedMachineRequest(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.GetConnectionsForProcessOnFocusedMachineRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequest"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequest DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new GetConnectionsForProcessOnFocusedMachineRequest(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="GetConnectionsForProcessOnFocusedMachineRequest" />, deserializing the content from
        /// a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="GetConnectionsForProcessOnFocusedMachineRequest" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequest FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.GetConnectionsForProcessOnFocusedMachineRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal GetConnectionsForProcessOnFocusedMachineRequest(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Filter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequestInternal)this).Filter = (Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IDependencyMapVisualizationFilter) content.GetValueForProperty("Filter",((Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequestInternal)this).Filter, Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.DependencyMapVisualizationFilterTypeConverter.ConvertFrom);
            }
            if (content.Contains("FocusedMachineId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequestInternal)this).FocusedMachineId = (string) content.GetValueForProperty("FocusedMachineId",((Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequestInternal)this).FocusedMachineId, global::System.Convert.ToString);
            }
            if (content.Contains("ProcessIdOnFocusedMachine"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequestInternal)this).ProcessIdOnFocusedMachine = (string) content.GetValueForProperty("ProcessIdOnFocusedMachine",((Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequestInternal)this).ProcessIdOnFocusedMachine, global::System.Convert.ToString);
            }
            if (content.Contains("FilterDateTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequestInternal)this).FilterDateTime = (Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IDateTimeFilter) content.GetValueForProperty("FilterDateTime",((Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequestInternal)this).FilterDateTime, Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.DateTimeFilterTypeConverter.ConvertFrom);
            }
            if (content.Contains("FilterProcessNameFilter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequestInternal)this).FilterProcessNameFilter = (Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IProcessNameFilter) content.GetValueForProperty("FilterProcessNameFilter",((Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequestInternal)this).FilterProcessNameFilter, Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.ProcessNameFilterTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProcessNameFilterOperator"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequestInternal)this).ProcessNameFilterOperator = (string) content.GetValueForProperty("ProcessNameFilterOperator",((Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequestInternal)this).ProcessNameFilterOperator, global::System.Convert.ToString);
            }
            if (content.Contains("ProcessNameFilterProcessName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequestInternal)this).ProcessNameFilterProcessName = (System.Collections.Generic.List<string>) content.GetValueForProperty("ProcessNameFilterProcessName",((Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequestInternal)this).ProcessNameFilterProcessName, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DateTimeStartDateTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequestInternal)this).DateTimeStartDateTimeUtc = (global::System.DateTime?) content.GetValueForProperty("DateTimeStartDateTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequestInternal)this).DateTimeStartDateTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("DateTimeEndDateTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequestInternal)this).DateTimeEndDateTimeUtc = (global::System.DateTime?) content.GetValueForProperty("DateTimeEndDateTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequestInternal)this).DateTimeEndDateTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.GetConnectionsForProcessOnFocusedMachineRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal GetConnectionsForProcessOnFocusedMachineRequest(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Filter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequestInternal)this).Filter = (Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IDependencyMapVisualizationFilter) content.GetValueForProperty("Filter",((Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequestInternal)this).Filter, Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.DependencyMapVisualizationFilterTypeConverter.ConvertFrom);
            }
            if (content.Contains("FocusedMachineId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequestInternal)this).FocusedMachineId = (string) content.GetValueForProperty("FocusedMachineId",((Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequestInternal)this).FocusedMachineId, global::System.Convert.ToString);
            }
            if (content.Contains("ProcessIdOnFocusedMachine"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequestInternal)this).ProcessIdOnFocusedMachine = (string) content.GetValueForProperty("ProcessIdOnFocusedMachine",((Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequestInternal)this).ProcessIdOnFocusedMachine, global::System.Convert.ToString);
            }
            if (content.Contains("FilterDateTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequestInternal)this).FilterDateTime = (Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IDateTimeFilter) content.GetValueForProperty("FilterDateTime",((Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequestInternal)this).FilterDateTime, Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.DateTimeFilterTypeConverter.ConvertFrom);
            }
            if (content.Contains("FilterProcessNameFilter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequestInternal)this).FilterProcessNameFilter = (Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IProcessNameFilter) content.GetValueForProperty("FilterProcessNameFilter",((Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequestInternal)this).FilterProcessNameFilter, Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.ProcessNameFilterTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProcessNameFilterOperator"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequestInternal)this).ProcessNameFilterOperator = (string) content.GetValueForProperty("ProcessNameFilterOperator",((Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequestInternal)this).ProcessNameFilterOperator, global::System.Convert.ToString);
            }
            if (content.Contains("ProcessNameFilterProcessName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequestInternal)this).ProcessNameFilterProcessName = (System.Collections.Generic.List<string>) content.GetValueForProperty("ProcessNameFilterProcessName",((Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequestInternal)this).ProcessNameFilterProcessName, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DateTimeStartDateTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequestInternal)this).DateTimeStartDateTimeUtc = (global::System.DateTime?) content.GetValueForProperty("DateTimeStartDateTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequestInternal)this).DateTimeStartDateTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("DateTimeEndDateTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequestInternal)this).DateTimeEndDateTimeUtc = (global::System.DateTime?) content.GetValueForProperty("DateTimeEndDateTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IGetConnectionsForProcessOnFocusedMachineRequestInternal)this).DateTimeEndDateTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// GetConnectionsForProcessOnFocusedMachine request model
    [System.ComponentModel.TypeConverter(typeof(GetConnectionsForProcessOnFocusedMachineRequestTypeConverter))]
    public partial interface IGetConnectionsForProcessOnFocusedMachineRequest

    {

    }
}