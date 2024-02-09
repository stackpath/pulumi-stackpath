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
    public sealed class WorkloadInstanceContainer
    {
        public readonly ImmutableArray<string> Commands;
        public readonly ImmutableArray<Outputs.WorkloadInstanceContainerEnv> Envs;
        public readonly string Image;
        public readonly Outputs.WorkloadInstanceContainerLivenessProbe? LivenessProbe;
        public readonly string Name;
        public readonly ImmutableArray<Outputs.WorkloadInstanceContainerPort> Ports;
        public readonly Outputs.WorkloadInstanceContainerReadinessProbe? ReadinessProbe;
        public readonly Outputs.WorkloadInstanceContainerResources Resources;
        public readonly Outputs.WorkloadInstanceContainerSecurityContext? SecurityContext;
        public readonly ImmutableArray<Outputs.WorkloadInstanceContainerVolumeMount> VolumeMounts;

        [OutputConstructor]
        private WorkloadInstanceContainer(
            ImmutableArray<string> commands,

            ImmutableArray<Outputs.WorkloadInstanceContainerEnv> envs,

            string image,

            Outputs.WorkloadInstanceContainerLivenessProbe? livenessProbe,

            string name,

            ImmutableArray<Outputs.WorkloadInstanceContainerPort> ports,

            Outputs.WorkloadInstanceContainerReadinessProbe? readinessProbe,

            Outputs.WorkloadInstanceContainerResources resources,

            Outputs.WorkloadInstanceContainerSecurityContext? securityContext,

            ImmutableArray<Outputs.WorkloadInstanceContainerVolumeMount> volumeMounts)
        {
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
