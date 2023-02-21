// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Stackpath.Compute.Inputs
{

    public sealed class WorkloadInstanceArgs : global::Pulumi.ResourceArgs
    {
        [Input("containers")]
        private InputList<Inputs.WorkloadInstanceContainerArgs>? _containers;
        public InputList<Inputs.WorkloadInstanceContainerArgs> Containers
        {
            get => _containers ?? (_containers = new InputList<Inputs.WorkloadInstanceContainerArgs>());
            set => _containers = value;
        }

        [Input("externalIpAddress")]
        public Input<string>? ExternalIpAddress { get; set; }

        [Input("ipAddress")]
        public Input<string>? IpAddress { get; set; }

        [Input("location")]
        public Input<Inputs.WorkloadInstanceLocationArgs>? Location { get; set; }

        [Input("message")]
        public Input<string>? Message { get; set; }

        [Input("metadata")]
        public Input<Inputs.WorkloadInstanceMetadataArgs>? Metadata { get; set; }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("networkInterfaces")]
        private InputList<Inputs.WorkloadInstanceNetworkInterfaceArgs>? _networkInterfaces;
        public InputList<Inputs.WorkloadInstanceNetworkInterfaceArgs> NetworkInterfaces
        {
            get => _networkInterfaces ?? (_networkInterfaces = new InputList<Inputs.WorkloadInstanceNetworkInterfaceArgs>());
            set => _networkInterfaces = value;
        }

        [Input("phase")]
        public Input<string>? Phase { get; set; }

        [Input("reason")]
        public Input<string>? Reason { get; set; }

        [Input("virtualMachine")]
        public Input<Inputs.WorkloadInstanceVirtualMachineArgs>? VirtualMachine { get; set; }

        public WorkloadInstanceArgs()
        {
        }
        public static new WorkloadInstanceArgs Empty => new WorkloadInstanceArgs();
    }
}