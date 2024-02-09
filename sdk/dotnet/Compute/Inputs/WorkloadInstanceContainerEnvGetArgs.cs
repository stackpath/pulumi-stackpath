// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Stackpath.Compute.Inputs
{

    public sealed class WorkloadInstanceContainerEnvGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        [Input("secretValue")]
        public Input<string>? SecretValue { get; set; }

        [Input("value")]
        public Input<string>? Value { get; set; }

        public WorkloadInstanceContainerEnvGetArgs()
        {
        }
        public static new WorkloadInstanceContainerEnvGetArgs Empty => new WorkloadInstanceContainerEnvGetArgs();
    }
}
