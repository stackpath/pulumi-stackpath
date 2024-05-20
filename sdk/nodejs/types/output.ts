// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";

export namespace compute {
    export interface NetworkPolicyEgress {
        action: string;
        description?: string;
        protocol?: outputs.compute.NetworkPolicyEgressProtocol;
        to?: outputs.compute.NetworkPolicyEgressTo;
    }

    export interface NetworkPolicyEgressProtocol {
        ah?: outputs.compute.NetworkPolicyEgressProtocolAh;
        esp?: outputs.compute.NetworkPolicyEgressProtocolEsp;
        gre?: outputs.compute.NetworkPolicyEgressProtocolGre;
        icmp?: outputs.compute.NetworkPolicyEgressProtocolIcmp;
        tcp?: outputs.compute.NetworkPolicyEgressProtocolTcp;
        tcpUdp?: outputs.compute.NetworkPolicyEgressProtocolTcpUdp;
        udp?: outputs.compute.NetworkPolicyEgressProtocolUdp;
    }

    export interface NetworkPolicyEgressProtocolAh {
    }

    export interface NetworkPolicyEgressProtocolEsp {
    }

    export interface NetworkPolicyEgressProtocolGre {
    }

    export interface NetworkPolicyEgressProtocolIcmp {
    }

    export interface NetworkPolicyEgressProtocolTcp {
        destinationPorts?: string[];
        sourcePorts?: string[];
    }

    export interface NetworkPolicyEgressProtocolTcpUdp {
        destinationPorts?: string[];
        sourcePorts?: string[];
    }

    export interface NetworkPolicyEgressProtocolUdp {
        destinationPorts?: string[];
        sourcePorts?: string[];
    }

    export interface NetworkPolicyEgressTo {
        instanceSelectors?: outputs.compute.NetworkPolicyEgressToInstanceSelector[];
        ipBlocks?: outputs.compute.NetworkPolicyEgressToIpBlock[];
        networkSelectors?: outputs.compute.NetworkPolicyEgressToNetworkSelector[];
    }

    export interface NetworkPolicyEgressToInstanceSelector {
        key: string;
        operator: string;
        values: string[];
    }

    export interface NetworkPolicyEgressToIpBlock {
        cidr: string;
        excepts?: string[];
    }

    export interface NetworkPolicyEgressToNetworkSelector {
        key: string;
        operator: string;
        values: string[];
    }

    export interface NetworkPolicyIngress {
        action: string;
        description?: string;
        from?: outputs.compute.NetworkPolicyIngressFrom;
        protocol?: outputs.compute.NetworkPolicyIngressProtocol;
    }

    export interface NetworkPolicyIngressFrom {
        instanceSelectors?: outputs.compute.NetworkPolicyIngressFromInstanceSelector[];
        ipBlocks?: outputs.compute.NetworkPolicyIngressFromIpBlock[];
        networkSelectors?: outputs.compute.NetworkPolicyIngressFromNetworkSelector[];
    }

    export interface NetworkPolicyIngressFromInstanceSelector {
        key: string;
        operator: string;
        values: string[];
    }

    export interface NetworkPolicyIngressFromIpBlock {
        cidr: string;
        excepts?: string[];
    }

    export interface NetworkPolicyIngressFromNetworkSelector {
        key: string;
        operator: string;
        values: string[];
    }

    export interface NetworkPolicyIngressProtocol {
        ah?: outputs.compute.NetworkPolicyIngressProtocolAh;
        esp?: outputs.compute.NetworkPolicyIngressProtocolEsp;
        gre?: outputs.compute.NetworkPolicyIngressProtocolGre;
        icmp?: outputs.compute.NetworkPolicyIngressProtocolIcmp;
        tcp?: outputs.compute.NetworkPolicyIngressProtocolTcp;
        tcpUdp?: outputs.compute.NetworkPolicyIngressProtocolTcpUdp;
        udp?: outputs.compute.NetworkPolicyIngressProtocolUdp;
    }

    export interface NetworkPolicyIngressProtocolAh {
    }

    export interface NetworkPolicyIngressProtocolEsp {
    }

    export interface NetworkPolicyIngressProtocolGre {
    }

