// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Stackpath.Compute.Inputs
{

    public sealed class WorkloadContainerResourcesArgs : global::Pulumi.ResourceArgs
    {
        [Input("requests", required: true)]
        private InputMap<string>? _requests;
        public InputMap<string> Requests
        {
            get => _requests ?? (_requests = new InputMap<string>());
            set => _requests = value;
        }

        public WorkloadContainerResourcesArgs()
        {
        }
        public static new WorkloadContainerResourcesArgs Empty => new WorkloadContainerResourcesArgs();
    }
}
