// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201
{
    using Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.PowerShell;

    /// <summary>The configuration settings of the token store.</summary>
    [System.ComponentModel.TypeConverter(typeof(TokenStoreTypeConverter))]
    public partial class TokenStore
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.TokenStore"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ITokenStore" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ITokenStore DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new TokenStore(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.TokenStore"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ITokenStore" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ITokenStore DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new TokenStore(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="TokenStore" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="TokenStore" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ITokenStore FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.TokenStore"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal TokenStore(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("FileSystem"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ITokenStoreInternal)this).FileSystem = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFileSystemTokenStore) content.GetValueForProperty("FileSystem",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ITokenStoreInternal)this).FileSystem, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.FileSystemTokenStoreTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureBlobStorage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ITokenStoreInternal)this).AzureBlobStorage = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IBlobStorageTokenStore) content.GetValueForProperty("AzureBlobStorage",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ITokenStoreInternal)this).AzureBlobStorage, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.BlobStorageTokenStoreTypeConverter.ConvertFrom);
            }
            if (content.Contains("Enabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ITokenStoreInternal)this).Enabled = (bool?) content.GetValueForProperty("Enabled",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ITokenStoreInternal)this).Enabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("TokenRefreshExtensionHour"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ITokenStoreInternal)this).TokenRefreshExtensionHour = (double?) content.GetValueForProperty("TokenRefreshExtensionHour",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ITokenStoreInternal)this).TokenRefreshExtensionHour, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("FileSystemDirectory"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ITokenStoreInternal)this).FileSystemDirectory = (string) content.GetValueForProperty("FileSystemDirectory",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ITokenStoreInternal)this).FileSystemDirectory, global::System.Convert.ToString);
            }
            if (content.Contains("AzureBlobStorageSasUrlSettingName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ITokenStoreInternal)this).AzureBlobStorageSasUrlSettingName = (string) content.GetValueForProperty("AzureBlobStorageSasUrlSettingName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ITokenStoreInternal)this).AzureBlobStorageSasUrlSettingName, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.TokenStore"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal TokenStore(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("FileSystem"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ITokenStoreInternal)this).FileSystem = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFileSystemTokenStore) content.GetValueForProperty("FileSystem",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ITokenStoreInternal)this).FileSystem, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.FileSystemTokenStoreTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureBlobStorage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ITokenStoreInternal)this).AzureBlobStorage = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IBlobStorageTokenStore) content.GetValueForProperty("AzureBlobStorage",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ITokenStoreInternal)this).AzureBlobStorage, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.BlobStorageTokenStoreTypeConverter.ConvertFrom);
            }
            if (content.Contains("Enabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ITokenStoreInternal)this).Enabled = (bool?) content.GetValueForProperty("Enabled",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ITokenStoreInternal)this).Enabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("TokenRefreshExtensionHour"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ITokenStoreInternal)this).TokenRefreshExtensionHour = (double?) content.GetValueForProperty("TokenRefreshExtensionHour",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ITokenStoreInternal)this).TokenRefreshExtensionHour, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("FileSystemDirectory"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ITokenStoreInternal)this).FileSystemDirectory = (string) content.GetValueForProperty("FileSystemDirectory",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ITokenStoreInternal)this).FileSystemDirectory, global::System.Convert.ToString);
            }
            if (content.Contains("AzureBlobStorageSasUrlSettingName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ITokenStoreInternal)this).AzureBlobStorageSasUrlSettingName = (string) content.GetValueForProperty("AzureBlobStorageSasUrlSettingName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ITokenStoreInternal)this).AzureBlobStorageSasUrlSettingName, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// The configuration settings of the token store.
    [System.ComponentModel.TypeConverter(typeof(TokenStoreTypeConverter))]
    public partial interface ITokenStore

    {

    }
}