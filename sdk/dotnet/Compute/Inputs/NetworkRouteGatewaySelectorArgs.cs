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

    public sealed class NetworkRouteGatewaySelectorArgs : global::Pulumi.ResourceArgs
    {
        [Input("interfaceSelectors", required: true)]
        private InputList<Inputs.NetworkRouteGatewaySelectorInterfaceSelectorArgs>? _interfaceSelectors;
        public InputList<Inputs.NetworkRouteGatewaySelectorInterfaceSelectorArgs> InterfaceSelectors
        {
            get => _interfaceSelectors ?? (_interfaceSelectors = new InputList<Inputs.NetworkRouteGatewaySelectorInterfaceSelectorArgs>());
            set => _interfaceSelectors = value;
        }

        public NetworkRouteGatewaySelectorArgs()
        {
        }
        public static new NetworkRouteGatewaySelectorArgs Empty => new NetworkRouteGatewaySelectorArgs();
    }
}