    export interface NetworkPolicyIngressProtocolIcmp {
    }

    export interface NetworkPolicyIngressProtocolTcp {
        destinationPorts?: string[];
        sourcePorts?: string[];
    }

    export interface NetworkPolicyIngressProtocolTcpUdp {
        destinationPorts?: string[];
        sourcePorts?: string[];
    }

    export interface NetworkPolicyIngressProtocolUdp {
        destinationPorts?: string[];
        sourcePorts?: string[];
    }

    export interface NetworkPolicyInstanceSelector {
        key: string;
        operator: string;
        values: string[];
    }

    export interface NetworkPolicyNetworkSelector {
        key: string;
        operator: string;
        values: string[];
    }

    export interface NetworkRouteGatewaySelector {
        interfaceSelectors: outputs.compute.NetworkRouteGatewaySelectorInterfaceSelector[];
    }

    export interface NetworkRouteGatewaySelectorInterfaceSelector {
        key: string;
        operator: string;
        values: string[];
    }

    export interface WorkloadContainer {
        args?: string[];
        commands?: string[];
        envs?: outputs.compute.WorkloadContainerEnv[];
        image: string;
        livenessProbe?: outputs.compute.WorkloadContainerLivenessProbe;
        name: string;
        ports?: outputs.compute.WorkloadContainerPort[];
        readinessProbe?: outputs.compute.WorkloadContainerReadinessProbe;
        resources: outputs.compute.WorkloadContainerResources;
        securityContext?: outputs.compute.WorkloadContainerSecurityContext;
        volumeMounts?: outputs.compute.WorkloadContainerVolumeMount[];
    }

    export interface WorkloadContainerEnv {
        key: string;
        secretValue?: string;
        value?: string;
        valueFrom?: outputs.compute.WorkloadContainerEnvValueFrom;
    }

    export interface WorkloadContainerEnvValueFrom {
        instanceFieldRef?: outputs.compute.WorkloadContainerEnvValueFromInstanceFieldRef;
    }

    export interface WorkloadContainerEnvValueFromInstanceFieldRef {
        fieldPath?: string;
        optional?: boolean;
    }

    export interface WorkloadContainerLivenessProbe {
        failureThreshold: number;
        httpGet?: outputs.compute.WorkloadContainerLivenessProbeHttpGet;
        initialDelaySeconds?: number;
        periodSeconds?: number;
        successThreshold: number;
        tcpSocket?: outputs.compute.WorkloadContainerLivenessProbeTcpSocket;
        timeoutSeconds?: number;
    }

    export interface WorkloadContainerLivenessProbeHttpGet {
        httpHeaders?: {[key: string]: string};
        path?: string;
        port: number;
        scheme?: string;
    }

    export interface WorkloadContainerLivenessProbeTcpSocket {
        port: number;
    }

    export interface WorkloadContainerPort {
        enableImplicitNetworkPolicy?: boolean;
        name: string;
        port: number;
        protocol?: string;
    }

    export interface WorkloadContainerReadinessProbe {
        failureThreshold: number;
        httpGet?: outputs.compute.WorkloadContainerReadinessProbeHttpGet;
        initialDelaySeconds?: number;
        periodSeconds?: number;
        successThreshold: number;
        tcpSocket?: outputs.compute.WorkloadContainerReadinessProbeTcpSocket;
        timeoutSeconds?: number;
    }

    export interface WorkloadContainerReadinessProbeHttpGet {
        httpHeaders?: {[key: string]: string};
        path?: string;
        port: number;
        scheme?: string;
    }

    export interface WorkloadContainerReadinessProbeTcpSocket {
        port: number;
    }

    export interface WorkloadContainerResources {
        requests: {[key: string]: string};
    }

    export interface WorkloadContainerRuntimeEnvironment {
        dns: outputs.compute.WorkloadContainerRuntimeEnvironmentDns;
        securityContext?: outputs.compute.WorkloadContainerRuntimeEnvironmentSecurityContext;
        shareProcessNamespace?: boolean;
        terminationGracePeriodSeconds?: number;
    }

