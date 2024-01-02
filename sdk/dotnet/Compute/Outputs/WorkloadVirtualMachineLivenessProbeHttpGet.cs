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
    public sealed class WorkloadVirtualMachineLivenessProbeHttpGet
    {
        public readonly ImmutableDictionary<string, string>? HttpHeaders;
        public readonly string? Path;
        public readonly int Port;
        public readonly string? Scheme;

        [OutputConstructor]
        private WorkloadVirtualMachineLivenessProbeHttpGet(
            ImmutableDictionary<string, string>? httpHeaders,

            string? path,

            int port,

            string? scheme)
        {
            HttpHeaders = httpHeaders;
            Path = path;
            Port = port;
            Scheme = scheme;
        }
    }
}
