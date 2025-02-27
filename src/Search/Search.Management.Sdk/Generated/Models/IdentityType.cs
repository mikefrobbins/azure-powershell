// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Search.Models
{

    /// <summary>
    /// Defines values for IdentityType.
    /// </summary>


    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum IdentityType
    {
        [System.Runtime.Serialization.EnumMember(Value = "None")]
        None,
        [System.Runtime.Serialization.EnumMember(Value = "SystemAssigned")]
        SystemAssigned
    }
    internal static class IdentityTypeEnumExtension
    {
        internal static string ToSerializedValue(this IdentityType? value)
        {
            return value == null ? null : ((IdentityType)value).ToSerializedValue();
        }
        internal static string ToSerializedValue(this IdentityType value)
        {
            switch( value )
            {
                case IdentityType.None:
                    return "None";
                case IdentityType.SystemAssigned:
                    return "SystemAssigned";
            }
            return null;
        }
        internal static IdentityType? ParseIdentityType(this string value)
        {
            switch( value )
            {
                case "None":
                    return IdentityType.None;
                case "SystemAssigned":
                    return IdentityType.SystemAssigned;
            }
            return null;
        }
    }
}