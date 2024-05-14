# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs
from ._inputs import *

__all__ = ['WorkloadArgs', 'Workload']

@pulumi.input_type
class WorkloadArgs:
    def __init__(__self__, *,
                 name: pulumi.Input[str],
                 network_interfaces: pulumi.Input[Sequence[pulumi.Input['WorkloadNetworkInterfaceArgs']]],
                 slug: pulumi.Input[str],
                 targets: pulumi.Input[Sequence[pulumi.Input['WorkloadTargetArgs']]],
                 annotations: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 container_runtime_environment: Optional[pulumi.Input['WorkloadContainerRuntimeEnvironmentArgs']] = None,
                 containers: Optional[pulumi.Input[Sequence[pulumi.Input['WorkloadContainerArgs']]]] = None,
                 image_pull_credentials: Optional[pulumi.Input[Sequence[pulumi.Input['WorkloadImagePullCredentialArgs']]]] = None,
                 init_containers: Optional[pulumi.Input[Sequence[pulumi.Input['WorkloadInitContainerArgs']]]] = None,
                 instances: Optional[pulumi.Input[Sequence[pulumi.Input['WorkloadInstanceArgs']]]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 virtual_machine: Optional[pulumi.Input['WorkloadVirtualMachineArgs']] = None,
                 virtual_machine_runtime_environment: Optional[pulumi.Input['WorkloadVirtualMachineRuntimeEnvironmentArgs']] = None,
                 volume_claims: Optional[pulumi.Input[Sequence[pulumi.Input['WorkloadVolumeClaimArgs']]]] = None):
        """
        The set of arguments for constructing a Workload resource.
        """
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "network_interfaces", network_interfaces)
        pulumi.set(__self__, "slug", slug)
        pulumi.set(__self__, "targets", targets)
        if annotations is not None:
            pulumi.set(__self__, "annotations", annotations)
        if container_runtime_environment is not None:
            pulumi.set(__self__, "container_runtime_environment", container_runtime_environment)
        if containers is not None:
            pulumi.set(__self__, "containers", containers)
        if image_pull_credentials is not None:
            pulumi.set(__self__, "image_pull_credentials", image_pull_credentials)
        if init_containers is not None:
            pulumi.set(__self__, "init_containers", init_containers)
        if instances is not None:
            pulumi.set(__self__, "instances", instances)
        if labels is not None:
            pulumi.set(__self__, "labels", labels)
        if virtual_machine is not None:
            pulumi.set(__self__, "virtual_machine", virtual_machine)
        if virtual_machine_runtime_environment is not None:
            pulumi.set(__self__, "virtual_machine_runtime_environment", virtual_machine_runtime_environment)
        if volume_claims is not None:
            pulumi.set(__self__, "volume_claims", volume_claims)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Input[str]:
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: pulumi.Input[str]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="networkInterfaces")
    def network_interfaces(self) -> pulumi.Input[Sequence[pulumi.Input['WorkloadNetworkInterfaceArgs']]]:
        return pulumi.get(self, "network_interfaces")

    @network_interfaces.setter
    def network_interfaces(self, value: pulumi.Input[Sequence[pulumi.Input['WorkloadNetworkInterfaceArgs']]]):
        pulumi.set(self, "network_interfaces", value)

    @property
    @pulumi.getter
    def slug(self) -> pulumi.Input[str]:
        return pulumi.get(self, "slug")

    @slug.setter
    def slug(self, value: pulumi.Input[str]):
        pulumi.set(self, "slug", value)

    @property
    @pulumi.getter
    def targets(self) -> pulumi.Input[Sequence[pulumi.Input['WorkloadTargetArgs']]]:
        return pulumi.get(self, "targets")

    @targets.setter
    def targets(self, value: pulumi.Input[Sequence[pulumi.Input['WorkloadTargetArgs']]]):
        pulumi.set(self, "targets", value)

    @property
    @pulumi.getter
    def annotations(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        return pulumi.get(self, "annotations")

    @annotations.setter
    def annotations(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "annotations", value)

    @property
    @pulumi.getter(name="containerRuntimeEnvironment")
    def container_runtime_environment(self) -> Optional[pulumi.Input['WorkloadContainerRuntimeEnvironmentArgs']]:
        return pulumi.get(self, "container_runtime_environment")

    @container_runtime_environment.setter
    def container_runtime_environment(self, value: Optional[pulumi.Input['WorkloadContainerRuntimeEnvironmentArgs']]):
        pulumi.set(self, "container_runtime_environment", value)

    @property
    @pulumi.getter
    def containers(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['WorkloadContainerArgs']]]]:
        return pulumi.get(self, "containers")

    @containers.setter
    def containers(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['WorkloadContainerArgs']]]]):
        pulumi.set(self, "containers", value)

    @property
    @pulumi.getter(name="imagePullCredentials")
    def image_pull_credentials(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['WorkloadImagePullCredentialArgs']]]]:
        return pulumi.get(self, "image_pull_credentials")

    @image_pull_credentials.setter
    def image_pull_credentials(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['WorkloadImagePullCredentialArgs']]]]):
        pulumi.set(self, "image_pull_credentials", value)

    @property
    @pulumi.getter(name="initContainers")
    def init_containers(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['WorkloadInitContainerArgs']]]]:
        return pulumi.get(self, "init_containers")

    @init_containers.setter
    def init_containers(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['WorkloadInitContainerArgs']]]]):
        pulumi.set(self, "init_containers", value)

    @property
    @pulumi.getter
    def instances(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['WorkloadInstanceArgs']]]]:
        return pulumi.get(self, "instances")

    @instances.setter
    def instances(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['WorkloadInstanceArgs']]]]):
        pulumi.set(self, "instances", value)

    @property
    @pulumi.getter
    def labels(self) -> Optional[pulumi.Input[Mapping[str, Any]]]:
        return pulumi.get(self, "labels")

    @labels.setter
    def labels(self, value: Optional[pulumi.Input[Mapping[str, Any]]]):
        pulumi.set(self, "labels", value)

    @property
    @pulumi.getter(name="virtualMachine")
    def virtual_machine(self) -> Optional[pulumi.Input['WorkloadVirtualMachineArgs']]:
        return pulumi.get(self, "virtual_machine")

    @virtual_machine.setter
    def virtual_machine(self, value: Optional[pulumi.Input['WorkloadVirtualMachineArgs']]):
        pulumi.set(self, "virtual_machine", value)

    @property
    @pulumi.getter(name="virtualMachineRuntimeEnvironment")
    def virtual_machine_runtime_environment(self) -> Optional[pulumi.Input['WorkloadVirtualMachineRuntimeEnvironmentArgs']]:
        return pulumi.get(self, "virtual_machine_runtime_environment")

    @virtual_machine_runtime_environment.setter
    def virtual_machine_runtime_environment(self, value: Optional[pulumi.Input['WorkloadVirtualMachineRuntimeEnvironmentArgs']]):
        pulumi.set(self, "virtual_machine_runtime_environment", value)

    @property
    @pulumi.getter(name="volumeClaims")
    def volume_claims(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['WorkloadVolumeClaimArgs']]]]:
        return pulumi.get(self, "volume_claims")

    @volume_claims.setter
    def volume_claims(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['WorkloadVolumeClaimArgs']]]]):
        pulumi.set(self, "volume_claims", value)


