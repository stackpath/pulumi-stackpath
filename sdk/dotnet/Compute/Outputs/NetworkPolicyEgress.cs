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
    public sealed class NetworkPolicyEgress
    {
        public readonly string Action;
        public readonly string? Description;
        public readonly Outputs.NetworkPolicyEgressProtocol? Protocol;
        public readonly Outputs.NetworkPolicyEgressTo? To;

        [OutputConstructor]
        private NetworkPolicyEgress(
            string action,

            string? description,

            Outputs.NetworkPolicyEgressProtocol? protocol,

            Outputs.NetworkPolicyEgressTo? to)
        {
            Action = action;
            Description = description;
            Protocol = protocol;
            To = to;
        }
    }
}
