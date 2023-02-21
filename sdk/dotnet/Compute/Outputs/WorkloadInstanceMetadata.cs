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
    public sealed class WorkloadInstanceMetadata
    {
        public readonly ImmutableDictionary<string, object>? Annotations;
        public readonly ImmutableDictionary<string, object>? Labels;

        [OutputConstructor]
        private WorkloadInstanceMetadata(
            ImmutableDictionary<string, object>? annotations,

            ImmutableDictionary<string, object>? labels)
        {
            Annotations = annotations;
            Labels = labels;
        }
    }
}