@pulumi.input_type
class _WorkloadState:
    def __init__(__self__, *,
                 annotations: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 container_runtime_environment: Optional[pulumi.Input['WorkloadContainerRuntimeEnvironmentArgs']] = None,
                 containers: Optional[pulumi.Input[Sequence[pulumi.Input['WorkloadContainerArgs']]]] = None,
                 image_pull_credentials: Optional[pulumi.Input[Sequence[pulumi.Input['WorkloadImagePullCredentialArgs']]]] = None,
                 init_containers: Optional[pulumi.Input[Sequence[pulumi.Input['WorkloadInitContainerArgs']]]] = None,
                 instances: Optional[pulumi.Input[Sequence[pulumi.Input['WorkloadInstanceArgs']]]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 network_interfaces: Optional[pulumi.Input[Sequence[pulumi.Input['WorkloadNetworkInterfaceArgs']]]] = None,
                 slug: Optional[pulumi.Input[str]] = None,
                 targets: Optional[pulumi.Input[Sequence[pulumi.Input['WorkloadTargetArgs']]]] = None,
                 version: Optional[pulumi.Input[str]] = None,
                 virtual_machine: Optional[pulumi.Input['WorkloadVirtualMachineArgs']] = None,
                 virtual_machine_runtime_environment: Optional[pulumi.Input['WorkloadVirtualMachineRuntimeEnvironmentArgs']] = None,
                 volume_claims: Optional[pulumi.Input[Sequence[pulumi.Input['WorkloadVolumeClaimArgs']]]] = None):
        """
        Input properties used for looking up and filtering Workload resources.
        """
        if annotations is not None:
            pulumi.set(__self__, "annotations", annotations)
        if container_runtime_environment is not None:
            pulumi.set(__self__, "container_runtime_environment", container_runtime_environment)
        if containers is not None:
            pulumi.set(__self__, "containers", containers)
        if image_pull_credentials is not None:
            pulumi.set(__self__, "image_pull_credentials", image_pull_credentials)
        if init_containers is not None:
            pulumi.set(__self__, "init_containers", init_containers)
        if instances is not None:
            pulumi.set(__self__, "instances", instances)
        if labels is not None:
            pulumi.set(__self__, "labels", labels)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if network_interfaces is not None:
            pulumi.set(__self__, "network_interfaces", network_interfaces)
        if slug is not None:
            pulumi.set(__self__, "slug", slug)
        if targets is not None:
            pulumi.set(__self__, "targets", targets)
        if version is not None:
            pulumi.set(__self__, "version", version)
        if virtual_machine is not None:
            pulumi.set(__self__, "virtual_machine", virtual_machine)
        if virtual_machine_runtime_environment is not None:
            pulumi.set(__self__, "virtual_machine_runtime_environment", virtual_machine_runtime_environment)
        if volume_claims is not None:
            pulumi.set(__self__, "volume_claims", volume_claims)

    @property
    @pulumi.getter
    def annotations(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        return pulumi.get(self, "annotations")

    @annotations.setter
    def annotations(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "annotations", value)

    @property
    @pulumi.getter(name="containerRuntimeEnvironment")
    def container_runtime_environment(self) -> Optional[pulumi.Input['WorkloadContainerRuntimeEnvironmentArgs']]:
        return pulumi.get(self, "container_runtime_environment")

    @container_runtime_environment.setter
    def container_runtime_environment(self, value: Optional[pulumi.Input['WorkloadContainerRuntimeEnvironmentArgs']]):
        pulumi.set(self, "container_runtime_environment", value)

    @property
    @pulumi.getter
    def containers(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['WorkloadContainerArgs']]]]:
        return pulumi.get(self, "containers")

    @containers.setter
    def containers(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['WorkloadContainerArgs']]]]):
        pulumi.set(self, "containers", value)

    @property
    @pulumi.getter(name="imagePullCredentials")
    def image_pull_credentials(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['WorkloadImagePullCredentialArgs']]]]:
        return pulumi.get(self, "image_pull_credentials")

    @image_pull_credentials.setter
    def image_pull_credentials(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['WorkloadImagePullCredentialArgs']]]]):
        pulumi.set(self, "image_pull_credentials", value)

    @property
    @pulumi.getter(name="initContainers")
    def init_containers(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['WorkloadInitContainerArgs']]]]:
        return pulumi.get(self, "init_containers")

    @init_containers.setter
    def init_containers(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['WorkloadInitContainerArgs']]]]):
        pulumi.set(self, "init_containers", value)

    @property
    @pulumi.getter
    def instances(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['WorkloadInstanceArgs']]]]:
        return pulumi.get(self, "instances")

    @instances.setter
    def instances(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['WorkloadInstanceArgs']]]]):
        pulumi.set(self, "instances", value)

    @property
    @pulumi.getter
    def labels(self) -> Optional[pulumi.Input[Mapping[str, Any]]]:
        return pulumi.get(self, "labels")

    @labels.setter
    def labels(self, value: Optional[pulumi.Input[Mapping[str, Any]]]):
        pulumi.set(self, "labels", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="networkInterfaces")
    def network_interfaces(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['WorkloadNetworkInterfaceArgs']]]]:
        return pulumi.get(self, "network_interfaces")

    @network_interfaces.setter
    def network_interfaces(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['WorkloadNetworkInterfaceArgs']]]]):
        pulumi.set(self, "network_interfaces", value)

    @property
    @pulumi.getter
    def slug(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "slug")

    @slug.setter
    def slug(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "slug", value)

    @property
    @pulumi.getter
    def targets(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['WorkloadTargetArgs']]]]:
        return pulumi.get(self, "targets")

    @targets.setter
    def targets(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['WorkloadTargetArgs']]]]):
        pulumi.set(self, "targets", value)

    @property
    @pulumi.getter
    def version(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "version")

    @version.setter
    def version(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "version", value)

    @property
    @pulumi.getter(name="virtualMachine")
    def virtual_machine(self) -> Optional[pulumi.Input['WorkloadVirtualMachineArgs']]:
        return pulumi.get(self, "virtual_machine")

    @virtual_machine.setter
    def virtual_machine(self, value: Optional[pulumi.Input['WorkloadVirtualMachineArgs']]):
        pulumi.set(self, "virtual_machine", value)

    @property
    @pulumi.getter(name="virtualMachineRuntimeEnvironment")
    def virtual_machine_runtime_environment(self) -> Optional[pulumi.Input['WorkloadVirtualMachineRuntimeEnvironmentArgs']]:
        return pulumi.get(self, "virtual_machine_runtime_environment")

    @virtual_machine_runtime_environment.setter
    def virtual_machine_runtime_environment(self, value: Optional[pulumi.Input['WorkloadVirtualMachineRuntimeEnvironmentArgs']]):
        pulumi.set(self, "virtual_machine_runtime_environment", value)

    @property
    @pulumi.getter(name="volumeClaims")
    def volume_claims(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['WorkloadVolumeClaimArgs']]]]:
        return pulumi.get(self, "volume_claims")

    @volume_claims.setter
    def volume_claims(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['WorkloadVolumeClaimArgs']]]]):
        pulumi.set(self, "volume_claims", value)


