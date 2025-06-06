﻿//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using Microsoft.Azure.Management.Network.Models;
using Microsoft.WindowsAzure.Commands.Common.Attributes;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Microsoft.Azure.Commands.Network.Models
{
    public partial class PSApplicationGatewayFirewallPolicyManagedRules
    {
        [Ps1Xml(Target = ViewControl.Table)]
        public List<PSApplicationGatewayFirewallPolicyManagedRuleSet> ManagedRuleSets { get; set; }

        [Ps1Xml(Target = ViewControl.Table)]
        public List<PSApplicationGatewayFirewallPolicyExclusion> Exclusions { get; set; }

        [Ps1Xml(Target = ViewControl.Table)]
        public List<PSApplicationGatewayFirewallPolicyException> Exceptions { get; set; }
    }
}
