// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";

export namespace compute {
    export interface NetworkPolicyEgress {
        action: pulumi.Input<string>;
        description?: pulumi.Input<string>;
        protocol?: pulumi.Input<inputs.compute.NetworkPolicyEgressProtocol>;
        to?: pulumi.Input<inputs.compute.NetworkPolicyEgressTo>;
    }

    export interface NetworkPolicyEgressProtocol {
        ah?: pulumi.Input<inputs.compute.NetworkPolicyEgressProtocolAh>;
        esp?: pulumi.Input<inputs.compute.NetworkPolicyEgressProtocolEsp>;
        gre?: pulumi.Input<inputs.compute.NetworkPolicyEgressProtocolGre>;
        icmp?: pulumi.Input<inputs.compute.NetworkPolicyEgressProtocolIcmp>;
        tcp?: pulumi.Input<inputs.compute.NetworkPolicyEgressProtocolTcp>;
        tcpUdp?: pulumi.Input<inputs.compute.NetworkPolicyEgressProtocolTcpUdp>;
        udp?: pulumi.Input<inputs.compute.NetworkPolicyEgressProtocolUdp>;
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
        destinationPorts?: pulumi.Input<pulumi.Input<string>[]>;
        sourcePorts?: pulumi.Input<pulumi.Input<string>[]>;
    }

    export interface NetworkPolicyEgressProtocolTcpUdp {
        destinationPorts?: pulumi.Input<pulumi.Input<string>[]>;
        sourcePorts?: pulumi.Input<pulumi.Input<string>[]>;
    }

    export interface NetworkPolicyEgressProtocolUdp {
        destinationPorts?: pulumi.Input<pulumi.Input<string>[]>;
        sourcePorts?: pulumi.Input<pulumi.Input<string>[]>;
    }

    export interface NetworkPolicyEgressTo {
        instanceSelectors?: pulumi.Input<pulumi.Input<inputs.compute.NetworkPolicyEgressToInstanceSelector>[]>;
        ipBlocks?: pulumi.Input<pulumi.Input<inputs.compute.NetworkPolicyEgressToIpBlock>[]>;
        networkSelectors?: pulumi.Input<pulumi.Input<inputs.compute.NetworkPolicyEgressToNetworkSelector>[]>;
    }

    export interface NetworkPolicyEgressToInstanceSelector {
        key: pulumi.Input<string>;
        operator: pulumi.Input<string>;
        values: pulumi.Input<pulumi.Input<string>[]>;
    }

    export interface NetworkPolicyEgressToIpBlock {
        cidr: pulumi.Input<string>;
        excepts?: pulumi.Input<pulumi.Input<string>[]>;
    }

    export interface NetworkPolicyEgressToNetworkSelector {
        key: pulumi.Input<string>;
        operator: pulumi.Input<string>;
        values: pulumi.Input<pulumi.Input<string>[]>;
    }

    export interface NetworkPolicyIngress {
        action: pulumi.Input<string>;
        description?: pulumi.Input<string>;
        from?: pulumi.Input<inputs.compute.NetworkPolicyIngressFrom>;
        protocol?: pulumi.Input<inputs.compute.NetworkPolicyIngressProtocol>;
    }

    export interface NetworkPolicyIngressFrom {
        instanceSelectors?: pulumi.Input<pulumi.Input<inputs.compute.NetworkPolicyIngressFromInstanceSelector>[]>;
        ipBlocks?: pulumi.Input<pulumi.Input<inputs.compute.NetworkPolicyIngressFromIpBlock>[]>;
        networkSelectors?: pulumi.Input<pulumi.Input<inputs.compute.NetworkPolicyIngressFromNetworkSelector>[]>;
    }

    export interface NetworkPolicyIngressFromInstanceSelector {
        key: pulumi.Input<string>;
        operator: pulumi.Input<string>;
        values: pulumi.Input<pulumi.Input<string>[]>;
    }

    export interface NetworkPolicyIngressFromIpBlock {
        cidr: pulumi.Input<string>;
        excepts?: pulumi.Input<pulumi.Input<string>[]>;
    }

    export interface NetworkPolicyIngressFromNetworkSelector {
        key: pulumi.Input<string>;
        operator: pulumi.Input<string>;
        values: pulumi.Input<pulumi.Input<string>[]>;
    }

    export interface NetworkPolicyIngressProtocol {
        ah?: pulumi.Input<inputs.compute.NetworkPolicyIngressProtocolAh>;
        esp?: pulumi.Input<inputs.compute.NetworkPolicyIngressProtocolEsp>;
        gre?: pulumi.Input<inputs.compute.NetworkPolicyIngressProtocolGre>;
        icmp?: pulumi.Input<inputs.compute.NetworkPolicyIngressProtocolIcmp>;
        tcp?: pulumi.Input<inputs.compute.NetworkPolicyIngressProtocolTcp>;
        tcpUdp?: pulumi.Input<inputs.compute.NetworkPolicyIngressProtocolTcpUdp>;
        udp?: pulumi.Input<inputs.compute.NetworkPolicyIngressProtocolUdp>;
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
        destinationPorts?: pulumi.Input<pulumi.Input<string>[]>;
        sourcePorts?: pulumi.Input<pulumi.Input<string>[]>;
    }

