// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Stackpath.Compute.Outputs
{

    [OutputType]
    public sealed class WorkloadVolumeClaim
    {
        public readonly string Name;
        public readonly Outputs.WorkloadVolumeClaimResources Resources;
        public readonly string? Slug;

        [OutputConstructor]
        private WorkloadVolumeClaim(
            string name,

            Outputs.WorkloadVolumeClaimResources resources,

            string? slug)
        {
            Name = name;
            Resources = resources;
            Slug = slug;
        }
    }
}
