// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Extensions;

    /// <summary>An error response from the Compute service.</summary>
    public partial class CloudError :
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api10.ICloudError,
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api10.ICloudErrorInternal
    {

        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api10.IApiErrorInternal)Error).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api10.IApiErrorInternal)Error).Code = value ?? null; }

        /// <summary>The Api error details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api10.IApiErrorBase[] Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api10.IApiErrorInternal)Error).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api10.IApiErrorInternal)Error).Detail = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api10.IApiError _error;

        /// <summary>Api error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api10.IApiError Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api10.ApiError()); set => this._error = value; }

        /// <summary>The internal error message or exception dump.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Inlined)]
        public string InnererrorErrordetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api10.IApiErrorInternal)Error).InnererrorErrordetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api10.IApiErrorInternal)Error).InnererrorErrordetail = value ?? null; }

        /// <summary>The exception type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Inlined)]
        public string InnererrorExceptiontype { get => ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api10.IApiErrorInternal)Error).InnererrorExceptiontype; set => ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api10.IApiErrorInternal)Error).InnererrorExceptiontype = value ?? null; }

        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api10.IApiErrorInternal)Error).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api10.IApiErrorInternal)Error).Message = value ?? null; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api10.IApiError Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api10.ICloudErrorInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api10.ApiError()); set { {_error = value;} } }

        /// <summary>Internal Acessors for Innererror</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api10.IInnerError Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api10.ICloudErrorInternal.Innererror { get => ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api10.IApiErrorInternal)Error).Innererror; set => ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api10.IApiErrorInternal)Error).Innererror = value; }

        /// <summary>The target of the particular error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Inlined)]
        public string Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api10.IApiErrorInternal)Error).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api10.IApiErrorInternal)Error).Target = value ?? null; }

        /// <summary>Creates an new <see cref="CloudError" /> instance.</summary>
        public CloudError()
        {

        }
    }
    /// An error response from the Compute service.
    public partial interface ICloudError :
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.IJsonSerializable
    {
        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get; set; }
        /// <summary>The Api error details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Api error details",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api10.IApiErrorBase) })]
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api10.IApiErrorBase[] Detail { get; set; }
        /// <summary>The internal error message or exception dump.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The internal error message or exception dump.",
        SerializedName = @"errordetail",
        PossibleTypes = new [] { typeof(string) })]
        string InnererrorErrordetail { get; set; }
        /// <summary>The exception type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The exception type.",
        SerializedName = @"exceptiontype",
        PossibleTypes = new [] { typeof(string) })]
        string InnererrorExceptiontype { get; set; }
        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The error message.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }
        /// <summary>The target of the particular error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target of the particular error.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string Target { get; set; }

    }
    /// An error response from the Compute service.
    internal partial interface ICloudErrorInternal

    {
        /// <summary>The error code.</summary>
        string Code { get; set; }
        /// <summary>The Api error details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api10.IApiErrorBase[] Detail { get; set; }
        /// <summary>Api error.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api10.IApiError Error { get; set; }
        /// <summary>The Api inner error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api10.IInnerError Innererror { get; set; }
        /// <summary>The internal error message or exception dump.</summary>
        string InnererrorErrordetail { get; set; }
        /// <summary>The exception type.</summary>
        string InnererrorExceptiontype { get; set; }
        /// <summary>The error message.</summary>
        string Message { get; set; }
        /// <summary>The target of the particular error.</summary>
        string Target { get; set; }

    }
}