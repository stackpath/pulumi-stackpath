// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Stackpath.Compute.Outputs
{

    [OutputType]
    public sealed class WorkloadInstanceVirtualMachineReadinessProbe
    {
        public readonly int FailureThreshold;
        public readonly Outputs.WorkloadInstanceVirtualMachineReadinessProbeHttpGet? HttpGet;
        public readonly int? InitialDelaySeconds;
        public readonly int? PeriodSeconds;
        public readonly int SuccessThreshold;
        public readonly Outputs.WorkloadInstanceVirtualMachineReadinessProbeTcpSocket? TcpSocket;
        public readonly int? TimeoutSeconds;

        [OutputConstructor]
        private WorkloadInstanceVirtualMachineReadinessProbe(
            int failureThreshold,

            Outputs.WorkloadInstanceVirtualMachineReadinessProbeHttpGet? httpGet,

            int? initialDelaySeconds,

            int? periodSeconds,

            int successThreshold,

            Outputs.WorkloadInstanceVirtualMachineReadinessProbeTcpSocket? tcpSocket,

            int? timeoutSeconds)
        {
            FailureThreshold = failureThreshold;
            HttpGet = httpGet;
            InitialDelaySeconds = initialDelaySeconds;
            PeriodSeconds = periodSeconds;
            SuccessThreshold = successThreshold;
            TcpSocket = tcpSocket;
            TimeoutSeconds = timeoutSeconds;
        }
    }
}