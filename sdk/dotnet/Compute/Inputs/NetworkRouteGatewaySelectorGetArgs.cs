// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Stackpath.Compute.Inputs
{

    public sealed class NetworkRouteGatewaySelectorGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("interfaceSelectors", required: true)]
        private InputList<Inputs.NetworkRouteGatewaySelectorInterfaceSelectorGetArgs>? _interfaceSelectors;
        public InputList<Inputs.NetworkRouteGatewaySelectorInterfaceSelectorGetArgs> InterfaceSelectors
        {
            get => _interfaceSelectors ?? (_interfaceSelectors = new InputList<Inputs.NetworkRouteGatewaySelectorInterfaceSelectorGetArgs>());
            set => _interfaceSelectors = value;
        }

        public NetworkRouteGatewaySelectorGetArgs()
        {
        }
        public static new NetworkRouteGatewaySelectorGetArgs Empty => new NetworkRouteGatewaySelectorGetArgs();
    }
}