    export interface WorkloadContainerRuntimeEnvironmentDns {
        hostAliases?: outputs.compute.WorkloadContainerRuntimeEnvironmentDnsHostAlias[];
        resolverConfigs?: outputs.compute.WorkloadContainerRuntimeEnvironmentDnsResolverConfig[];
    }

    export interface WorkloadContainerRuntimeEnvironmentDnsHostAlias {
        address: string;
        hostnames: string[];
    }

    export interface WorkloadContainerRuntimeEnvironmentDnsResolverConfig {
        nameservers?: string[];
        options?: {[key: string]: any};
        searches?: string[];
    }

    export interface WorkloadContainerRuntimeEnvironmentSecurityContext {
        runAsGroup?: string;
        runAsNonRoot?: boolean;
        runAsUser?: string;
        supplementalGroups?: string[];
        sysctl?: {[key: string]: string};
    }

    export interface WorkloadContainerSecurityContext {
        allowPrivilegeEscalation?: boolean;
        capabilities?: outputs.compute.WorkloadContainerSecurityContextCapabilities;
        readOnlyRootFilesystem?: boolean;
        runAsGroup?: string;
        runAsNonRoot?: boolean;
        runAsUser?: string;
    }

    export interface WorkloadContainerSecurityContextCapabilities {
        adds?: string[];
        drops?: string[];
    }

    export interface WorkloadContainerVolumeMount {
        mountPath: string;
        slug: string;
    }

    export interface WorkloadImagePullCredential {
        dockerRegistry: outputs.compute.WorkloadImagePullCredentialDockerRegistry;
    }

    export interface WorkloadImagePullCredentialDockerRegistry {
        email?: string;
        password: string;
        server?: string;
        username: string;
    }

    export interface WorkloadInitContainer {
        args?: string[];
        commands?: string[];
        envs?: outputs.compute.WorkloadInitContainerEnv[];
        image: string;
        livenessProbe?: outputs.compute.WorkloadInitContainerLivenessProbe;
        name: string;
        ports?: outputs.compute.WorkloadInitContainerPort[];
        readinessProbe?: outputs.compute.WorkloadInitContainerReadinessProbe;
        resources: outputs.compute.WorkloadInitContainerResources;
        securityContext?: outputs.compute.WorkloadInitContainerSecurityContext;
        volumeMounts?: outputs.compute.WorkloadInitContainerVolumeMount[];
    }

    export interface WorkloadInitContainerEnv {
        key: string;
        secretValue?: string;
        value?: string;
        valueFrom?: outputs.compute.WorkloadInitContainerEnvValueFrom;
    }

    export interface WorkloadInitContainerEnvValueFrom {
        instanceFieldRef?: outputs.compute.WorkloadInitContainerEnvValueFromInstanceFieldRef;
    }

    export interface WorkloadInitContainerEnvValueFromInstanceFieldRef {
        fieldPath?: string;
        optional?: boolean;
    }

    export interface WorkloadInitContainerLivenessProbe {
        failureThreshold: number;
        httpGet?: outputs.compute.WorkloadInitContainerLivenessProbeHttpGet;
        initialDelaySeconds?: number;
        periodSeconds?: number;
        successThreshold: number;
        tcpSocket?: outputs.compute.WorkloadInitContainerLivenessProbeTcpSocket;
        timeoutSeconds?: number;
    }

    export interface WorkloadInitContainerLivenessProbeHttpGet {
        httpHeaders?: {[key: string]: string};
        path?: string;
        port: number;
        scheme?: string;
    }

    export interface WorkloadInitContainerLivenessProbeTcpSocket {
        port: number;
    }

    export interface WorkloadInitContainerPort {
        enableImplicitNetworkPolicy?: boolean;
        name: string;
        port: number;
        protocol?: string;
    }

    export interface WorkloadInitContainerReadinessProbe {
        failureThreshold: number;
        httpGet?: outputs.compute.WorkloadInitContainerReadinessProbeHttpGet;
        initialDelaySeconds?: number;
        periodSeconds?: number;
        successThreshold: number;
        tcpSocket?: outputs.compute.WorkloadInitContainerReadinessProbeTcpSocket;
        timeoutSeconds?: number;
    }

