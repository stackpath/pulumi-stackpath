// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Stackpath.Compute.Inputs
{

    public sealed class WorkloadVirtualMachineArgs : global::Pulumi.ResourceArgs
    {
        [Input("image", required: true)]
        public Input<string> Image { get; set; } = null!;

        [Input("livenessProbe")]
        public Input<Inputs.WorkloadVirtualMachineLivenessProbeArgs>? LivenessProbe { get; set; }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("ports")]
        private InputList<Inputs.WorkloadVirtualMachinePortArgs>? _ports;
        public InputList<Inputs.WorkloadVirtualMachinePortArgs> Ports
        {
            get => _ports ?? (_ports = new InputList<Inputs.WorkloadVirtualMachinePortArgs>());
            set => _ports = value;
        }

        [Input("readinessProbe")]
        public Input<Inputs.WorkloadVirtualMachineReadinessProbeArgs>? ReadinessProbe { get; set; }

        [Input("resources", required: true)]
        public Input<Inputs.WorkloadVirtualMachineResourcesArgs> Resources { get; set; } = null!;

        [Input("userData")]
        public Input<string>? UserData { get; set; }

        [Input("volumeMounts")]
        private InputList<Inputs.WorkloadVirtualMachineVolumeMountArgs>? _volumeMounts;
        public InputList<Inputs.WorkloadVirtualMachineVolumeMountArgs> VolumeMounts
        {
            get => _volumeMounts ?? (_volumeMounts = new InputList<Inputs.WorkloadVirtualMachineVolumeMountArgs>());
            set => _volumeMounts = value;
        }

        public WorkloadVirtualMachineArgs()
        {
        }
        public static new WorkloadVirtualMachineArgs Empty => new WorkloadVirtualMachineArgs();
    }
}