    export interface NetworkPolicyIngressProtocolTcpUdp {
        destinationPorts?: pulumi.Input<pulumi.Input<string>[]>;
        sourcePorts?: pulumi.Input<pulumi.Input<string>[]>;
    }

    export interface NetworkPolicyIngressProtocolUdp {
        destinationPorts?: pulumi.Input<pulumi.Input<string>[]>;
        sourcePorts?: pulumi.Input<pulumi.Input<string>[]>;
    }

    export interface NetworkPolicyInstanceSelector {
        key: pulumi.Input<string>;
        operator: pulumi.Input<string>;
        values: pulumi.Input<pulumi.Input<string>[]>;
    }

    export interface NetworkPolicyNetworkSelector {
        key: pulumi.Input<string>;
        operator: pulumi.Input<string>;
        values: pulumi.Input<pulumi.Input<string>[]>;
    }

    export interface NetworkRouteGatewaySelector {
        interfaceSelectors: pulumi.Input<pulumi.Input<inputs.compute.NetworkRouteGatewaySelectorInterfaceSelector>[]>;
    }

    export interface NetworkRouteGatewaySelectorInterfaceSelector {
        key: pulumi.Input<string>;
        operator: pulumi.Input<string>;
        values: pulumi.Input<pulumi.Input<string>[]>;
    }

    export interface WorkloadContainer {
        args?: pulumi.Input<pulumi.Input<string>[]>;
        commands?: pulumi.Input<pulumi.Input<string>[]>;
        envs?: pulumi.Input<pulumi.Input<inputs.compute.WorkloadContainerEnv>[]>;
        image: pulumi.Input<string>;
        livenessProbe?: pulumi.Input<inputs.compute.WorkloadContainerLivenessProbe>;
        name: pulumi.Input<string>;
        ports?: pulumi.Input<pulumi.Input<inputs.compute.WorkloadContainerPort>[]>;
        readinessProbe?: pulumi.Input<inputs.compute.WorkloadContainerReadinessProbe>;
        resources: pulumi.Input<inputs.compute.WorkloadContainerResources>;
        securityContext?: pulumi.Input<inputs.compute.WorkloadContainerSecurityContext>;
        volumeMounts?: pulumi.Input<pulumi.Input<inputs.compute.WorkloadContainerVolumeMount>[]>;
    }

    export interface WorkloadContainerEnv {
        key: pulumi.Input<string>;
        secretValue?: pulumi.Input<string>;
        value?: pulumi.Input<string>;
        valueFrom?: pulumi.Input<inputs.compute.WorkloadContainerEnvValueFrom>;
    }

    export interface WorkloadContainerEnvValueFrom {
        instanceFieldRef?: pulumi.Input<inputs.compute.WorkloadContainerEnvValueFromInstanceFieldRef>;
    }

    export interface WorkloadContainerEnvValueFromInstanceFieldRef {
        fieldPath?: pulumi.Input<string>;
        optional?: pulumi.Input<boolean>;
    }

    export interface WorkloadContainerLivenessProbe {
        failureThreshold: pulumi.Input<number>;
        httpGet?: pulumi.Input<inputs.compute.WorkloadContainerLivenessProbeHttpGet>;
        initialDelaySeconds?: pulumi.Input<number>;
        periodSeconds?: pulumi.Input<number>;
        successThreshold: pulumi.Input<number>;
        tcpSocket?: pulumi.Input<inputs.compute.WorkloadContainerLivenessProbeTcpSocket>;
        timeoutSeconds?: pulumi.Input<number>;
    }

    export interface WorkloadContainerLivenessProbeHttpGet {
        httpHeaders?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
        path?: pulumi.Input<string>;
        port: pulumi.Input<number>;
        scheme?: pulumi.Input<string>;
    }

    export interface WorkloadContainerLivenessProbeTcpSocket {
        port: pulumi.Input<number>;
    }

    export interface WorkloadContainerPort {
        enableImplicitNetworkPolicy?: pulumi.Input<boolean>;
        name: pulumi.Input<string>;
        port: pulumi.Input<number>;
        protocol?: pulumi.Input<string>;
    }

    export interface WorkloadContainerReadinessProbe {
        failureThreshold: pulumi.Input<number>;
        httpGet?: pulumi.Input<inputs.compute.WorkloadContainerReadinessProbeHttpGet>;
        initialDelaySeconds?: pulumi.Input<number>;
        periodSeconds?: pulumi.Input<number>;
        successThreshold: pulumi.Input<number>;
        tcpSocket?: pulumi.Input<inputs.compute.WorkloadContainerReadinessProbeTcpSocket>;
        timeoutSeconds?: pulumi.Input<number>;
    }

