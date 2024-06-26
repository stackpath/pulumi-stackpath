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

    public sealed class WorkloadInitContainerReadinessProbeGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("failureThreshold", required: true)]
        public Input<int> FailureThreshold { get; set; } = null!;

        [Input("httpGet")]
        public Input<Inputs.WorkloadInitContainerReadinessProbeHttpGetGetArgs>? HttpGet { get; set; }

        [Input("initialDelaySeconds")]
        public Input<int>? InitialDelaySeconds { get; set; }

        [Input("periodSeconds")]
        public Input<int>? PeriodSeconds { get; set; }

        [Input("successThreshold", required: true)]
        public Input<int> SuccessThreshold { get; set; } = null!;

        [Input("tcpSocket")]
        public Input<Inputs.WorkloadInitContainerReadinessProbeTcpSocketGetArgs>? TcpSocket { get; set; }

        [Input("timeoutSeconds")]
        public Input<int>? TimeoutSeconds { get; set; }

        public WorkloadInitContainerReadinessProbeGetArgs()
        {
        }
        public static new WorkloadInitContainerReadinessProbeGetArgs Empty => new WorkloadInitContainerReadinessProbeGetArgs();
    }
}
