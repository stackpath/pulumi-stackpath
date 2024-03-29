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

    public sealed class WorkloadVolumeClaimGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("resources", required: true)]
        public Input<Inputs.WorkloadVolumeClaimResourcesGetArgs> Resources { get; set; } = null!;

        [Input("slug")]
        public Input<string>? Slug { get; set; }

        [Input("storageClass")]
        public Input<string>? StorageClass { get; set; }

        public WorkloadVolumeClaimGetArgs()
        {
        }
        public static new WorkloadVolumeClaimGetArgs Empty => new WorkloadVolumeClaimGetArgs();
    }
}
