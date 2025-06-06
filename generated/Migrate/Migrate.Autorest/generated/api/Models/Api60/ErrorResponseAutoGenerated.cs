// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>
    /// Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows
    /// the OData error response format.).
    /// </summary>
    public partial class ErrorResponseAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IErrorResponseAutoGenerated,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IErrorResponseAutoGeneratedInternal
    {

        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20.IErrorAdditionalInfo[] AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IErrorDetailAutoGeneratedInternal)Error).AdditionalInfo; }

        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IErrorDetailAutoGeneratedInternal)Error).Code; }

        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IErrorDetailAutoGenerated[] Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IErrorDetailAutoGeneratedInternal)Error).Detail; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IErrorDetailAutoGenerated _error;

        /// <summary>The error object.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IErrorDetailAutoGenerated Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.ErrorDetailAutoGenerated()); set => this._error = value; }

        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IErrorDetailAutoGeneratedInternal)Error).Message; }

        /// <summary>Internal Acessors for AdditionalInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20.IErrorAdditionalInfo[] Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IErrorResponseAutoGeneratedInternal.AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IErrorDetailAutoGeneratedInternal)Error).AdditionalInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IErrorDetailAutoGeneratedInternal)Error).AdditionalInfo = value; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IErrorResponseAutoGeneratedInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IErrorDetailAutoGeneratedInternal)Error).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IErrorDetailAutoGeneratedInternal)Error).Code = value; }

        /// <summary>Internal Acessors for Detail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IErrorDetailAutoGenerated[] Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IErrorResponseAutoGeneratedInternal.Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IErrorDetailAutoGeneratedInternal)Error).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IErrorDetailAutoGeneratedInternal)Error).Detail = value; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IErrorDetailAutoGenerated Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IErrorResponseAutoGeneratedInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.ErrorDetailAutoGenerated()); set { {_error = value;} } }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IErrorResponseAutoGeneratedInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IErrorDetailAutoGeneratedInternal)Error).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IErrorDetailAutoGeneratedInternal)Error).Message = value; }

        /// <summary>Internal Acessors for Target</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IErrorResponseAutoGeneratedInternal.Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IErrorDetailAutoGeneratedInternal)Error).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IErrorDetailAutoGeneratedInternal)Error).Target = value; }

        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IErrorDetailAutoGeneratedInternal)Error).Target; }

        /// <summary>Creates an new <see cref="ErrorResponseAutoGenerated" /> instance.</summary>
        public ErrorResponseAutoGenerated()
        {

        }
    }
    /// Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows
    /// the OData error response format.).
    public partial interface IErrorResponseAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error additional info.",
        SerializedName = @"additionalInfo",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20.IErrorAdditionalInfo) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20.IErrorAdditionalInfo[] AdditionalInfo { get;  }
        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get;  }
        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error details.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IErrorDetailAutoGenerated) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IErrorDetailAutoGenerated[] Detail { get;  }
        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error message.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }
        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error target.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string Target { get;  }

    }
    /// Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows
    /// the OData error response format.).
    internal partial interface IErrorResponseAutoGeneratedInternal

    {
        /// <summary>The error additional info.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20.IErrorAdditionalInfo[] AdditionalInfo { get; set; }
        /// <summary>The error code.</summary>
        string Code { get; set; }
        /// <summary>The error details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IErrorDetailAutoGenerated[] Detail { get; set; }
        /// <summary>The error object.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IErrorDetailAutoGenerated Error { get; set; }
        /// <summary>The error message.</summary>
        string Message { get; set; }
        /// <summary>The error target.</summary>
        string Target { get; set; }

    }
}