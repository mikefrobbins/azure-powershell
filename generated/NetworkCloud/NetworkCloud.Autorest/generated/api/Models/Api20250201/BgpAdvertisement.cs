// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Extensions;

    /// <summary>
    /// BgpAdvertisement represents the association of IP address pools to the communities and peers.
    /// </summary>
    public partial class BgpAdvertisement :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBgpAdvertisement,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBgpAdvertisementInternal
    {

        /// <summary>Backing field for <see cref="AdvertiseToFabric" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.AdvertiseToFabric? _advertiseToFabric;

        /// <summary>
        /// The indicator of if this advertisement is also made to the network fabric associated with the Network Cloud Cluster. This
        /// field is ignored if fabricPeeringEnabled is set to False.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.AdvertiseToFabric? AdvertiseToFabric { get => this._advertiseToFabric; set => this._advertiseToFabric = value; }

        /// <summary>Backing field for <see cref="Community" /> property.</summary>
        private string[] _community;

        /// <summary>
        /// The names of the BGP communities to be associated with the announcement, utilizing a BGP community string in 1234:1234
        /// format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public string[] Community { get => this._community; set => this._community = value; }

        /// <summary>Backing field for <see cref="IPAddressPool" /> property.</summary>
        private string[] _iPAddressPool;

        /// <summary>The names of the IP address pools associated with this announcement.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public string[] IPAddressPool { get => this._iPAddressPool; set => this._iPAddressPool = value; }

        /// <summary>Backing field for <see cref="Peer" /> property.</summary>
        private string[] _peer;

        /// <summary>
        /// The names of the BGP peers to limit this advertisement to. If no values are specified, all BGP peers will receive this
        /// advertisement.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public string[] Peer { get => this._peer; set => this._peer = value; }

        /// <summary>Creates an new <see cref="BgpAdvertisement" /> instance.</summary>
        public BgpAdvertisement()
        {

        }
    }
    /// BgpAdvertisement represents the association of IP address pools to the communities and peers.
    public partial interface IBgpAdvertisement :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The indicator of if this advertisement is also made to the network fabric associated with the Network Cloud Cluster. This
        /// field is ignored if fabricPeeringEnabled is set to False.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The indicator of if this advertisement is also made to the network fabric associated with the Network Cloud Cluster. This field is ignored if fabricPeeringEnabled is set to False.",
        SerializedName = @"advertiseToFabric",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.AdvertiseToFabric) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.AdvertiseToFabric? AdvertiseToFabric { get; set; }
        /// <summary>
        /// The names of the BGP communities to be associated with the announcement, utilizing a BGP community string in 1234:1234
        /// format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The names of the BGP communities to be associated with the announcement, utilizing a BGP community string in 1234:1234 format.",
        SerializedName = @"communities",
        PossibleTypes = new [] { typeof(string) })]
        string[] Community { get; set; }
        /// <summary>The names of the IP address pools associated with this announcement.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The names of the IP address pools associated with this announcement.",
        SerializedName = @"ipAddressPools",
        PossibleTypes = new [] { typeof(string) })]
        string[] IPAddressPool { get; set; }
        /// <summary>
        /// The names of the BGP peers to limit this advertisement to. If no values are specified, all BGP peers will receive this
        /// advertisement.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The names of the BGP peers to limit this advertisement to. If no values are specified, all BGP peers will receive this advertisement.",
        SerializedName = @"peers",
        PossibleTypes = new [] { typeof(string) })]
        string[] Peer { get; set; }

    }
    /// BgpAdvertisement represents the association of IP address pools to the communities and peers.
    internal partial interface IBgpAdvertisementInternal

    {
        /// <summary>
        /// The indicator of if this advertisement is also made to the network fabric associated with the Network Cloud Cluster. This
        /// field is ignored if fabricPeeringEnabled is set to False.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.AdvertiseToFabric? AdvertiseToFabric { get; set; }
        /// <summary>
        /// The names of the BGP communities to be associated with the announcement, utilizing a BGP community string in 1234:1234
        /// format.
        /// </summary>
        string[] Community { get; set; }
        /// <summary>The names of the IP address pools associated with this announcement.</summary>
        string[] IPAddressPool { get; set; }
        /// <summary>
        /// The names of the BGP peers to limit this advertisement to. If no values are specified, all BGP peers will receive this
        /// advertisement.
        /// </summary>
        string[] Peer { get; set; }

    }
}