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

    public sealed class WorkloadInitContainerResourcesGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("requests", required: true)]
        private InputMap<string>? _requests;
        public InputMap<string> Requests
        {
            get => _requests ?? (_requests = new InputMap<string>());
            set => _requests = value;
        }

        public WorkloadInitContainerResourcesGetArgs()
        {
        }
        public static new WorkloadInitContainerResourcesGetArgs Empty => new WorkloadInitContainerResourcesGetArgs();
    }
}