    export interface WorkloadInitContainerReadinessProbeHttpGet {
        httpHeaders?: {[key: string]: string};
        path?: string;
        port: number;
        scheme?: string;
    }

    export interface WorkloadInitContainerReadinessProbeTcpSocket {
        port: number;
    }

    export interface WorkloadInitContainerResources {
        requests: {[key: string]: string};
    }

    export interface WorkloadInitContainerSecurityContext {
        allowPrivilegeEscalation?: boolean;
        capabilities?: outputs.compute.WorkloadInitContainerSecurityContextCapabilities;
        readOnlyRootFilesystem?: boolean;
        runAsGroup?: string;
        runAsNonRoot?: boolean;
        runAsUser?: string;
    }

    export interface WorkloadInitContainerSecurityContextCapabilities {
        adds?: string[];
        drops?: string[];
    }

    export interface WorkloadInitContainerVolumeMount {
        mountPath: string;
        slug: string;
    }

    export interface WorkloadInstance {
        containers?: outputs.compute.WorkloadInstanceContainer[];
        externalIpAddress?: string;
        externalIpv6Address?: string;
        initContainers?: outputs.compute.WorkloadInstanceInitContainer[];
        ipAddress?: string;
        ipv6Address?: string;
        location?: outputs.compute.WorkloadInstanceLocation;
        message?: string;
        metadata?: outputs.compute.WorkloadInstanceMetadata;
        name: string;
        networkInterfaces?: outputs.compute.WorkloadInstanceNetworkInterface[];
        phase?: string;
        reason?: string;
        virtualMachine?: outputs.compute.WorkloadInstanceVirtualMachine;
    }

    export interface WorkloadInstanceContainer {
        args?: string[];
        commands?: string[];
        envs?: outputs.compute.WorkloadInstanceContainerEnv[];
        image: string;
        livenessProbe?: outputs.compute.WorkloadInstanceContainerLivenessProbe;
        name: string;
        ports?: outputs.compute.WorkloadInstanceContainerPort[];
        readinessProbe?: outputs.compute.WorkloadInstanceContainerReadinessProbe;
        resources: outputs.compute.WorkloadInstanceContainerResources;
        securityContext?: outputs.compute.WorkloadInstanceContainerSecurityContext;
        volumeMounts?: outputs.compute.WorkloadInstanceContainerVolumeMount[];
    }

    export interface WorkloadInstanceContainerEnv {
        key: string;
        secretValue?: string;
        value?: string;
        valueFrom?: outputs.compute.WorkloadInstanceContainerEnvValueFrom;
    }

    export interface WorkloadInstanceContainerEnvValueFrom {
        instanceFieldRef?: outputs.compute.WorkloadInstanceContainerEnvValueFromInstanceFieldRef;
    }

    export interface WorkloadInstanceContainerEnvValueFromInstanceFieldRef {
        fieldPath?: string;
        optional?: boolean;
    }

    export interface WorkloadInstanceContainerLivenessProbe {
        failureThreshold: number;
        httpGet?: outputs.compute.WorkloadInstanceContainerLivenessProbeHttpGet;
        initialDelaySeconds?: number;
        periodSeconds?: number;
        successThreshold: number;
        tcpSocket?: outputs.compute.WorkloadInstanceContainerLivenessProbeTcpSocket;
        timeoutSeconds?: number;
    }

    export interface WorkloadInstanceContainerLivenessProbeHttpGet {
        httpHeaders?: {[key: string]: string};
        path?: string;
        port: number;
        scheme?: string;
    }

    export interface WorkloadInstanceContainerLivenessProbeTcpSocket {
        port: number;
    }

    export interface WorkloadInstanceContainerPort {
        enableImplicitNetworkPolicy?: boolean;
        name: string;
        port: number;
        protocol?: string;
    }

    export interface WorkloadInstanceContainerReadinessProbe {
        failureThreshold: number;
        httpGet?: outputs.compute.WorkloadInstanceContainerReadinessProbeHttpGet;
        initialDelaySeconds?: number;
        periodSeconds?: number;
        successThreshold: number;
        tcpSocket?: outputs.compute.WorkloadInstanceContainerReadinessProbeTcpSocket;
        timeoutSeconds?: number;
    }

