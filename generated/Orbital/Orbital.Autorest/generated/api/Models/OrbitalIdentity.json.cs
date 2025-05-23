// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Extensions;

    public partial class OrbitalIdentity
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IOrbitalIdentity.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IOrbitalIdentity.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IOrbitalIdentity FromJson(Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonObject json ? new OrbitalIdentity(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonObject into a new instance of <see cref="OrbitalIdentity" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal OrbitalIdentity(Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_subscriptionId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonString>("subscriptionId"), out var __jsonSubscriptionId) ? (string)__jsonSubscriptionId : (string)_subscriptionId;}
            {_resourceGroupName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonString>("resourceGroupName"), out var __jsonResourceGroupName) ? (string)__jsonResourceGroupName : (string)_resourceGroupName;}
            {_spacecraftName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonString>("spacecraftName"), out var __jsonSpacecraftName) ? (string)__jsonSpacecraftName : (string)_spacecraftName;}
            {_contactName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonString>("contactName"), out var __jsonContactName) ? (string)__jsonContactName : (string)_contactName;}
            {_contactProfileName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonString>("contactProfileName"), out var __jsonContactProfileName) ? (string)__jsonContactProfileName : (string)_contactProfileName;}
            {_location = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonString>("location"), out var __jsonLocation) ? (string)__jsonLocation : (string)_location;}
            {_operationId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonString>("operationId"), out var __jsonOperationId) ? (string)__jsonOperationId : (string)_operationId;}
            {_id = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonString>("id"), out var __jsonId) ? (string)__jsonId : (string)_id;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="OrbitalIdentity" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="OrbitalIdentity" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._subscriptionId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonString(this._subscriptionId.ToString()) : null, "subscriptionId" ,container.Add );
            AddIf( null != (((object)this._resourceGroupName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonString(this._resourceGroupName.ToString()) : null, "resourceGroupName" ,container.Add );
            AddIf( null != (((object)this._spacecraftName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonString(this._spacecraftName.ToString()) : null, "spacecraftName" ,container.Add );
            AddIf( null != (((object)this._contactName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonString(this._contactName.ToString()) : null, "contactName" ,container.Add );
            AddIf( null != (((object)this._contactProfileName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonString(this._contactProfileName.ToString()) : null, "contactProfileName" ,container.Add );
            AddIf( null != (((object)this._location)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonString(this._location.ToString()) : null, "location" ,container.Add );
            AddIf( null != (((object)this._operationId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonString(this._operationId.ToString()) : null, "operationId" ,container.Add );
            AddIf( null != (((object)this._id)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonString(this._id.ToString()) : null, "id" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}