    export interface WorkloadContainerReadinessProbeHttpGet {
        httpHeaders?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
        path?: pulumi.Input<string>;
        port: pulumi.Input<number>;
        scheme?: pulumi.Input<string>;
    }

    export interface WorkloadContainerReadinessProbeTcpSocket {
        port: pulumi.Input<number>;
    }

    export interface WorkloadContainerResources {
        requests: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    }

    export interface WorkloadContainerRuntimeEnvironment {
        dns: pulumi.Input<inputs.compute.WorkloadContainerRuntimeEnvironmentDns>;
        securityContext?: pulumi.Input<inputs.compute.WorkloadContainerRuntimeEnvironmentSecurityContext>;
        shareProcessNamespace?: pulumi.Input<boolean>;
        terminationGracePeriodSeconds?: pulumi.Input<number>;
    }

    export interface WorkloadContainerRuntimeEnvironmentDns {
        hostAliases?: pulumi.Input<pulumi.Input<inputs.compute.WorkloadContainerRuntimeEnvironmentDnsHostAlias>[]>;
        resolverConfigs?: pulumi.Input<pulumi.Input<inputs.compute.WorkloadContainerRuntimeEnvironmentDnsResolverConfig>[]>;
    }

    export interface WorkloadContainerRuntimeEnvironmentDnsHostAlias {
        address: pulumi.Input<string>;
        hostnames: pulumi.Input<pulumi.Input<string>[]>;
    }

    export interface WorkloadContainerRuntimeEnvironmentDnsResolverConfig {
        nameservers?: pulumi.Input<pulumi.Input<string>[]>;
        options?: pulumi.Input<{[key: string]: any}>;
        searches?: pulumi.Input<pulumi.Input<string>[]>;
    }

    export interface WorkloadContainerRuntimeEnvironmentSecurityContext {
        runAsGroup?: pulumi.Input<string>;
        runAsNonRoot?: pulumi.Input<boolean>;
        runAsUser?: pulumi.Input<string>;
        supplementalGroups?: pulumi.Input<pulumi.Input<string>[]>;
        sysctl?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    }

    export interface WorkloadContainerSecurityContext {
        allowPrivilegeEscalation?: pulumi.Input<boolean>;
        capabilities?: pulumi.Input<inputs.compute.WorkloadContainerSecurityContextCapabilities>;
        readOnlyRootFilesystem?: pulumi.Input<boolean>;
        runAsGroup?: pulumi.Input<string>;
        runAsNonRoot?: pulumi.Input<boolean>;
        runAsUser?: pulumi.Input<string>;
    }

    export interface WorkloadContainerSecurityContextCapabilities {
        adds?: pulumi.Input<pulumi.Input<string>[]>;
        drops?: pulumi.Input<pulumi.Input<string>[]>;
    }

    export interface WorkloadContainerVolumeMount {
        mountPath: pulumi.Input<string>;
        slug: pulumi.Input<string>;
    }

    export interface WorkloadImagePullCredential {
        dockerRegistry: pulumi.Input<inputs.compute.WorkloadImagePullCredentialDockerRegistry>;
    }

    export interface WorkloadImagePullCredentialDockerRegistry {
        email?: pulumi.Input<string>;
        password: pulumi.Input<string>;
        server?: pulumi.Input<string>;
        username: pulumi.Input<string>;
    }

    export interface WorkloadInitContainer {
        args?: pulumi.Input<pulumi.Input<string>[]>;
        commands?: pulumi.Input<pulumi.Input<string>[]>;
        envs?: pulumi.Input<pulumi.Input<inputs.compute.WorkloadInitContainerEnv>[]>;
        image: pulumi.Input<string>;
        livenessProbe?: pulumi.Input<inputs.compute.WorkloadInitContainerLivenessProbe>;
        name: pulumi.Input<string>;
        ports?: pulumi.Input<pulumi.Input<inputs.compute.WorkloadInitContainerPort>[]>;
        readinessProbe?: pulumi.Input<inputs.compute.WorkloadInitContainerReadinessProbe>;
        resources: pulumi.Input<inputs.compute.WorkloadInitContainerResources>;
        securityContext?: pulumi.Input<inputs.compute.WorkloadInitContainerSecurityContext>;
        volumeMounts?: pulumi.Input<pulumi.Input<inputs.compute.WorkloadInitContainerVolumeMount>[]>;
    }

    export interface WorkloadInitContainerEnv {
        key: pulumi.Input<string>;
        secretValue?: pulumi.Input<string>;
        value?: pulumi.Input<string>;
        valueFrom?: pulumi.Input<inputs.compute.WorkloadInitContainerEnvValueFrom>;
    }

    export interface WorkloadInitContainerEnvValueFrom {
        instanceFieldRef?: pulumi.Input<inputs.compute.WorkloadInitContainerEnvValueFromInstanceFieldRef>;
    }

