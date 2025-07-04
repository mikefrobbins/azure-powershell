// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace ADT.Models
{
    using static ADT.Runtime.Extensions;

    /// <summary>Set the destination endpoints for the specified flow.</summary>
    public partial class SetDestinationEndpoints :
        ADT.Models.ISetDestinationEndpoints,
        ADT.Models.ISetDestinationEndpointsInternal
    {

        /// <summary>Backing field for <see cref="Endpoint" /> property.</summary>
        private System.Collections.Generic.List<string> _endpoint;

        /// <summary>The specified flow destination endpoints.</summary>
        [ADT.Origin(ADT.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Endpoint { get => this._endpoint; set => this._endpoint = value; }

        /// <summary>Creates an new <see cref="SetDestinationEndpoints" /> instance.</summary>
        public SetDestinationEndpoints()
        {

        }
    }
    /// Set the destination endpoints for the specified flow.
    public partial interface ISetDestinationEndpoints :
        ADT.Runtime.IJsonSerializable
    {
        /// <summary>The specified flow destination endpoints.</summary>
        [ADT.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The specified flow destination endpoints.",
        SerializedName = @"endpoints",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Endpoint { get; set; }

    }
    /// Set the destination endpoints for the specified flow.
    internal partial interface ISetDestinationEndpointsInternal

    {
        /// <summary>The specified flow destination endpoints.</summary>
        System.Collections.Generic.List<string> Endpoint { get; set; }

    }
}