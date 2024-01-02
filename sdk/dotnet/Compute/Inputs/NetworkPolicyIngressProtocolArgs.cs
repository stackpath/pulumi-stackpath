// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Stackpath.Stackpath.Compute.Inputs
{

    public sealed class NetworkPolicyIngressProtocolArgs : global::Pulumi.ResourceArgs
    {
        [Input("ah")]
        public Input<Inputs.NetworkPolicyIngressProtocolAhArgs>? Ah { get; set; }

        [Input("esp")]
        public Input<Inputs.NetworkPolicyIngressProtocolEspArgs>? Esp { get; set; }

        [Input("gre")]
        public Input<Inputs.NetworkPolicyIngressProtocolGreArgs>? Gre { get; set; }

        [Input("icmp")]
        public Input<Inputs.NetworkPolicyIngressProtocolIcmpArgs>? Icmp { get; set; }

        [Input("tcp")]
        public Input<Inputs.NetworkPolicyIngressProtocolTcpArgs>? Tcp { get; set; }

        [Input("tcpUdp")]
        public Input<Inputs.NetworkPolicyIngressProtocolTcpUdpArgs>? TcpUdp { get; set; }

        [Input("udp")]
        public Input<Inputs.NetworkPolicyIngressProtocolUdpArgs>? Udp { get; set; }

        public NetworkPolicyIngressProtocolArgs()
        {
        }
        public static new NetworkPolicyIngressProtocolArgs Empty => new NetworkPolicyIngressProtocolArgs();
    }
}
