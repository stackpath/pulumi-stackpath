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

    public sealed class WorkloadContainerSecurityContextCapabilitiesArgs : global::Pulumi.ResourceArgs
    {
        [Input("adds")]
        private InputList<string>? _adds;
        public InputList<string> Adds
        {
            get => _adds ?? (_adds = new InputList<string>());
            set => _adds = value;
        }

        [Input("drops")]
        private InputList<string>? _drops;
        public InputList<string> Drops
        {
            get => _drops ?? (_drops = new InputList<string>());
            set => _drops = value;
        }

        public WorkloadContainerSecurityContextCapabilitiesArgs()
        {
        }
        public static new WorkloadContainerSecurityContextCapabilitiesArgs Empty => new WorkloadContainerSecurityContextCapabilitiesArgs();
    }
}
