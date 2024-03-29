// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Stackpath.Stackpath.Compute.Outputs
{

    [OutputType]
    public sealed class WorkloadVirtualMachineRuntimeEnvironmentDnsHostAlias
    {
        public readonly string Address;
        public readonly ImmutableArray<string> Hostnames;

        [OutputConstructor]
        private WorkloadVirtualMachineRuntimeEnvironmentDnsHostAlias(
            string address,

            ImmutableArray<string> hostnames)
        {
            Address = address;
            Hostnames = hostnames;
        }
    }
}
