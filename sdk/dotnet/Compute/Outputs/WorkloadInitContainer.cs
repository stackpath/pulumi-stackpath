// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Stackpath.Stackpath.Compute.Outputs
{

    [OutputType]
    public sealed class WorkloadInitContainer
    {
        public readonly ImmutableArray<string> Args;
        public readonly ImmutableArray<string> Commands;
        public readonly ImmutableArray<Outputs.WorkloadInitContainerEnv> Envs;
        public readonly string Image;
        public readonly Outputs.WorkloadInitContainerLivenessProbe? LivenessProbe;
        public readonly string Name;
        public readonly ImmutableArray<Outputs.WorkloadInitContainerPort> Ports;
        public readonly Outputs.WorkloadInitContainerReadinessProbe? ReadinessProbe;
        public readonly Outputs.WorkloadInitContainerResources Resources;
        public readonly Outputs.WorkloadInitContainerSecurityContext? SecurityContext;
        public readonly ImmutableArray<Outputs.WorkloadInitContainerVolumeMount> VolumeMounts;

        [OutputConstructor]
        private WorkloadInitContainer(
            ImmutableArray<string> args,

            ImmutableArray<string> commands,

            ImmutableArray<Outputs.WorkloadInitContainerEnv> envs,

            string image,

            Outputs.WorkloadInitContainerLivenessProbe? livenessProbe,

            string name,

            ImmutableArray<Outputs.WorkloadInitContainerPort> ports,

            Outputs.WorkloadInitContainerReadinessProbe? readinessProbe,

            Outputs.WorkloadInitContainerResources resources,

            Outputs.WorkloadInitContainerSecurityContext? securityContext,

            ImmutableArray<Outputs.WorkloadInitContainerVolumeMount> volumeMounts)
        {
            Args = args;
            Commands = commands;
            Envs = envs;
            Image = image;
            LivenessProbe = livenessProbe;
            Name = name;
            Ports = ports;
            ReadinessProbe = readinessProbe;
            Resources = resources;
            SecurityContext = securityContext;
            VolumeMounts = volumeMounts;
        }
    }
}
