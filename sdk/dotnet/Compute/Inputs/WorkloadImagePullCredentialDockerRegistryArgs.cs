// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Stackpath.Compute.Inputs
{

    public sealed class WorkloadImagePullCredentialDockerRegistryArgs : global::Pulumi.ResourceArgs
    {
        [Input("email")]
        public Input<string>? Email { get; set; }

        [Input("password", required: true)]
        public Input<string> Password { get; set; } = null!;

        [Input("server")]
        public Input<string>? Server { get; set; }

        [Input("username", required: true)]
        public Input<string> Username { get; set; } = null!;

        public WorkloadImagePullCredentialDockerRegistryArgs()
        {
        }
        public static new WorkloadImagePullCredentialDockerRegistryArgs Empty => new WorkloadImagePullCredentialDockerRegistryArgs();
    }
}