    export interface WorkloadInitContainerEnvValueFromInstanceFieldRef {
        fieldPath?: pulumi.Input<string>;
        optional?: pulumi.Input<boolean>;
    }

    export interface WorkloadInitContainerLivenessProbe {
        failureThreshold: pulumi.Input<number>;
        httpGet?: pulumi.Input<inputs.compute.WorkloadInitContainerLivenessProbeHttpGet>;
        initialDelaySeconds?: pulumi.Input<number>;
        periodSeconds?: pulumi.Input<number>;
        successThreshold: pulumi.Input<number>;
        tcpSocket?: pulumi.Input<inputs.compute.WorkloadInitContainerLivenessProbeTcpSocket>;
        timeoutSeconds?: pulumi.Input<number>;
    }

    export interface WorkloadInitContainerLivenessProbeHttpGet {
        httpHeaders?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
        path?: pulumi.Input<string>;
        port: pulumi.Input<number>;
        scheme?: pulumi.Input<string>;
    }

    export interface WorkloadInitContainerLivenessProbeTcpSocket {
        port: pulumi.Input<number>;
    }

    export interface WorkloadInitContainerPort {
        enableImplicitNetworkPolicy?: pulumi.Input<boolean>;
        name: pulumi.Input<string>;
        port: pulumi.Input<number>;
        protocol?: pulumi.Input<string>;
    }

    export interface WorkloadInitContainerReadinessProbe {
        failureThreshold: pulumi.Input<number>;
        httpGet?: pulumi.Input<inputs.compute.WorkloadInitContainerReadinessProbeHttpGet>;
        initialDelaySeconds?: pulumi.Input<number>;
        periodSeconds?: pulumi.Input<number>;
        successThreshold: pulumi.Input<number>;
        tcpSocket?: pulumi.Input<inputs.compute.WorkloadInitContainerReadinessProbeTcpSocket>;
        timeoutSeconds?: pulumi.Input<number>;
    }

    export interface WorkloadInitContainerReadinessProbeHttpGet {
        httpHeaders?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
        path?: pulumi.Input<string>;
        port: pulumi.Input<number>;
        scheme?: pulumi.Input<string>;
    }

    export interface WorkloadInitContainerReadinessProbeTcpSocket {
        port: pulumi.Input<number>;
    }

    export interface WorkloadInitContainerResources {
        requests: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    }

    export interface WorkloadInitContainerSecurityContext {
        allowPrivilegeEscalation?: pulumi.Input<boolean>;
        capabilities?: pulumi.Input<inputs.compute.WorkloadInitContainerSecurityContextCapabilities>;
        readOnlyRootFilesystem?: pulumi.Input<boolean>;
        runAsGroup?: pulumi.Input<string>;
        runAsNonRoot?: pulumi.Input<boolean>;
        runAsUser?: pulumi.Input<string>;
    }

    export interface WorkloadInitContainerSecurityContextCapabilities {
        adds?: pulumi.Input<pulumi.Input<string>[]>;
        drops?: pulumi.Input<pulumi.Input<string>[]>;
    }

    export interface WorkloadInitContainerVolumeMount {
        mountPath: pulumi.Input<string>;
        slug: pulumi.Input<string>;
    }

    export interface WorkloadInstance {
        containers?: pulumi.Input<pulumi.Input<inputs.compute.WorkloadInstanceContainer>[]>;
        externalIpAddress?: pulumi.Input<string>;
        externalIpv6Address?: pulumi.Input<string>;
        initContainers?: pulumi.Input<pulumi.Input<inputs.compute.WorkloadInstanceInitContainer>[]>;
        ipAddress?: pulumi.Input<string>;
        ipv6Address?: pulumi.Input<string>;
        location?: pulumi.Input<inputs.compute.WorkloadInstanceLocation>;
        message?: pulumi.Input<string>;
        metadata?: pulumi.Input<inputs.compute.WorkloadInstanceMetadata>;
        name: pulumi.Input<string>;
        networkInterfaces?: pulumi.Input<pulumi.Input<inputs.compute.WorkloadInstanceNetworkInterface>[]>;
        phase?: pulumi.Input<string>;
        reason?: pulumi.Input<string>;
        virtualMachine?: pulumi.Input<inputs.compute.WorkloadInstanceVirtualMachine>;
    }

    export interface WorkloadInstanceContainer {
        args?: pulumi.Input<pulumi.Input<string>[]>;
        commands?: pulumi.Input<pulumi.Input<string>[]>;
        envs?: pulumi.Input<pulumi.Input<inputs.compute.WorkloadInstanceContainerEnv>[]>;
        image: pulumi.Input<string>;
        livenessProbe?: pulumi.Input<inputs.compute.WorkloadInstanceContainerLivenessProbe>;
        name: pulumi.Input<string>;
        ports?: pulumi.Input<pulumi.Input<inputs.compute.WorkloadInstanceContainerPort>[]>;
        readinessProbe?: pulumi.Input<inputs.compute.WorkloadInstanceContainerReadinessProbe>;
        resources: pulumi.Input<inputs.compute.WorkloadInstanceContainerResources>;
        securityContext?: pulumi.Input<inputs.compute.WorkloadInstanceContainerSecurityContext>;
        volumeMounts?: pulumi.Input<pulumi.Input<inputs.compute.WorkloadInstanceContainerVolumeMount>[]>;
    }

