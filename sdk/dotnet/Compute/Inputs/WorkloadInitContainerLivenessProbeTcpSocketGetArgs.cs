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

    public sealed class WorkloadInitContainerLivenessProbeTcpSocketGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("port", required: true)]
        public Input<int> Port { get; set; } = null!;

        public WorkloadInitContainerLivenessProbeTcpSocketGetArgs()
        {
        }
        public static new WorkloadInitContainerLivenessProbeTcpSocketGetArgs Empty => new WorkloadInitContainerLivenessProbeTcpSocketGetArgs();
    }
}
