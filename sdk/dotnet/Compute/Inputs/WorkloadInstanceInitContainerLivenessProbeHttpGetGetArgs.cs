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

    public sealed class WorkloadInstanceInitContainerLivenessProbeHttpGetGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("httpHeaders")]
        private InputMap<string>? _httpHeaders;
        public InputMap<string> HttpHeaders
        {
            get => _httpHeaders ?? (_httpHeaders = new InputMap<string>());
            set => _httpHeaders = value;
        }

        [Input("path")]
        public Input<string>? Path { get; set; }

        [Input("port", required: true)]
        public Input<int> Port { get; set; } = null!;

        [Input("scheme")]
        public Input<string>? Scheme { get; set; }

        public WorkloadInstanceInitContainerLivenessProbeHttpGetGetArgs()
        {
        }
        public static new WorkloadInstanceInitContainerLivenessProbeHttpGetGetArgs Empty => new WorkloadInstanceInitContainerLivenessProbeHttpGetGetArgs();
    }
}
