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
    public sealed class WorkloadInstanceInitContainerSecurityContextCapabilities
    {
        public readonly ImmutableArray<string> Adds;
        public readonly ImmutableArray<string> Drops;

        [OutputConstructor]
        private WorkloadInstanceInitContainerSecurityContextCapabilities(
            ImmutableArray<string> adds,

            ImmutableArray<string> drops)
        {
            Adds = adds;
            Drops = drops;
        }
    }
}