    export interface WorkloadInstanceContainerEnv {
        key: pulumi.Input<string>;
        secretValue?: pulumi.Input<string>;
        value?: pulumi.Input<string>;
        valueFrom?: pulumi.Input<inputs.compute.WorkloadInstanceContainerEnvValueFrom>;
    }

    export interface WorkloadInstanceContainerEnvValueFrom {
        instanceFieldRef?: pulumi.Input<inputs.compute.WorkloadInstanceContainerEnvValueFromInstanceFieldRef>;
    }

    export interface WorkloadInstanceContainerEnvValueFromInstanceFieldRef {
        fieldPath?: pulumi.Input<string>;
        optional?: pulumi.Input<boolean>;
    }

    export interface WorkloadInstanceContainerLivenessProbe {
        failureThreshold: pulumi.Input<number>;
        httpGet?: pulumi.Input<inputs.compute.WorkloadInstanceContainerLivenessProbeHttpGet>;
        initialDelaySeconds?: pulumi.Input<number>;
        periodSeconds?: pulumi.Input<number>;
        successThreshold: pulumi.Input<number>;
        tcpSocket?: pulumi.Input<inputs.compute.WorkloadInstanceContainerLivenessProbeTcpSocket>;
        timeoutSeconds?: pulumi.Input<number>;
    }

    export interface WorkloadInstanceContainerLivenessProbeHttpGet {
        httpHeaders?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
        path?: pulumi.Input<string>;
        port: pulumi.Input<number>;
        scheme?: pulumi.Input<string>;
    }

    export interface WorkloadInstanceContainerLivenessProbeTcpSocket {
        port: pulumi.Input<number>;
    }

    export interface WorkloadInstanceContainerPort {
        enableImplicitNetworkPolicy?: pulumi.Input<boolean>;
        name: pulumi.Input<string>;
        port: pulumi.Input<number>;
        protocol?: pulumi.Input<string>;
    }

    export interface WorkloadInstanceContainerReadinessProbe {
        failureThreshold: pulumi.Input<number>;
        httpGet?: pulumi.Input<inputs.compute.WorkloadInstanceContainerReadinessProbeHttpGet>;
        initialDelaySeconds?: pulumi.Input<number>;
        periodSeconds?: pulumi.Input<number>;
        successThreshold: pulumi.Input<number>;
        tcpSocket?: pulumi.Input<inputs.compute.WorkloadInstanceContainerReadinessProbeTcpSocket>;
        timeoutSeconds?: pulumi.Input<number>;
    }

    export interface WorkloadInstanceContainerReadinessProbeHttpGet {
        httpHeaders?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
        path?: pulumi.Input<string>;
        port: pulumi.Input<number>;
        scheme?: pulumi.Input<string>;
    }

    export interface WorkloadInstanceContainerReadinessProbeTcpSocket {
        port: pulumi.Input<number>;
    }

    export interface WorkloadInstanceContainerResources {
        requests: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    }

    export interface WorkloadInstanceContainerSecurityContext {
        allowPrivilegeEscalation?: pulumi.Input<boolean>;
        capabilities?: pulumi.Input<inputs.compute.WorkloadInstanceContainerSecurityContextCapabilities>;
        readOnlyRootFilesystem?: pulumi.Input<boolean>;
        runAsGroup?: pulumi.Input<string>;
        runAsNonRoot?: pulumi.Input<boolean>;
        runAsUser?: pulumi.Input<string>;
    }

    export interface WorkloadInstanceContainerSecurityContextCapabilities {
        adds?: pulumi.Input<pulumi.Input<string>[]>;
        drops?: pulumi.Input<pulumi.Input<string>[]>;
    }

    export interface WorkloadInstanceContainerVolumeMount {
        mountPath: pulumi.Input<string>;
        slug: pulumi.Input<string>;
    }

    export interface WorkloadInstanceInitContainer {
        args?: pulumi.Input<pulumi.Input<string>[]>;
        commands?: pulumi.Input<pulumi.Input<string>[]>;
        envs?: pulumi.Input<pulumi.Input<inputs.compute.WorkloadInstanceInitContainerEnv>[]>;
        image: pulumi.Input<string>;
        livenessProbe?: pulumi.Input<inputs.compute.WorkloadInstanceInitContainerLivenessProbe>;
        name: pulumi.Input<string>;
        ports?: pulumi.Input<pulumi.Input<inputs.compute.WorkloadInstanceInitContainerPort>[]>;
        readinessProbe?: pulumi.Input<inputs.compute.WorkloadInstanceInitContainerReadinessProbe>;
        resources: pulumi.Input<inputs.compute.WorkloadInstanceInitContainerResources>;
        securityContext?: pulumi.Input<inputs.compute.WorkloadInstanceInitContainerSecurityContext>;
        volumeMounts?: pulumi.Input<pulumi.Input<inputs.compute.WorkloadInstanceInitContainerVolumeMount>[]>;
    }

