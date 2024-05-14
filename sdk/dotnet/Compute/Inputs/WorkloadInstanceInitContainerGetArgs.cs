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

    public sealed class WorkloadInstanceInitContainerGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("commands")]
        private InputList<string>? _commands;
        public InputList<string> Commands
        {
            get => _commands ?? (_commands = new InputList<string>());
            set => _commands = value;
        }

        [Input("envs")]
        private InputList<Inputs.WorkloadInstanceInitContainerEnvGetArgs>? _envs;
        public InputList<Inputs.WorkloadInstanceInitContainerEnvGetArgs> Envs
        {
            get => _envs ?? (_envs = new InputList<Inputs.WorkloadInstanceInitContainerEnvGetArgs>());
            set => _envs = value;
        }

        [Input("image", required: true)]
        public Input<string> Image { get; set; } = null!;

        [Input("livenessProbe")]
        public Input<Inputs.WorkloadInstanceInitContainerLivenessProbeGetArgs>? LivenessProbe { get; set; }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("ports")]
        private InputList<Inputs.WorkloadInstanceInitContainerPortGetArgs>? _ports;
        public InputList<Inputs.WorkloadInstanceInitContainerPortGetArgs> Ports
        {
            get => _ports ?? (_ports = new InputList<Inputs.WorkloadInstanceInitContainerPortGetArgs>());
            set => _ports = value;
        }

        [Input("readinessProbe")]
        public Input<Inputs.WorkloadInstanceInitContainerReadinessProbeGetArgs>? ReadinessProbe { get; set; }

        [Input("resources", required: true)]
        public Input<Inputs.WorkloadInstanceInitContainerResourcesGetArgs> Resources { get; set; } = null!;

        [Input("securityContext")]
        public Input<Inputs.WorkloadInstanceInitContainerSecurityContextGetArgs>? SecurityContext { get; set; }

        [Input("volumeMounts")]
        private InputList<Inputs.WorkloadInstanceInitContainerVolumeMountGetArgs>? _volumeMounts;
        public InputList<Inputs.WorkloadInstanceInitContainerVolumeMountGetArgs> VolumeMounts
        {
            get => _volumeMounts ?? (_volumeMounts = new InputList<Inputs.WorkloadInstanceInitContainerVolumeMountGetArgs>());
            set => _volumeMounts = value;
        }

        public WorkloadInstanceInitContainerGetArgs()
        {
        }
        public static new WorkloadInstanceInitContainerGetArgs Empty => new WorkloadInstanceInitContainerGetArgs();
    }
}
