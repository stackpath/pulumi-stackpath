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

    public sealed class WorkloadVirtualMachineRuntimeEnvironmentDnsGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("hostAliases")]
        private InputList<Inputs.WorkloadVirtualMachineRuntimeEnvironmentDnsHostAliasGetArgs>? _hostAliases;
        public InputList<Inputs.WorkloadVirtualMachineRuntimeEnvironmentDnsHostAliasGetArgs> HostAliases
        {
            get => _hostAliases ?? (_hostAliases = new InputList<Inputs.WorkloadVirtualMachineRuntimeEnvironmentDnsHostAliasGetArgs>());
            set => _hostAliases = value;
        }

        [Input("resolverConfigs")]
        private InputList<Inputs.WorkloadVirtualMachineRuntimeEnvironmentDnsResolverConfigGetArgs>? _resolverConfigs;
        public InputList<Inputs.WorkloadVirtualMachineRuntimeEnvironmentDnsResolverConfigGetArgs> ResolverConfigs
        {
            get => _resolverConfigs ?? (_resolverConfigs = new InputList<Inputs.WorkloadVirtualMachineRuntimeEnvironmentDnsResolverConfigGetArgs>());
            set => _resolverConfigs = value;
        }

        public WorkloadVirtualMachineRuntimeEnvironmentDnsGetArgs()
        {
        }
        public static new WorkloadVirtualMachineRuntimeEnvironmentDnsGetArgs Empty => new WorkloadVirtualMachineRuntimeEnvironmentDnsGetArgs();
    }
}