    export interface WorkloadInstanceInitContainerEnv {
        key: pulumi.Input<string>;
        secretValue?: pulumi.Input<string>;
        value?: pulumi.Input<string>;
        valueFrom?: pulumi.Input<inputs.compute.WorkloadInstanceInitContainerEnvValueFrom>;
    }

    export interface WorkloadInstanceInitContainerEnvValueFrom {
        instanceFieldRef?: pulumi.Input<inputs.compute.WorkloadInstanceInitContainerEnvValueFromInstanceFieldRef>;
    }

    export interface WorkloadInstanceInitContainerEnvValueFromInstanceFieldRef {
        fieldPath?: pulumi.Input<string>;
        optional?: pulumi.Input<boolean>;
    }

    export interface WorkloadInstanceInitContainerLivenessProbe {
        failureThreshold: pulumi.Input<number>;
        httpGet?: pulumi.Input<inputs.compute.WorkloadInstanceInitContainerLivenessProbeHttpGet>;
        initialDelaySeconds?: pulumi.Input<number>;
        periodSeconds?: pulumi.Input<number>;
        successThreshold: pulumi.Input<number>;
        tcpSocket?: pulumi.Input<inputs.compute.WorkloadInstanceInitContainerLivenessProbeTcpSocket>;
        timeoutSeconds?: pulumi.Input<number>;
    }

    export interface WorkloadInstanceInitContainerLivenessProbeHttpGet {
        httpHeaders?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
        path?: pulumi.Input<string>;
        port: pulumi.Input<number>;
        scheme?: pulumi.Input<string>;
    }

    export interface WorkloadInstanceInitContainerLivenessProbeTcpSocket {
        port: pulumi.Input<number>;
    }

    export interface WorkloadInstanceInitContainerPort {
        enableImplicitNetworkPolicy?: pulumi.Input<boolean>;
        name: pulumi.Input<string>;
        port: pulumi.Input<number>;
        protocol?: pulumi.Input<string>;
    }

    export interface WorkloadInstanceInitContainerReadinessProbe {
        failureThreshold: pulumi.Input<number>;
        httpGet?: pulumi.Input<inputs.compute.WorkloadInstanceInitContainerReadinessProbeHttpGet>;
        initialDelaySeconds?: pulumi.Input<number>;
        periodSeconds?: pulumi.Input<number>;
        successThreshold: pulumi.Input<number>;
        tcpSocket?: pulumi.Input<inputs.compute.WorkloadInstanceInitContainerReadinessProbeTcpSocket>;
        timeoutSeconds?: pulumi.Input<number>;
    }

    export interface WorkloadInstanceInitContainerReadinessProbeHttpGet {
        httpHeaders?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
        path?: pulumi.Input<string>;
        port: pulumi.Input<number>;
        scheme?: pulumi.Input<string>;
    }

    export interface WorkloadInstanceInitContainerReadinessProbeTcpSocket {
        port: pulumi.Input<number>;
    }

    export interface WorkloadInstanceInitContainerResources {
        requests: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    }

    export interface WorkloadInstanceInitContainerSecurityContext {
        allowPrivilegeEscalation?: pulumi.Input<boolean>;
        capabilities?: pulumi.Input<inputs.compute.WorkloadInstanceInitContainerSecurityContextCapabilities>;
        readOnlyRootFilesystem?: pulumi.Input<boolean>;
        runAsGroup?: pulumi.Input<string>;
        runAsNonRoot?: pulumi.Input<boolean>;
        runAsUser?: pulumi.Input<string>;
    }

    export interface WorkloadInstanceInitContainerSecurityContextCapabilities {
        adds?: pulumi.Input<pulumi.Input<string>[]>;
        drops?: pulumi.Input<pulumi.Input<string>[]>;
    }

    export interface WorkloadInstanceInitContainerVolumeMount {
        mountPath: pulumi.Input<string>;
        slug: pulumi.Input<string>;
    }

    export interface WorkloadInstanceLocation {
        city?: pulumi.Input<string>;
        cityCode?: pulumi.Input<string>;
        continent?: pulumi.Input<string>;
        continentCode?: pulumi.Input<string>;
        country?: pulumi.Input<string>;
        countryCode?: pulumi.Input<string>;
        latitude?: pulumi.Input<number>;
        longitude?: pulumi.Input<number>;
        name?: pulumi.Input<string>;
        region?: pulumi.Input<string>;
        regionCode?: pulumi.Input<string>;
        subdivision?: pulumi.Input<string>;
        subdivisionCode?: pulumi.Input<string>;
    }

