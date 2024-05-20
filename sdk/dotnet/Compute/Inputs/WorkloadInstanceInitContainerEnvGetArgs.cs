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

    public sealed class WorkloadInstanceInitContainerEnvGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        [Input("secretValue")]
        private Input<string>? _secretValue;
        public Input<string>? SecretValue
        {
            get => _secretValue;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _secretValue = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        [Input("value")]
        public Input<string>? Value { get; set; }

        [Input("valueFrom")]
        public Input<Inputs.WorkloadInstanceInitContainerEnvValueFromGetArgs>? ValueFrom { get; set; }

        public WorkloadInstanceInitContainerEnvGetArgs()
        {
        }
        public static new WorkloadInstanceInitContainerEnvGetArgs Empty => new WorkloadInstanceInitContainerEnvGetArgs();
    }
}