    export interface WorkloadInstanceContainerReadinessProbeHttpGet {
        httpHeaders?: {[key: string]: string};
        path?: string;
        port: number;
        scheme?: string;
    }

    export interface WorkloadInstanceContainerReadinessProbeTcpSocket {
        port: number;
    }

    export interface WorkloadInstanceContainerResources {
        requests: {[key: string]: string};
    }

    export interface WorkloadInstanceContainerSecurityContext {
        allowPrivilegeEscalation?: boolean;
        capabilities?: outputs.compute.WorkloadInstanceContainerSecurityContextCapabilities;
        readOnlyRootFilesystem?: boolean;
        runAsGroup?: string;
        runAsNonRoot?: boolean;
        runAsUser?: string;
    }

    export interface WorkloadInstanceContainerSecurityContextCapabilities {
        adds?: string[];
        drops?: string[];
    }

    export interface WorkloadInstanceContainerVolumeMount {
        mountPath: string;
        slug: string;
    }

    export interface WorkloadInstanceInitContainer {
        args?: string[];
        commands?: string[];
        envs?: outputs.compute.WorkloadInstanceInitContainerEnv[];
        image: string;
        livenessProbe?: outputs.compute.WorkloadInstanceInitContainerLivenessProbe;
        name: string;
        ports?: outputs.compute.WorkloadInstanceInitContainerPort[];
        readinessProbe?: outputs.compute.WorkloadInstanceInitContainerReadinessProbe;
        resources: outputs.compute.WorkloadInstanceInitContainerResources;
        securityContext?: outputs.compute.WorkloadInstanceInitContainerSecurityContext;
        volumeMounts?: outputs.compute.WorkloadInstanceInitContainerVolumeMount[];
    }

    export interface WorkloadInstanceInitContainerEnv {
        key: string;
        secretValue?: string;
        value?: string;
        valueFrom?: outputs.compute.WorkloadInstanceInitContainerEnvValueFrom;
    }

    export interface WorkloadInstanceInitContainerEnvValueFrom {
        instanceFieldRef?: outputs.compute.WorkloadInstanceInitContainerEnvValueFromInstanceFieldRef;
    }

    export interface WorkloadInstanceInitContainerEnvValueFromInstanceFieldRef {
        fieldPath?: string;
        optional?: boolean;
    }

    export interface WorkloadInstanceInitContainerLivenessProbe {
        failureThreshold: number;
        httpGet?: outputs.compute.WorkloadInstanceInitContainerLivenessProbeHttpGet;
        initialDelaySeconds?: number;
        periodSeconds?: number;
        successThreshold: number;
        tcpSocket?: outputs.compute.WorkloadInstanceInitContainerLivenessProbeTcpSocket;
        timeoutSeconds?: number;
    }

    export interface WorkloadInstanceInitContainerLivenessProbeHttpGet {
        httpHeaders?: {[key: string]: string};
        path?: string;
        port: number;
        scheme?: string;
    }

    export interface WorkloadInstanceInitContainerLivenessProbeTcpSocket {
        port: number;
    }

    export interface WorkloadInstanceInitContainerPort {
        enableImplicitNetworkPolicy?: boolean;
        name: string;
        port: number;
        protocol?: string;
    }

    export interface WorkloadInstanceInitContainerReadinessProbe {
        failureThreshold: number;
        httpGet?: outputs.compute.WorkloadInstanceInitContainerReadinessProbeHttpGet;
        initialDelaySeconds?: number;
        periodSeconds?: number;
        successThreshold: number;
        tcpSocket?: outputs.compute.WorkloadInstanceInitContainerReadinessProbeTcpSocket;
        timeoutSeconds?: number;
    }

    export interface WorkloadInstanceInitContainerReadinessProbeHttpGet {
        httpHeaders?: {[key: string]: string};
        path?: string;
        port: number;
        scheme?: string;
    }

    export interface WorkloadInstanceInitContainerReadinessProbeTcpSocket {
        port: number;
    }

    export interface WorkloadInstanceInitContainerResources {
        requests: {[key: string]: string};
    }

