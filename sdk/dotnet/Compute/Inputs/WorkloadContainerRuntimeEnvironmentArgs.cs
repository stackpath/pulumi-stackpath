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

    public sealed class WorkloadContainerRuntimeEnvironmentArgs : global::Pulumi.ResourceArgs
    {
        [Input("dns", required: true)]
        public Input<Inputs.WorkloadContainerRuntimeEnvironmentDnsArgs> Dns { get; set; } = null!;

        [Input("securityContext")]
        public Input<Inputs.WorkloadContainerRuntimeEnvironmentSecurityContextArgs>? SecurityContext { get; set; }

        [Input("shareProcessNamespace")]
        public Input<bool>? ShareProcessNamespace { get; set; }

        [Input("terminationGracePeriodSeconds")]
        public Input<int>? TerminationGracePeriodSeconds { get; set; }

        public WorkloadContainerRuntimeEnvironmentArgs()
        {
        }
        public static new WorkloadContainerRuntimeEnvironmentArgs Empty => new WorkloadContainerRuntimeEnvironmentArgs();
    }
}