class Workload(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 annotations: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 container_runtime_environment: Optional[pulumi.Input[pulumi.InputType['WorkloadContainerRuntimeEnvironmentArgs']]] = None,
                 containers: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['WorkloadContainerArgs']]]]] = None,
                 image_pull_credentials: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['WorkloadImagePullCredentialArgs']]]]] = None,
                 init_containers: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['WorkloadInitContainerArgs']]]]] = None,
                 instances: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['WorkloadInstanceArgs']]]]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 network_interfaces: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['WorkloadNetworkInterfaceArgs']]]]] = None,
                 slug: Optional[pulumi.Input[str]] = None,
                 targets: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['WorkloadTargetArgs']]]]] = None,
                 virtual_machine: Optional[pulumi.Input[pulumi.InputType['WorkloadVirtualMachineArgs']]] = None,
                 virtual_machine_runtime_environment: Optional[pulumi.Input[pulumi.InputType['WorkloadVirtualMachineRuntimeEnvironmentArgs']]] = None,
                 volume_claims: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['WorkloadVolumeClaimArgs']]]]] = None,
                 __props__=None):
        """
        Create a Workload resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: WorkloadArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a Workload resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param WorkloadArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(WorkloadArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 annotations: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 container_runtime_environment: Optional[pulumi.Input[pulumi.InputType['WorkloadContainerRuntimeEnvironmentArgs']]] = None,
                 containers: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['WorkloadContainerArgs']]]]] = None,
                 image_pull_credentials: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['WorkloadImagePullCredentialArgs']]]]] = None,
                 init_containers: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['WorkloadInitContainerArgs']]]]] = None,
                 instances: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['WorkloadInstanceArgs']]]]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 network_interfaces: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['WorkloadNetworkInterfaceArgs']]]]] = None,
                 slug: Optional[pulumi.Input[str]] = None,
                 targets: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['WorkloadTargetArgs']]]]] = None,
                 virtual_machine: Optional[pulumi.Input[pulumi.InputType['WorkloadVirtualMachineArgs']]] = None,
                 virtual_machine_runtime_environment: Optional[pulumi.Input[pulumi.InputType['WorkloadVirtualMachineRuntimeEnvironmentArgs']]] = None,
                 volume_claims: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['WorkloadVolumeClaimArgs']]]]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = WorkloadArgs.__new__(WorkloadArgs)

            __props__.__dict__["annotations"] = annotations
            __props__.__dict__["container_runtime_environment"] = container_runtime_environment
            __props__.__dict__["containers"] = containers
            __props__.__dict__["image_pull_credentials"] = image_pull_credentials
            __props__.__dict__["init_containers"] = init_containers
            __props__.__dict__["instances"] = instances
            __props__.__dict__["labels"] = labels
            if name is None and not opts.urn:
                raise TypeError("Missing required property 'name'")
            __props__.__dict__["name"] = name
            if network_interfaces is None and not opts.urn:
                raise TypeError("Missing required property 'network_interfaces'")
            __props__.__dict__["network_interfaces"] = network_interfaces
            if slug is None and not opts.urn:
                raise TypeError("Missing required property 'slug'")
            __props__.__dict__["slug"] = slug
            if targets is None and not opts.urn:
                raise TypeError("Missing required property 'targets'")
            __props__.__dict__["targets"] = targets
            __props__.__dict__["virtual_machine"] = virtual_machine
            __props__.__dict__["virtual_machine_runtime_environment"] = virtual_machine_runtime_environment
            __props__.__dict__["volume_claims"] = volume_claims
            __props__.__dict__["version"] = None
        super(Workload, __self__).__init__(
            'stackpath:compute/workload:Workload',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            annotations: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
            container_runtime_environment: Optional[pulumi.Input[pulumi.InputType['WorkloadContainerRuntimeEnvironmentArgs']]] = None,
            containers: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['WorkloadContainerArgs']]]]] = None,
            image_pull_credentials: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['WorkloadImagePullCredentialArgs']]]]] = None,
            init_containers: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['WorkloadInitContainerArgs']]]]] = None,
            instances: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['WorkloadInstanceArgs']]]]] = None,
            labels: Optional[pulumi.Input[Mapping[str, Any]]] = None,
            name: Optional[pulumi.Input[str]] = None,
            network_interfaces: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['WorkloadNetworkInterfaceArgs']]]]] = None,
            slug: Optional[pulumi.Input[str]] = None,
            targets: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['WorkloadTargetArgs']]]]] = None,
            version: Optional[pulumi.Input[str]] = None,
            virtual_machine: Optional[pulumi.Input[pulumi.InputType['WorkloadVirtualMachineArgs']]] = None,
            virtual_machine_runtime_environment: Optional[pulumi.Input[pulumi.InputType['WorkloadVirtualMachineRuntimeEnvironmentArgs']]] = None,
            volume_claims: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['WorkloadVolumeClaimArgs']]]]] = None) -> 'Workload':
        """
        Get an existing Workload resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _WorkloadState.__new__(_WorkloadState)

        __props__.__dict__["annotations"] = annotations
        __props__.__dict__["container_runtime_environment"] = container_runtime_environment
        __props__.__dict__["containers"] = containers
        __props__.__dict__["image_pull_credentials"] = image_pull_credentials
        __props__.__dict__["init_containers"] = init_containers
        __props__.__dict__["instances"] = instances
        __props__.__dict__["labels"] = labels
        __props__.__dict__["name"] = name
        __props__.__dict__["network_interfaces"] = network_interfaces
        __props__.__dict__["slug"] = slug
        __props__.__dict__["targets"] = targets
        __props__.__dict__["version"] = version
        __props__.__dict__["virtual_machine"] = virtual_machine
        __props__.__dict__["virtual_machine_runtime_environment"] = virtual_machine_runtime_environment
        __props__.__dict__["volume_claims"] = volume_claims
        return Workload(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def annotations(self) -> pulumi.Output[Mapping[str, str]]:
        return pulumi.get(self, "annotations")

    @property
    @pulumi.getter(name="containerRuntimeEnvironment")
    def container_runtime_environment(self) -> pulumi.Output[Optional['outputs.WorkloadContainerRuntimeEnvironment']]:
        return pulumi.get(self, "container_runtime_environment")

    @property
    @pulumi.getter
    def containers(self) -> pulumi.Output[Optional[Sequence['outputs.WorkloadContainer']]]:
        return pulumi.get(self, "containers")

    @property
    @pulumi.getter(name="imagePullCredentials")
    def image_pull_credentials(self) -> pulumi.Output[Optional[Sequence['outputs.WorkloadImagePullCredential']]]:
        return pulumi.get(self, "image_pull_credentials")

    @property
    @pulumi.getter(name="initContainers")
    def init_containers(self) -> pulumi.Output[Optional[Sequence['outputs.WorkloadInitContainer']]]:
        return pulumi.get(self, "init_containers")

    @property
    @pulumi.getter
    def instances(self) -> pulumi.Output[Sequence['outputs.WorkloadInstance']]:
        return pulumi.get(self, "instances")

    @property
    @pulumi.getter
    def labels(self) -> pulumi.Output[Optional[Mapping[str, Any]]]:
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="networkInterfaces")
    def network_interfaces(self) -> pulumi.Output[Sequence['outputs.WorkloadNetworkInterface']]:
        return pulumi.get(self, "network_interfaces")

    @property
    @pulumi.getter
    def slug(self) -> pulumi.Output[str]:
        return pulumi.get(self, "slug")

    @property
    @pulumi.getter
    def targets(self) -> pulumi.Output[Sequence['outputs.WorkloadTarget']]:
        return pulumi.get(self, "targets")

    @property
    @pulumi.getter
    def version(self) -> pulumi.Output[str]:
        return pulumi.get(self, "version")

    @property
    @pulumi.getter(name="virtualMachine")
    def virtual_machine(self) -> pulumi.Output[Optional['outputs.WorkloadVirtualMachine']]:
        return pulumi.get(self, "virtual_machine")

    @property
    @pulumi.getter(name="virtualMachineRuntimeEnvironment")
    def virtual_machine_runtime_environment(self) -> pulumi.Output[Optional['outputs.WorkloadVirtualMachineRuntimeEnvironment']]:
        return pulumi.get(self, "virtual_machine_runtime_environment")

    @property
    @pulumi.getter(name="volumeClaims")
    def volume_claims(self) -> pulumi.Output[Optional[Sequence['outputs.WorkloadVolumeClaim']]]:
        return pulumi.get(self, "volume_claims")

