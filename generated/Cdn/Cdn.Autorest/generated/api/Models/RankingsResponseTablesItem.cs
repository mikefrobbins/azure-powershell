// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    public partial class RankingsResponseTablesItem :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IRankingsResponseTablesItem,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IRankingsResponseTablesItemInternal
    {

        /// <summary>Backing field for <see cref="Data" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IRankingsResponseTablesPropertiesItemsItem> _data;

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IRankingsResponseTablesPropertiesItemsItem> Data { get => this._data; set => this._data = value; }

        /// <summary>Backing field for <see cref="Ranking" /> property.</summary>
        private string _ranking;

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string Ranking { get => this._ranking; set => this._ranking = value; }

        /// <summary>Creates an new <see cref="RankingsResponseTablesItem" /> instance.</summary>
        public RankingsResponseTablesItem()
        {

        }
    }
    public partial interface IRankingsResponseTablesItem :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"data",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IRankingsResponseTablesPropertiesItemsItem) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IRankingsResponseTablesPropertiesItemsItem> Data { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"ranking",
        PossibleTypes = new [] { typeof(string) })]
        string Ranking { get; set; }

    }
    internal partial interface IRankingsResponseTablesItemInternal

    {
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IRankingsResponseTablesPropertiesItemsItem> Data { get; set; }

        string Ranking { get; set; }

    }
}