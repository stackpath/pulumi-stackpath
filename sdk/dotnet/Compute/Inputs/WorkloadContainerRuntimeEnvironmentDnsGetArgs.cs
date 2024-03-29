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

    public sealed class WorkloadContainerRuntimeEnvironmentDnsGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("hostAliases")]
        private InputList<Inputs.WorkloadContainerRuntimeEnvironmentDnsHostAliasGetArgs>? _hostAliases;
        public InputList<Inputs.WorkloadContainerRuntimeEnvironmentDnsHostAliasGetArgs> HostAliases
        {
            get => _hostAliases ?? (_hostAliases = new InputList<Inputs.WorkloadContainerRuntimeEnvironmentDnsHostAliasGetArgs>());
            set => _hostAliases = value;
        }

        [Input("resolverConfigs")]
        private InputList<Inputs.WorkloadContainerRuntimeEnvironmentDnsResolverConfigGetArgs>? _resolverConfigs;
        public InputList<Inputs.WorkloadContainerRuntimeEnvironmentDnsResolverConfigGetArgs> ResolverConfigs
        {
            get => _resolverConfigs ?? (_resolverConfigs = new InputList<Inputs.WorkloadContainerRuntimeEnvironmentDnsResolverConfigGetArgs>());
            set => _resolverConfigs = value;
        }

        public WorkloadContainerRuntimeEnvironmentDnsGetArgs()
        {
        }
        public static new WorkloadContainerRuntimeEnvironmentDnsGetArgs Empty => new WorkloadContainerRuntimeEnvironmentDnsGetArgs();
    }
}
