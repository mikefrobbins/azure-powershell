// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Runtime.PowerShell;

    /// <summary>The current status of an async operation.</summary>
    [System.ComponentModel.TypeConverter(typeof(OperationStatusTypeConverter))]
    public partial class OperationStatus
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.OperationStatus"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatus"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatus DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new OperationStatus(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.OperationStatus"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatus"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatus DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new OperationStatus(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="OperationStatus" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="OperationStatus" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatus FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.OperationStatus"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal OperationStatus(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IAzureCoreFoundationsError) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.AzureCoreFoundationsErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Support.OperationState) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Support.OperationState.CreateFrom);
            }
            if (content.Contains("ResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).ResourceId = (string) content.GetValueForProperty("ResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).ResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("StartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).StartTime = (global::System.DateTime?) content.GetValueForProperty("StartTime",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).StartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("EndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).EndTime = (global::System.DateTime?) content.GetValueForProperty("EndTime",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).EndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("PercentComplete"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).PercentComplete = (double?) content.GetValueForProperty("PercentComplete",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).PercentComplete, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.IAny) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.AnyTypeConverter.ConvertFrom);
            }
            if (content.Contains("OperationLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).OperationLocation = (string) content.GetValueForProperty("OperationLocation",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).OperationLocation, global::System.Convert.ToString);
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Message, global::System.Convert.ToString);
            }
            if (content.Contains("Target"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Target = (string) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Target, global::System.Convert.ToString);
            }
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Detail = (Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IAzureCoreFoundationsError[]) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Detail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IAzureCoreFoundationsError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.AzureCoreFoundationsErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("Innererror"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Innererror = (Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IAzureCoreFoundationsInnerError) content.GetValueForProperty("Innererror",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Innererror, Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.AzureCoreFoundationsInnerErrorTypeConverter.ConvertFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.OperationStatus"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal OperationStatus(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IAzureCoreFoundationsError) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.AzureCoreFoundationsErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Support.OperationState) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Support.OperationState.CreateFrom);
            }
            if (content.Contains("ResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).ResourceId = (string) content.GetValueForProperty("ResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).ResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("StartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).StartTime = (global::System.DateTime?) content.GetValueForProperty("StartTime",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).StartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("EndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).EndTime = (global::System.DateTime?) content.GetValueForProperty("EndTime",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).EndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("PercentComplete"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).PercentComplete = (double?) content.GetValueForProperty("PercentComplete",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).PercentComplete, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.IAny) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.AnyTypeConverter.ConvertFrom);
            }
            if (content.Contains("OperationLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).OperationLocation = (string) content.GetValueForProperty("OperationLocation",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).OperationLocation, global::System.Convert.ToString);
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Message, global::System.Convert.ToString);
            }
            if (content.Contains("Target"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Target = (string) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Target, global::System.Convert.ToString);
            }
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Detail = (Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IAzureCoreFoundationsError[]) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Detail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IAzureCoreFoundationsError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.AzureCoreFoundationsErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("Innererror"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Innererror = (Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IAzureCoreFoundationsInnerError) content.GetValueForProperty("Innererror",((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.IOperationStatusInternal)this).Innererror, Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20240501Preview.AzureCoreFoundationsInnerErrorTypeConverter.ConvertFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The current status of an async operation.
    [System.ComponentModel.TypeConverter(typeof(OperationStatusTypeConverter))]
    public partial interface IOperationStatus

    {

    }
}