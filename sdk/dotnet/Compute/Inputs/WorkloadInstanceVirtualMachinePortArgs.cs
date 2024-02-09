// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Stackpath.Compute.Inputs
{

    public sealed class WorkloadInstanceVirtualMachinePortArgs : global::Pulumi.ResourceArgs
    {
        [Input("enableImplicitNetworkPolicy")]
        public Input<bool>? EnableImplicitNetworkPolicy { get; set; }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("port", required: true)]
        public Input<int> Port { get; set; } = null!;

        [Input("protocol")]
        public Input<string>? Protocol { get; set; }

        public WorkloadInstanceVirtualMachinePortArgs()
        {
        }
        public static new WorkloadInstanceVirtualMachinePortArgs Empty => new WorkloadInstanceVirtualMachinePortArgs();
    }
}
