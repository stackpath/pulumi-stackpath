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

    public sealed class WorkloadVirtualMachineRuntimeEnvironmentGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("dns", required: true)]
        public Input<Inputs.WorkloadVirtualMachineRuntimeEnvironmentDnsGetArgs> Dns { get; set; } = null!;

        public WorkloadVirtualMachineRuntimeEnvironmentGetArgs()
        {
        }
        public static new WorkloadVirtualMachineRuntimeEnvironmentGetArgs Empty => new WorkloadVirtualMachineRuntimeEnvironmentGetArgs();
    }
}