    export interface WorkloadInstanceInitContainerSecurityContext {
        allowPrivilegeEscalation?: boolean;
        capabilities?: outputs.compute.WorkloadInstanceInitContainerSecurityContextCapabilities;
        readOnlyRootFilesystem?: boolean;
        runAsGroup?: string;
        runAsNonRoot?: boolean;
        runAsUser?: string;
    }

    export interface WorkloadInstanceInitContainerSecurityContextCapabilities {
        adds?: string[];
        drops?: string[];
    }

    export interface WorkloadInstanceInitContainerVolumeMount {
        mountPath: string;
        slug: string;
    }

    export interface WorkloadInstanceLocation {
        city?: string;
        cityCode?: string;
        continent?: string;
        continentCode?: string;
        country?: string;
        countryCode?: string;
        latitude?: number;
        longitude?: number;
        name?: string;
        region?: string;
        regionCode?: string;
        subdivision?: string;
        subdivisionCode?: string;
    }

    export interface WorkloadInstanceMetadata {
        annotations?: {[key: string]: any};
        labels?: {[key: string]: any};
    }

    export interface WorkloadInstanceNetworkInterface {
        gateway: string;
        ipAddress: string;
        ipAddressAliases?: string[];
        ipv6Address: string;
        ipv6AddressAliases?: string[];
        ipv6Gateway: string;
        network: string;
    }

    export interface WorkloadInstanceVirtualMachine {
        image: string;
        livenessProbe?: outputs.compute.WorkloadInstanceVirtualMachineLivenessProbe;
        name: string;
        ports?: outputs.compute.WorkloadInstanceVirtualMachinePort[];
        readinessProbe?: outputs.compute.WorkloadInstanceVirtualMachineReadinessProbe;
        resources: outputs.compute.WorkloadInstanceVirtualMachineResources;
        userData?: string;
        volumeMounts?: outputs.compute.WorkloadInstanceVirtualMachineVolumeMount[];
    }

    export interface WorkloadInstanceVirtualMachineLivenessProbe {
        failureThreshold: number;
        httpGet?: outputs.compute.WorkloadInstanceVirtualMachineLivenessProbeHttpGet;
        initialDelaySeconds?: number;
        periodSeconds?: number;
        successThreshold: number;
        tcpSocket?: outputs.compute.WorkloadInstanceVirtualMachineLivenessProbeTcpSocket;
        timeoutSeconds?: number;
    }

    export interface WorkloadInstanceVirtualMachineLivenessProbeHttpGet {
        httpHeaders?: {[key: string]: string};
        path?: string;
        port: number;
        scheme?: string;
    }

    export interface WorkloadInstanceVirtualMachineLivenessProbeTcpSocket {
        port: number;
    }

    export interface WorkloadInstanceVirtualMachinePort {
        enableImplicitNetworkPolicy?: boolean;
        name: string;
        port: number;
        protocol?: string;
    }

    export interface WorkloadInstanceVirtualMachineReadinessProbe {
        failureThreshold: number;
        httpGet?: outputs.compute.WorkloadInstanceVirtualMachineReadinessProbeHttpGet;
        initialDelaySeconds?: number;
        periodSeconds?: number;
        successThreshold: number;
        tcpSocket?: outputs.compute.WorkloadInstanceVirtualMachineReadinessProbeTcpSocket;
        timeoutSeconds?: number;
    }

    export interface WorkloadInstanceVirtualMachineReadinessProbeHttpGet {
        httpHeaders?: {[key: string]: string};
        path?: string;
        port: number;
        scheme?: string;
    }

    export interface WorkloadInstanceVirtualMachineReadinessProbeTcpSocket {
        port: number;
    }

    export interface WorkloadInstanceVirtualMachineResources {
        requests: {[key: string]: string};
    }

    export interface WorkloadInstanceVirtualMachineVolumeMount {
        mountPath: string;
        slug: string;
    }

    export interface WorkloadNetworkInterface {
        enableOneToOneNat?: boolean;
        ipFamilies: string[];
        ipv6Subnet?: string;
        network: string;
        subnet?: string;
    }

