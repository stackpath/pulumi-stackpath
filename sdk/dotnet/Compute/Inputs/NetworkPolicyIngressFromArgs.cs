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

    public sealed class NetworkPolicyIngressFromArgs : global::Pulumi.ResourceArgs
    {
        [Input("instanceSelectors")]
        private InputList<Inputs.NetworkPolicyIngressFromInstanceSelectorArgs>? _instanceSelectors;
        public InputList<Inputs.NetworkPolicyIngressFromInstanceSelectorArgs> InstanceSelectors
        {
            get => _instanceSelectors ?? (_instanceSelectors = new InputList<Inputs.NetworkPolicyIngressFromInstanceSelectorArgs>());
            set => _instanceSelectors = value;
        }

        [Input("ipBlocks")]
        private InputList<Inputs.NetworkPolicyIngressFromIpBlockArgs>? _ipBlocks;
        public InputList<Inputs.NetworkPolicyIngressFromIpBlockArgs> IpBlocks
        {
            get => _ipBlocks ?? (_ipBlocks = new InputList<Inputs.NetworkPolicyIngressFromIpBlockArgs>());
            set => _ipBlocks = value;
        }

        [Input("networkSelectors")]
        private InputList<Inputs.NetworkPolicyIngressFromNetworkSelectorArgs>? _networkSelectors;
        public InputList<Inputs.NetworkPolicyIngressFromNetworkSelectorArgs> NetworkSelectors
        {
            get => _networkSelectors ?? (_networkSelectors = new InputList<Inputs.NetworkPolicyIngressFromNetworkSelectorArgs>());
            set => _networkSelectors = value;
        }

        public NetworkPolicyIngressFromArgs()
        {
        }
        public static new NetworkPolicyIngressFromArgs Empty => new NetworkPolicyIngressFromArgs();
    }
}
