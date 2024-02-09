// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Stackpath.Compute.Inputs
{

    public sealed class NetworkPolicyEgressProtocolTcpUdpArgs : global::Pulumi.ResourceArgs
    {
        [Input("destinationPorts")]
        private InputList<string>? _destinationPorts;
        public InputList<string> DestinationPorts
        {
            get => _destinationPorts ?? (_destinationPorts = new InputList<string>());
            set => _destinationPorts = value;
        }

        [Input("sourcePorts")]
        private InputList<string>? _sourcePorts;
        public InputList<string> SourcePorts
        {
            get => _sourcePorts ?? (_sourcePorts = new InputList<string>());
            set => _sourcePorts = value;
        }

        public NetworkPolicyEgressProtocolTcpUdpArgs()
        {
        }
        public static new NetworkPolicyEgressProtocolTcpUdpArgs Empty => new NetworkPolicyEgressProtocolTcpUdpArgs();
    }
}
