// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Stackpath.Compute.Inputs
{

    public sealed class WorkloadNetworkInterfaceGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("enableOneToOneNat")]
        public Input<bool>? EnableOneToOneNat { get; set; }

        [Input("network", required: true)]
        public Input<string> Network { get; set; } = null!;

        public WorkloadNetworkInterfaceGetArgs()
        {
        }
        public static new WorkloadNetworkInterfaceGetArgs Empty => new WorkloadNetworkInterfaceGetArgs();
    }
}
