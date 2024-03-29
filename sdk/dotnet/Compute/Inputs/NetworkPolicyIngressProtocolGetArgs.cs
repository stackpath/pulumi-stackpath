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

    public sealed class NetworkPolicyIngressProtocolGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("ah")]
        public Input<Inputs.NetworkPolicyIngressProtocolAhGetArgs>? Ah { get; set; }

        [Input("esp")]
        public Input<Inputs.NetworkPolicyIngressProtocolEspGetArgs>? Esp { get; set; }

        [Input("gre")]
        public Input<Inputs.NetworkPolicyIngressProtocolGreGetArgs>? Gre { get; set; }

        [Input("icmp")]
        public Input<Inputs.NetworkPolicyIngressProtocolIcmpGetArgs>? Icmp { get; set; }

        [Input("tcp")]
        public Input<Inputs.NetworkPolicyIngressProtocolTcpGetArgs>? Tcp { get; set; }

        [Input("tcpUdp")]
        public Input<Inputs.NetworkPolicyIngressProtocolTcpUdpGetArgs>? TcpUdp { get; set; }

        [Input("udp")]
        public Input<Inputs.NetworkPolicyIngressProtocolUdpGetArgs>? Udp { get; set; }

        public NetworkPolicyIngressProtocolGetArgs()
        {
        }
        public static new NetworkPolicyIngressProtocolGetArgs Empty => new NetworkPolicyIngressProtocolGetArgs();
    }
}