    export interface WorkloadTarget {
        deploymentScope?: string;
        maxReplicas?: number;
        minReplicas: number;
        name: string;
        scaleSettings?: outputs.compute.WorkloadTargetScaleSettings;
        selectors: outputs.compute.WorkloadTargetSelector[];
    }

    export interface WorkloadTargetScaleSettings {
        metrics: outputs.compute.WorkloadTargetScaleSettingsMetric[];
    }

    export interface WorkloadTargetScaleSettingsMetric {
        averageUtilization?: number;
        averageValue?: string;
        metric: string;
    }

    export interface WorkloadTargetSelector {
        key: string;
        operator: string;
        values: string[];
    }

    export interface WorkloadVirtualMachine {
        image: string;
        livenessProbe?: outputs.compute.WorkloadVirtualMachineLivenessProbe;
        name: string;
        ports?: outputs.compute.WorkloadVirtualMachinePort[];
        readinessProbe?: outputs.compute.WorkloadVirtualMachineReadinessProbe;
        resources: outputs.compute.WorkloadVirtualMachineResources;
        userData?: string;
        volumeMounts?: outputs.compute.WorkloadVirtualMachineVolumeMount[];
    }

    export interface WorkloadVirtualMachineLivenessProbe {
        failureThreshold: number;
        httpGet?: outputs.compute.WorkloadVirtualMachineLivenessProbeHttpGet;
        initialDelaySeconds?: number;
        periodSeconds?: number;
        successThreshold: number;
        tcpSocket?: outputs.compute.WorkloadVirtualMachineLivenessProbeTcpSocket;
        timeoutSeconds?: number;
    }

    export interface WorkloadVirtualMachineLivenessProbeHttpGet {
        httpHeaders?: {[key: string]: string};
        path?: string;
        port: number;
        scheme?: string;
    }

    export interface WorkloadVirtualMachineLivenessProbeTcpSocket {
        port: number;
    }

    export interface WorkloadVirtualMachinePort {
        enableImplicitNetworkPolicy?: boolean;
        name: string;
        port: number;
        protocol?: string;
    }

    export interface WorkloadVirtualMachineReadinessProbe {
        failureThreshold: number;
        httpGet?: outputs.compute.WorkloadVirtualMachineReadinessProbeHttpGet;
        initialDelaySeconds?: number;
        periodSeconds?: number;
        successThreshold: number;
        tcpSocket?: outputs.compute.WorkloadVirtualMachineReadinessProbeTcpSocket;
        timeoutSeconds?: number;
    }

    export interface WorkloadVirtualMachineReadinessProbeHttpGet {
        httpHeaders?: {[key: string]: string};
        path?: string;
        port: number;
        scheme?: string;
    }

    export interface WorkloadVirtualMachineReadinessProbeTcpSocket {
        port: number;
    }

    export interface WorkloadVirtualMachineResources {
        requests: {[key: string]: string};
    }

    export interface WorkloadVirtualMachineRuntimeEnvironment {
        dns: outputs.compute.WorkloadVirtualMachineRuntimeEnvironmentDns;
    }

    export interface WorkloadVirtualMachineRuntimeEnvironmentDns {
        hostAliases?: outputs.compute.WorkloadVirtualMachineRuntimeEnvironmentDnsHostAlias[];
        resolverConfigs?: outputs.compute.WorkloadVirtualMachineRuntimeEnvironmentDnsResolverConfig[];
    }

    export interface WorkloadVirtualMachineRuntimeEnvironmentDnsHostAlias {
        address: string;
        hostnames: string[];
    }

    export interface WorkloadVirtualMachineRuntimeEnvironmentDnsResolverConfig {
        nameservers?: string[];
        options?: {[key: string]: any};
        searches?: string[];
    }

    export interface WorkloadVirtualMachineVolumeMount {
        mountPath: string;
        slug: string;
    }

    export interface WorkloadVolumeClaim {
        name: string;
        resources: outputs.compute.WorkloadVolumeClaimResources;
        slug?: string;
        storageClass?: string;
    }

    export interface WorkloadVolumeClaimResources {
        requests: {[key: string]: string};
    }

}
