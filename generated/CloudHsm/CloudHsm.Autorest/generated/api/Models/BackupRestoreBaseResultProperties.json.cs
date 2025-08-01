// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Extensions;

    /// <summary>Backup and Restore operation common properties</summary>
    public partial class BackupRestoreBaseResultProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Json.JsonObject into a new instance of <see cref="BackupRestoreBaseResultProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal BackupRestoreBaseResultProperties(Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_error = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Json.JsonObject>("error"), out var __jsonError) ? Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Models.ErrorDetail.FromJson(__jsonError) : _error;}
            {_status = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Json.JsonString>("status"), out var __jsonStatus) ? (string)__jsonStatus : (string)_status;}
            {_statusDetail = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Json.JsonString>("statusDetails"), out var __jsonStatusDetails) ? (string)__jsonStatusDetails : (string)_statusDetail;}
            {_startTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Json.JsonString>("startTime"), out var __jsonStartTime) ? global::System.DateTime.TryParse((string)__jsonStartTime, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonStartTimeValue) ? __jsonStartTimeValue : _startTime : _startTime;}
            {_endTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Json.JsonString>("endTime"), out var __jsonEndTime) ? global::System.DateTime.TryParse((string)__jsonEndTime, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonEndTimeValue) ? __jsonEndTimeValue : _endTime : _endTime;}
            {_jobId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Json.JsonString>("jobId"), out var __jsonJobId) ? (string)__jsonJobId : (string)_jobId;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Models.IBackupRestoreBaseResultProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Models.IBackupRestoreBaseResultProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Models.IBackupRestoreBaseResultProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Json.JsonObject json ? new BackupRestoreBaseResultProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="BackupRestoreBaseResultProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="BackupRestoreBaseResultProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._error ? (Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Json.JsonNode) this._error.ToJson(null,serializationMode) : null, "error" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._status)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Json.JsonString(this._status.ToString()) : null, "status" ,container.Add );
            }
            AddIf( null != (((object)this._statusDetail)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Json.JsonString(this._statusDetail.ToString()) : null, "statusDetails" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._startTime ? (Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Json.JsonString(this._startTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "startTime" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._endTime ? (Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Json.JsonString(this._endTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "endTime" ,container.Add );
            }
            AddIf( null != (((object)this._jobId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CloudHsm.Runtime.Json.JsonString(this._jobId.ToString()) : null, "jobId" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}