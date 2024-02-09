// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Stackpath.Stackpath.Compute.Outputs
{

    [OutputType]
    public sealed class NetworkPolicyEgressProtocolTcpUdp
    {
        public readonly ImmutableArray<string> DestinationPorts;
        public readonly ImmutableArray<string> SourcePorts;

        [OutputConstructor]
        private NetworkPolicyEgressProtocolTcpUdp(
            ImmutableArray<string> destinationPorts,

            ImmutableArray<string> sourcePorts)
        {
            DestinationPorts = destinationPorts;
            SourcePorts = sourcePorts;
        }
    }
}
