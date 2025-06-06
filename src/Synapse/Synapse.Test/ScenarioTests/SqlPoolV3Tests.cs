﻿// ----------------------------------------------------------------------------------
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

namespace Microsoft.Azure.Commands.Synapse.Test.ScenarioTests
{
    using Microsoft.WindowsAzure.Commands.ScenarioTest;
    using Xunit;

    public class SqlPoolV3Tests : SynapseTestRunner
    {
        public SqlPoolV3Tests(Xunit.Abstractions.ITestOutputHelper output) : base(output)
        {
        }

        [Fact(Skip = "Occur InternalServerError from backend, test temporarily skip.")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestSynapseSqlPoolV3()
        {
            TestRunner.RunTestScript("Test-SynapseSqlPoolV3");
        }
    }
}
