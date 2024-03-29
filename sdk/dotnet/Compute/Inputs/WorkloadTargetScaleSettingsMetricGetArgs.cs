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

    public sealed class WorkloadTargetScaleSettingsMetricGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("averageUtilization")]
        public Input<int>? AverageUtilization { get; set; }

        [Input("averageValue")]
        public Input<string>? AverageValue { get; set; }

        [Input("metric", required: true)]
        public Input<string> Metric { get; set; } = null!;

        public WorkloadTargetScaleSettingsMetricGetArgs()
        {
        }
        public static new WorkloadTargetScaleSettingsMetricGetArgs Empty => new WorkloadTargetScaleSettingsMetricGetArgs();
    }
}
