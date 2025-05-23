// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ApiManagement.Models
{

    /// <summary>
    /// Defines values for ExportFormat.
    /// </summary>


    public static class ExportFormat
    {
        /// <summary>
        /// Export the Api Definition in OpenAPI 2.0 Specification as JSON document to
        /// the Storage Blob.
        /// </summary>
        public const string Swagger = "swagger-link";
        /// <summary>
        /// Export the Api Definition in WSDL Schema to Storage Blob. This is only
        /// supported for APIs of Type `soap`
        /// </summary>
        public const string Wsdl = "wsdl-link";
        /// <summary>
        /// Export the Api Definition in WADL Schema to Storage Blob.
        /// </summary>
        public const string Wadl = "wadl-link";
        /// <summary>
        /// Export the Api Definition in OpenAPI 3.0 Specification as YAML document to
        /// Storage Blob.
        /// </summary>
        public const string Openapi = "openapi-link";
        /// <summary>
        /// Export the Api Definition in OpenAPI 3.0 Specification as JSON document to
        /// Storage Blob.
        /// </summary>
        public const string OpenapiJson = "openapi+json-link";
    }
}