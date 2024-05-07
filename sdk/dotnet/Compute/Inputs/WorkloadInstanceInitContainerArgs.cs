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

    public sealed class WorkloadInstanceInitContainerArgs : global::Pulumi.ResourceArgs
    {
        [Input("commands")]
        private InputList<string>? _commands;
        public InputList<string> Commands
        {
            get => _commands ?? (_commands = new InputList<string>());
            set => _commands = value;
        }

        [Input("envs")]
        private InputList<Inputs.WorkloadInstanceInitContainerEnvArgs>? _envs;
        public InputList<Inputs.WorkloadInstanceInitContainerEnvArgs> Envs
        {
            get => _envs ?? (_envs = new InputList<Inputs.WorkloadInstanceInitContainerEnvArgs>());
            set => _envs = value;
        }

        [Input("image", required: true)]
        public Input<string> Image { get; set; } = null!;

        [Input("livenessProbe")]
        public Input<Inputs.WorkloadInstanceInitContainerLivenessProbeArgs>? LivenessProbe { get; set; }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("ports")]
        private InputList<Inputs.WorkloadInstanceInitContainerPortArgs>? _ports;
        public InputList<Inputs.WorkloadInstanceInitContainerPortArgs> Ports
        {
            get => _ports ?? (_ports = new InputList<Inputs.WorkloadInstanceInitContainerPortArgs>());
            set => _ports = value;
        }

        [Input("readinessProbe")]
        public Input<Inputs.WorkloadInstanceInitContainerReadinessProbeArgs>? ReadinessProbe { get; set; }

        [Input("resources", required: true)]
        public Input<Inputs.WorkloadInstanceInitContainerResourcesArgs> Resources { get; set; } = null!;

        [Input("securityContext")]
        public Input<Inputs.WorkloadInstanceInitContainerSecurityContextArgs>? SecurityContext { get; set; }

        [Input("volumeMounts")]
        private InputList<Inputs.WorkloadInstanceInitContainerVolumeMountArgs>? _volumeMounts;
        public InputList<Inputs.WorkloadInstanceInitContainerVolumeMountArgs> VolumeMounts
        {
            get => _volumeMounts ?? (_volumeMounts = new InputList<Inputs.WorkloadInstanceInitContainerVolumeMountArgs>());
            set => _volumeMounts = value;
        }

        public WorkloadInstanceInitContainerArgs()
        {
        }
        public static new WorkloadInstanceInitContainerArgs Empty => new WorkloadInstanceInitContainerArgs();
    }
}
