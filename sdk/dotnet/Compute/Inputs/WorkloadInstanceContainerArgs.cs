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

    public sealed class WorkloadInstanceContainerArgs : global::Pulumi.ResourceArgs
    {
        [Input("args")]
        private InputList<string>? _args;
        public InputList<string> Args
        {
            get => _args ?? (_args = new InputList<string>());
            set => _args = value;
        }

        [Input("commands")]
        private InputList<string>? _commands;
        public InputList<string> Commands
        {
            get => _commands ?? (_commands = new InputList<string>());
            set => _commands = value;
        }

        [Input("envs")]
        private InputList<Inputs.WorkloadInstanceContainerEnvArgs>? _envs;
        public InputList<Inputs.WorkloadInstanceContainerEnvArgs> Envs
        {
            get => _envs ?? (_envs = new InputList<Inputs.WorkloadInstanceContainerEnvArgs>());
            set => _envs = value;
        }

        [Input("image", required: true)]
        public Input<string> Image { get; set; } = null!;

        [Input("livenessProbe")]
        public Input<Inputs.WorkloadInstanceContainerLivenessProbeArgs>? LivenessProbe { get; set; }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("ports")]
        private InputList<Inputs.WorkloadInstanceContainerPortArgs>? _ports;
        public InputList<Inputs.WorkloadInstanceContainerPortArgs> Ports
        {
            get => _ports ?? (_ports = new InputList<Inputs.WorkloadInstanceContainerPortArgs>());
            set => _ports = value;
        }

        [Input("readinessProbe")]
        public Input<Inputs.WorkloadInstanceContainerReadinessProbeArgs>? ReadinessProbe { get; set; }

        [Input("resources", required: true)]
        public Input<Inputs.WorkloadInstanceContainerResourcesArgs> Resources { get; set; } = null!;

        [Input("securityContext")]
        public Input<Inputs.WorkloadInstanceContainerSecurityContextArgs>? SecurityContext { get; set; }

        [Input("volumeMounts")]
        private InputList<Inputs.WorkloadInstanceContainerVolumeMountArgs>? _volumeMounts;
        public InputList<Inputs.WorkloadInstanceContainerVolumeMountArgs> VolumeMounts
        {
            get => _volumeMounts ?? (_volumeMounts = new InputList<Inputs.WorkloadInstanceContainerVolumeMountArgs>());
            set => _volumeMounts = value;
        }

        public WorkloadInstanceContainerArgs()
        {
        }
        public static new WorkloadInstanceContainerArgs Empty => new WorkloadInstanceContainerArgs();
    }
}
