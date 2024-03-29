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

    public sealed class WorkloadTargetGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("deploymentScope")]
        public Input<string>? DeploymentScope { get; set; }

        [Input("maxReplicas")]
        public Input<int>? MaxReplicas { get; set; }

        [Input("minReplicas", required: true)]
        public Input<int> MinReplicas { get; set; } = null!;

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("scaleSettings")]
        public Input<Inputs.WorkloadTargetScaleSettingsGetArgs>? ScaleSettings { get; set; }

        [Input("selectors", required: true)]
        private InputList<Inputs.WorkloadTargetSelectorGetArgs>? _selectors;
        public InputList<Inputs.WorkloadTargetSelectorGetArgs> Selectors
        {
            get => _selectors ?? (_selectors = new InputList<Inputs.WorkloadTargetSelectorGetArgs>());
            set => _selectors = value;
        }

        public WorkloadTargetGetArgs()
        {
        }
        public static new WorkloadTargetGetArgs Empty => new WorkloadTargetGetArgs();
    }
}