    export interface WorkloadInstanceMetadata {
        annotations?: pulumi.Input<{[key: string]: any}>;
        labels?: pulumi.Input<{[key: string]: any}>;
    }

    export interface WorkloadInstanceNetworkInterface {
        gateway: pulumi.Input<string>;
        ipAddress: pulumi.Input<string>;
        ipAddressAliases?: pulumi.Input<pulumi.Input<string>[]>;
        ipv6Address: pulumi.Input<string>;
        ipv6AddressAliases?: pulumi.Input<pulumi.Input<string>[]>;
        ipv6Gateway: pulumi.Input<string>;
        network: pulumi.Input<string>;
    }

    export interface WorkloadInstanceVirtualMachine {
        image: pulumi.Input<string>;
        livenessProbe?: pulumi.Input<inputs.compute.WorkloadInstanceVirtualMachineLivenessProbe>;
        name: pulumi.Input<string>;
        ports?: pulumi.Input<pulumi.Input<inputs.compute.WorkloadInstanceVirtualMachinePort>[]>;
        readinessProbe?: pulumi.Input<inputs.compute.WorkloadInstanceVirtualMachineReadinessProbe>;
        resources: pulumi.Input<inputs.compute.WorkloadInstanceVirtualMachineResources>;
        userData?: pulumi.Input<string>;
        volumeMounts?: pulumi.Input<pulumi.Input<inputs.compute.WorkloadInstanceVirtualMachineVolumeMount>[]>;
    }

    export interface WorkloadInstanceVirtualMachineLivenessProbe {
        failureThreshold: pulumi.Input<number>;
        httpGet?: pulumi.Input<inputs.compute.WorkloadInstanceVirtualMachineLivenessProbeHttpGet>;
        initialDelaySeconds?: pulumi.Input<number>;
        periodSeconds?: pulumi.Input<number>;
        successThreshold: pulumi.Input<number>;
        tcpSocket?: pulumi.Input<inputs.compute.WorkloadInstanceVirtualMachineLivenessProbeTcpSocket>;
        timeoutSeconds?: pulumi.Input<number>;
    }

    export interface WorkloadInstanceVirtualMachineLivenessProbeHttpGet {
        httpHeaders?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
        path?: pulumi.Input<string>;
        port: pulumi.Input<number>;
        scheme?: pulumi.Input<string>;
    }

    export interface WorkloadInstanceVirtualMachineLivenessProbeTcpSocket {
        port: pulumi.Input<number>;
    }

    export interface WorkloadInstanceVirtualMachinePort {
        enableImplicitNetworkPolicy?: pulumi.Input<boolean>;
        name: pulumi.Input<string>;
        port: pulumi.Input<number>;
        protocol?: pulumi.Input<string>;
    }

    export interface WorkloadInstanceVirtualMachineReadinessProbe {
        failureThreshold: pulumi.Input<number>;
        httpGet?: pulumi.Input<inputs.compute.WorkloadInstanceVirtualMachineReadinessProbeHttpGet>;
        initialDelaySeconds?: pulumi.Input<number>;
        periodSeconds?: pulumi.Input<number>;
        successThreshold: pulumi.Input<number>;
        tcpSocket?: pulumi.Input<inputs.compute.WorkloadInstanceVirtualMachineReadinessProbeTcpSocket>;
        timeoutSeconds?: pulumi.Input<number>;
    }

    export interface WorkloadInstanceVirtualMachineReadinessProbeHttpGet {
        httpHeaders?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
        path?: pulumi.Input<string>;
        port: pulumi.Input<number>;
        scheme?: pulumi.Input<string>;
    }

    export interface WorkloadInstanceVirtualMachineReadinessProbeTcpSocket {
        port: pulumi.Input<number>;
    }

    export interface WorkloadInstanceVirtualMachineResources {
        requests: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    }

    export interface WorkloadInstanceVirtualMachineVolumeMount {
        mountPath: pulumi.Input<string>;
        slug: pulumi.Input<string>;
    }

    export interface WorkloadNetworkInterface {
        enableOneToOneNat?: pulumi.Input<boolean>;
        ipFamilies?: pulumi.Input<pulumi.Input<string>[]>;
        ipv6Subnet?: pulumi.Input<string>;
        network: pulumi.Input<string>;
        subnet?: pulumi.Input<string>;
    }

    export interface WorkloadTarget {
        deploymentScope?: pulumi.Input<string>;
        maxReplicas?: pulumi.Input<number>;
        minReplicas: pulumi.Input<number>;
        name: pulumi.Input<string>;
        scaleSettings?: pulumi.Input<inputs.compute.WorkloadTargetScaleSettings>;
        selectors: pulumi.Input<pulumi.Input<inputs.compute.WorkloadTargetSelector>[]>;
    }

    export interface WorkloadTargetScaleSettings {
        metrics: pulumi.Input<pulumi.Input<inputs.compute.WorkloadTargetScaleSettingsMetric>[]>;
    }

