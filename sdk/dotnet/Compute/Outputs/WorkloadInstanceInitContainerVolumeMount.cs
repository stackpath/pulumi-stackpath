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
    public sealed class WorkloadInstanceInitContainerVolumeMount
    {
        public readonly string MountPath;
        public readonly string Slug;

        [OutputConstructor]
        private WorkloadInstanceInitContainerVolumeMount(
            string mountPath,

            string slug)
        {
            MountPath = mountPath;
            Slug = slug;
        }
    }
}
