// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Stackpath.Compute.Inputs
{

    public sealed class NetworkPolicyIngressFromGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("instanceSelectors")]
        private InputList<Inputs.NetworkPolicyIngressFromInstanceSelectorGetArgs>? _instanceSelectors;
        public InputList<Inputs.NetworkPolicyIngressFromInstanceSelectorGetArgs> InstanceSelectors
        {
            get => _instanceSelectors ?? (_instanceSelectors = new InputList<Inputs.NetworkPolicyIngressFromInstanceSelectorGetArgs>());
            set => _instanceSelectors = value;
        }

        [Input("ipBlocks")]
        private InputList<Inputs.NetworkPolicyIngressFromIpBlockGetArgs>? _ipBlocks;
        public InputList<Inputs.NetworkPolicyIngressFromIpBlockGetArgs> IpBlocks
        {
            get => _ipBlocks ?? (_ipBlocks = new InputList<Inputs.NetworkPolicyIngressFromIpBlockGetArgs>());
            set => _ipBlocks = value;
        }

        [Input("networkSelectors")]
        private InputList<Inputs.NetworkPolicyIngressFromNetworkSelectorGetArgs>? _networkSelectors;
        public InputList<Inputs.NetworkPolicyIngressFromNetworkSelectorGetArgs> NetworkSelectors
        {
            get => _networkSelectors ?? (_networkSelectors = new InputList<Inputs.NetworkPolicyIngressFromNetworkSelectorGetArgs>());
            set => _networkSelectors = value;
        }

        public NetworkPolicyIngressFromGetArgs()
        {
        }
        public static new NetworkPolicyIngressFromGetArgs Empty => new NetworkPolicyIngressFromGetArgs();
    }
}
