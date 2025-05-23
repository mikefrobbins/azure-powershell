// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.PowerShell;

    /// <summary>Schema for MSIX Package properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(MsixPackagePropertiesTypeConverter))]
    public partial class MsixPackageProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.MsixPackageProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackageProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackageProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MsixPackageProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.MsixPackageProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackageProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackageProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MsixPackageProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MsixPackageProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="MsixPackageProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackageProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.MsixPackageProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MsixPackageProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ImagePath"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).ImagePath = (string) content.GetValueForProperty("ImagePath",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).ImagePath, global::System.Convert.ToString);
            }
            if (content.Contains("PackageName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).PackageName = (string) content.GetValueForProperty("PackageName",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).PackageName, global::System.Convert.ToString);
            }
            if (content.Contains("PackageFamilyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).PackageFamilyName = (string) content.GetValueForProperty("PackageFamilyName",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).PackageFamilyName, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("PackageRelativePath"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).PackageRelativePath = (string) content.GetValueForProperty("PackageRelativePath",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).PackageRelativePath, global::System.Convert.ToString);
            }
            if (content.Contains("IsRegularRegistration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).IsRegularRegistration = (bool?) content.GetValueForProperty("IsRegularRegistration",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).IsRegularRegistration, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsActive"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).IsActive = (bool?) content.GetValueForProperty("IsActive",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).IsActive, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("PackageDependency"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).PackageDependency = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackageDependencies>) content.GetValueForProperty("PackageDependency",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).PackageDependency, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackageDependencies>(__y, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.MsixPackageDependenciesTypeConverter.ConvertFrom));
            }
            if (content.Contains("Version"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).Version = (string) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).Version, global::System.Convert.ToString);
            }
            if (content.Contains("LastUpdated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).LastUpdated = (global::System.DateTime?) content.GetValueForProperty("LastUpdated",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).LastUpdated, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("PackageApplication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).PackageApplication = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackageApplications>) content.GetValueForProperty("PackageApplication",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).PackageApplication, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackageApplications>(__y, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.MsixPackageApplicationsTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.MsixPackageProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MsixPackageProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ImagePath"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).ImagePath = (string) content.GetValueForProperty("ImagePath",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).ImagePath, global::System.Convert.ToString);
            }
            if (content.Contains("PackageName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).PackageName = (string) content.GetValueForProperty("PackageName",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).PackageName, global::System.Convert.ToString);
            }
            if (content.Contains("PackageFamilyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).PackageFamilyName = (string) content.GetValueForProperty("PackageFamilyName",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).PackageFamilyName, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("PackageRelativePath"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).PackageRelativePath = (string) content.GetValueForProperty("PackageRelativePath",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).PackageRelativePath, global::System.Convert.ToString);
            }
            if (content.Contains("IsRegularRegistration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).IsRegularRegistration = (bool?) content.GetValueForProperty("IsRegularRegistration",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).IsRegularRegistration, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsActive"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).IsActive = (bool?) content.GetValueForProperty("IsActive",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).IsActive, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("PackageDependency"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).PackageDependency = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackageDependencies>) content.GetValueForProperty("PackageDependency",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).PackageDependency, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackageDependencies>(__y, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.MsixPackageDependenciesTypeConverter.ConvertFrom));
            }
            if (content.Contains("Version"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).Version = (string) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).Version, global::System.Convert.ToString);
            }
            if (content.Contains("LastUpdated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).LastUpdated = (global::System.DateTime?) content.GetValueForProperty("LastUpdated",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).LastUpdated, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("PackageApplication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).PackageApplication = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackageApplications>) content.GetValueForProperty("PackageApplication",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackagePropertiesInternal)this).PackageApplication, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IMsixPackageApplications>(__y, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.MsixPackageApplicationsTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Schema for MSIX Package properties.
    [System.ComponentModel.TypeConverter(typeof(MsixPackagePropertiesTypeConverter))]
    public partial interface IMsixPackageProperties

    {

    }
}