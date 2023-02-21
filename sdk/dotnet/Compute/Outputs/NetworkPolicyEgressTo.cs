// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Stackpath.Compute.Outputs
{

    [OutputType]
    public sealed class NetworkPolicyEgressTo
    {
        public readonly ImmutableArray<Outputs.NetworkPolicyEgressToInstanceSelector> InstanceSelectors;
        public readonly ImmutableArray<Outputs.NetworkPolicyEgressToIpBlock> IpBlocks;
        public readonly ImmutableArray<Outputs.NetworkPolicyEgressToNetworkSelector> NetworkSelectors;

        [OutputConstructor]
        private NetworkPolicyEgressTo(
            ImmutableArray<Outputs.NetworkPolicyEgressToInstanceSelector> instanceSelectors,

            ImmutableArray<Outputs.NetworkPolicyEgressToIpBlock> ipBlocks,

            ImmutableArray<Outputs.NetworkPolicyEgressToNetworkSelector> networkSelectors)
        {
            InstanceSelectors = instanceSelectors;
            IpBlocks = ipBlocks;
            NetworkSelectors = networkSelectors;
        }
    }
}