    export interface WorkloadTargetScaleSettingsMetric {
        averageUtilization?: pulumi.Input<number>;
        averageValue?: pulumi.Input<string>;
        metric: pulumi.Input<string>;
    }

    export interface WorkloadTargetSelector {
        key: pulumi.Input<string>;
        operator: pulumi.Input<string>;
        values: pulumi.Input<pulumi.Input<string>[]>;
    }

    export interface WorkloadVirtualMachine {
        image: pulumi.Input<string>;
        livenessProbe?: pulumi.Input<inputs.compute.WorkloadVirtualMachineLivenessProbe>;
        name: pulumi.Input<string>;
        ports?: pulumi.Input<pulumi.Input<inputs.compute.WorkloadVirtualMachinePort>[]>;
        readinessProbe?: pulumi.Input<inputs.compute.WorkloadVirtualMachineReadinessProbe>;
        resources: pulumi.Input<inputs.compute.WorkloadVirtualMachineResources>;
        userData?: pulumi.Input<string>;
        volumeMounts?: pulumi.Input<pulumi.Input<inputs.compute.WorkloadVirtualMachineVolumeMount>[]>;
    }

    export interface WorkloadVirtualMachineLivenessProbe {
        failureThreshold: pulumi.Input<number>;
        httpGet?: pulumi.Input<inputs.compute.WorkloadVirtualMachineLivenessProbeHttpGet>;
        initialDelaySeconds?: pulumi.Input<number>;
        periodSeconds?: pulumi.Input<number>;
        successThreshold: pulumi.Input<number>;
        tcpSocket?: pulumi.Input<inputs.compute.WorkloadVirtualMachineLivenessProbeTcpSocket>;
        timeoutSeconds?: pulumi.Input<number>;
    }

    export interface WorkloadVirtualMachineLivenessProbeHttpGet {
        httpHeaders?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
        path?: pulumi.Input<string>;
        port: pulumi.Input<number>;
        scheme?: pulumi.Input<string>;
    }

    export interface WorkloadVirtualMachineLivenessProbeTcpSocket {
        port: pulumi.Input<number>;
    }

    export interface WorkloadVirtualMachinePort {
        enableImplicitNetworkPolicy?: pulumi.Input<boolean>;
        name: pulumi.Input<string>;
        port: pulumi.Input<number>;
        protocol?: pulumi.Input<string>;
    }

    export interface WorkloadVirtualMachineReadinessProbe {
        failureThreshold: pulumi.Input<number>;
        httpGet?: pulumi.Input<inputs.compute.WorkloadVirtualMachineReadinessProbeHttpGet>;
        initialDelaySeconds?: pulumi.Input<number>;
        periodSeconds?: pulumi.Input<number>;
        successThreshold: pulumi.Input<number>;
        tcpSocket?: pulumi.Input<inputs.compute.WorkloadVirtualMachineReadinessProbeTcpSocket>;
        timeoutSeconds?: pulumi.Input<number>;
    }

    export interface WorkloadVirtualMachineReadinessProbeHttpGet {
        httpHeaders?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
        path?: pulumi.Input<string>;
        port: pulumi.Input<number>;
        scheme?: pulumi.Input<string>;
    }

    export interface WorkloadVirtualMachineReadinessProbeTcpSocket {
        port: pulumi.Input<number>;
    }

    export interface WorkloadVirtualMachineResources {
        requests: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    }

    export interface WorkloadVirtualMachineRuntimeEnvironment {
        dns: pulumi.Input<inputs.compute.WorkloadVirtualMachineRuntimeEnvironmentDns>;
    }

    export interface WorkloadVirtualMachineRuntimeEnvironmentDns {
        hostAliases?: pulumi.Input<pulumi.Input<inputs.compute.WorkloadVirtualMachineRuntimeEnvironmentDnsHostAlias>[]>;
        resolverConfigs?: pulumi.Input<pulumi.Input<inputs.compute.WorkloadVirtualMachineRuntimeEnvironmentDnsResolverConfig>[]>;
    }

    export interface WorkloadVirtualMachineRuntimeEnvironmentDnsHostAlias {
        address: pulumi.Input<string>;
        hostnames: pulumi.Input<pulumi.Input<string>[]>;
    }

    export interface WorkloadVirtualMachineRuntimeEnvironmentDnsResolverConfig {
        nameservers?: pulumi.Input<pulumi.Input<string>[]>;
        options?: pulumi.Input<{[key: string]: any}>;
        searches?: pulumi.Input<pulumi.Input<string>[]>;
    }

    export interface WorkloadVirtualMachineVolumeMount {
        mountPath: pulumi.Input<string>;
        slug: pulumi.Input<string>;
    }

    export interface WorkloadVolumeClaim {
        name: pulumi.Input<string>;
        resources: pulumi.Input<inputs.compute.WorkloadVolumeClaimResources>;
        slug?: pulumi.Input<string>;
        storageClass?: pulumi.Input<string>;
    }

    export interface WorkloadVolumeClaimResources {
        requests: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    }
}
