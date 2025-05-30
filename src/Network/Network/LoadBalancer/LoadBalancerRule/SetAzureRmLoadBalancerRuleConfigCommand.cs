// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.Common.Exceptions;
using Microsoft.Azure.Commands.Network.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Network.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Network
{
    [Cmdlet(VerbsCommon.Set, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "LoadBalancerRuleConfig", DefaultParameterSetName = "SetByResource", SupportsShouldProcess = true), OutputType(typeof(PSLoadBalancer))]
    public partial class SetAzureRmLoadBalancerRuleConfigCommand : NetworkBaseCmdlet
    {
        [Parameter(
            Mandatory = true,
            HelpMessage = "The reference of the load balancer resource.",
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public PSLoadBalancer LoadBalancer { get; set; }

        [Parameter(
            Mandatory = true,
            HelpMessage = "Name of the load balancing rule.")]
        public string Name { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "The transport protocol for the endpoint.",
            ValueFromPipelineByPropertyName = true)]
        [PSArgumentCompleter(
            "Udp",
            "Tcp",
            "All"
        )]
        public string Protocol { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "The load distribution policy for this rule.",
            ValueFromPipelineByPropertyName = true)]
        [PSArgumentCompleter(
            "Default",
            "SourceIP",
            "SourceIPProtocol"
        )]
        public string LoadDistribution { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "The port for the external endpoint. Port numbers for each rule must be unique within the Load Balancer. Acceptable values are between 0 and 65534. Note that value 0 enables 'Any Port'",
            ValueFromPipelineByPropertyName = true)]
        public int FrontendPort { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "The port used for internal connections on the endpoint. Acceptable values are between 0 and 65535. Note that value 0 enables 'Any Port'",
            ValueFromPipelineByPropertyName = true)]
        public int BackendPort { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "The timeout for the TCP idle connection. The value can be set between 4 and 30 minutes. The default value is 4 minutes. This element is only used when the protocol is set to TCP.",
            ValueFromPipelineByPropertyName = true)]
        public int IdleTimeoutInMinutes { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "Configures a virtual machine's endpoint for the floating IP capability required to configure a SQL AlwaysOn Availability Group. This setting is required when using the SQL AlwaysOn Availability Groups in SQL server. This setting can't be changed after you create the endpoint.")]
        public SwitchParameter EnableFloatingIP { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "Receive bidirectional TCP Reset on TCP flow idle timeout or unexpected connection termination. This element is only used when the protocol is set to TCP.")]
        public SwitchParameter EnableTcpReset { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "Configures SNAT for the VMs in the backend pool to use the publicIP address specified in the frontend of the load balancing rule.")]
        public SwitchParameter DisableOutboundSNAT { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "Configures SNAT for the VMs in the backend pool to use the publicIP address specified in the frontend of the load balancing rule.")]
        public SwitchParameter EnableConnectionTracking { get; set; }

        [Parameter(
            Mandatory = false,
            ParameterSetName = "SetByResourceId",
            HelpMessage = "A reference to frontend IP addresses.",
            ValueFromPipelineByPropertyName = true)]
        public string FrontendIpConfigurationId { get; set; }

        [Parameter(
            Mandatory = false,
            ParameterSetName = "SetByResource",
            HelpMessage = "A reference to frontend IP addresses.",
            ValueFromPipelineByPropertyName = true)]
        public PSFrontendIPConfiguration FrontendIpConfiguration { get; set; }

        [Parameter(
            Mandatory = false,
            ParameterSetName = "SetByResourceId",
            HelpMessage = "A reference to a pool of DIPs. Inbound traffic is randomly load balanced across IPs in the backend IPs.",
            ValueFromPipelineByPropertyName = true)]
        public string[] BackendAddressPoolId { get; set; }

        [Parameter(
            Mandatory = false,
            ParameterSetName = "SetByResource",
            HelpMessage = "A reference to a pool of DIPs. Inbound traffic is randomly load balanced across IPs in the backend IPs.",
            ValueFromPipelineByPropertyName = true)]
        public PSBackendAddressPool[] BackendAddressPool { get; set; }

        [Parameter(
            Mandatory = false,
            ParameterSetName = "SetByResourceId",
            HelpMessage = "The reference of the load balancer probe used by the load balancing rule.",
            ValueFromPipelineByPropertyName = true)]
        public string ProbeId { get; set; }

        [Parameter(
            Mandatory = false,
            ParameterSetName = "SetByResource",
            HelpMessage = "The reference of the load balancer probe used by the load balancing rule.",
            ValueFromPipelineByPropertyName = true)]
        public PSProbe Probe { get; set; }


        public override void Execute()
        {

            var vLoadBalancingRulesIndex = this.LoadBalancer.LoadBalancingRules.IndexOf(
                this.LoadBalancer.LoadBalancingRules.SingleOrDefault(
                    resource => string.Equals(resource.Name, this.Name, System.StringComparison.CurrentCultureIgnoreCase)));
            if (vLoadBalancingRulesIndex == -1)
            {
                throw new ArgumentException("LoadBalancingRules with the specified name does not exist");
            }

            if (string.Equals(ParameterSetName, Microsoft.Azure.Commands.Network.Properties.Resources.SetByResource))
            {
                if (this.FrontendIpConfiguration != null)
                {
                    this.FrontendIpConfigurationId = this.FrontendIpConfiguration.Id;
                }

                if (this.BackendAddressPool != null && this.BackendAddressPool.Length > 0)
                {
                    this.BackendAddressPoolId = new string[this.BackendAddressPool.Length];
                    for (int i = 0; i < this.BackendAddressPool.Length; i++)
                    {
                        this.BackendAddressPoolId[i] = this.BackendAddressPool[i].Id;
                    }
                }

                if (this.Probe != null)
                {
                    this.ProbeId = this.Probe.Id;
                }
            }
            var vLoadBalancingRules = new PSLoadBalancingRule();

            vLoadBalancingRules.Protocol = this.Protocol;
            vLoadBalancingRules.LoadDistribution = this.LoadDistribution;
            vLoadBalancingRules.FrontendPort = this.FrontendPort;
            vLoadBalancingRules.BackendPort = this.BackendPort;
            vLoadBalancingRules.IdleTimeoutInMinutes = this.MyInvocation.BoundParameters.ContainsKey("IdleTimeoutInMinutes") ? this.IdleTimeoutInMinutes : 4;
            vLoadBalancingRules.EnableFloatingIP = this.EnableFloatingIP;
            vLoadBalancingRules.EnableTcpReset = this.EnableTcpReset;
            vLoadBalancingRules.DisableOutboundSNAT = this.DisableOutboundSNAT;
            vLoadBalancingRules.EnableConnectionTracking = this.EnableConnectionTracking;
            vLoadBalancingRules.Name = this.Name;
            if (!string.IsNullOrEmpty(this.FrontendIpConfigurationId))
            {
                // FrontendIPConfiguration
                if (vLoadBalancingRules.FrontendIPConfiguration == null)
                {
                    vLoadBalancingRules.FrontendIPConfiguration = new PSResourceId();
                }

                vLoadBalancingRules.FrontendIPConfiguration.Id = this.FrontendIpConfigurationId;
            }

            if (this.BackendAddressPoolId != null && this.BackendAddressPoolId.Length > 0)
            {
                if (this.BackendAddressPoolId.Length == 1)
                {
                    // BackendAddressPool
                    if (vLoadBalancingRules.BackendAddressPool == null)
                    {
                        vLoadBalancingRules.BackendAddressPool = new PSResourceId();
                    }

                    vLoadBalancingRules.BackendAddressPool.Id = this.BackendAddressPoolId[0];
                }
                else if (this.BackendAddressPoolId.Length == 2)
                {
                    // BackendAddressPools
                    if (vLoadBalancingRules.BackendAddressPools == null)
                    {
                        vLoadBalancingRules.BackendAddressPools = new List<PSResourceId>();
                    }

                    foreach (string backendAddressPoolId in this.BackendAddressPoolId)
                    {
                        vLoadBalancingRules.BackendAddressPools.Add(new PSResourceId() { Id = backendAddressPoolId });
                    }
                }
                else
                {
                    throw new AzPSArgumentException("BackendAddressPool cannot be more than 2", "BackendAddressPool");
                }
            }

            if (!string.IsNullOrEmpty(this.ProbeId))
            {
                // Probe
                if (vLoadBalancingRules.Probe == null)
                {
                    vLoadBalancingRules.Probe = new PSResourceId();
                }

                vLoadBalancingRules.Probe.Id = this.ProbeId;
            }

            this.LoadBalancer.LoadBalancingRules[vLoadBalancingRulesIndex] = vLoadBalancingRules;
            WriteObject(this.LoadBalancer, true);
        }
    }
}
