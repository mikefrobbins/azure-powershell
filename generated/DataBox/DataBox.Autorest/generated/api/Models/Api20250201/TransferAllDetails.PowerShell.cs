// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.PowerShell;

    /// <summary>Details to transfer all data.</summary>
    [System.ComponentModel.TypeConverter(typeof(TransferAllDetailsTypeConverter))]
    public partial class TransferAllDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.TransferAllDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ITransferAllDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ITransferAllDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new TransferAllDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.TransferAllDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ITransferAllDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ITransferAllDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new TransferAllDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="TransferAllDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="TransferAllDetails" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ITransferAllDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.TransferAllDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal TransferAllDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DataAccountType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ITransferAllDetailsInternal)this).DataAccountType = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.DataAccountType) content.GetValueForProperty("DataAccountType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ITransferAllDetailsInternal)this).DataAccountType, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.DataAccountType.CreateFrom);
            }
            if (content.Contains("TransferAllBlob"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ITransferAllDetailsInternal)this).TransferAllBlob = (bool?) content.GetValueForProperty("TransferAllBlob",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ITransferAllDetailsInternal)this).TransferAllBlob, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("TransferAllFile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ITransferAllDetailsInternal)this).TransferAllFile = (bool?) content.GetValueForProperty("TransferAllFile",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ITransferAllDetailsInternal)this).TransferAllFile, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.TransferAllDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal TransferAllDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DataAccountType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ITransferAllDetailsInternal)this).DataAccountType = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.DataAccountType) content.GetValueForProperty("DataAccountType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ITransferAllDetailsInternal)this).DataAccountType, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.DataAccountType.CreateFrom);
            }
            if (content.Contains("TransferAllBlob"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ITransferAllDetailsInternal)this).TransferAllBlob = (bool?) content.GetValueForProperty("TransferAllBlob",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ITransferAllDetailsInternal)this).TransferAllBlob, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("TransferAllFile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ITransferAllDetailsInternal)this).TransferAllFile = (bool?) content.GetValueForProperty("TransferAllFile",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ITransferAllDetailsInternal)this).TransferAllFile, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializePSObject(content);
        }
    }
    /// Details to transfer all data.
    [System.ComponentModel.TypeConverter(typeof(TransferAllDetailsTypeConverter))]
    public partial interface ITransferAllDetails

    {

    }
}