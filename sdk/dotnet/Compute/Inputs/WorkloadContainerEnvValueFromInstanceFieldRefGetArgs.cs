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

    public sealed class WorkloadContainerEnvValueFromInstanceFieldRefGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("fieldPath")]
        public Input<string>? FieldPath { get; set; }

        [Input("optional")]
        public Input<bool>? Optional { get; set; }

        public WorkloadContainerEnvValueFromInstanceFieldRefGetArgs()
        {
        }
        public static new WorkloadContainerEnvValueFromInstanceFieldRefGetArgs Empty => new WorkloadContainerEnvValueFromInstanceFieldRefGetArgs();
    }
}
