// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Stackpath.Stackpath.Compute
{
    [StackpathResourceType("stackpath:compute/workload:Workload")]
    public partial class Workload : global::Pulumi.CustomResource
    {
        [Output("annotations")]
        public Output<ImmutableDictionary<string, string>> Annotations { get; private set; } = null!;

        [Output("containerRuntimeEnvironment")]
        public Output<Outputs.WorkloadContainerRuntimeEnvironment?> ContainerRuntimeEnvironment { get; private set; } = null!;

        [Output("containers")]
        public Output<ImmutableArray<Outputs.WorkloadContainer>> Containers { get; private set; } = null!;

        [Output("imagePullCredentials")]
        public Output<ImmutableArray<Outputs.WorkloadImagePullCredential>> ImagePullCredentials { get; private set; } = null!;

        [Output("initContainers")]
        public Output<ImmutableArray<Outputs.WorkloadInitContainer>> InitContainers { get; private set; } = null!;

        [Output("instances")]
        public Output<ImmutableArray<Outputs.WorkloadInstance>> Instances { get; private set; } = null!;

        [Output("labels")]
        public Output<ImmutableDictionary<string, object>?> Labels { get; private set; } = null!;

        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("networkInterfaces")]
        public Output<ImmutableArray<Outputs.WorkloadNetworkInterface>> NetworkInterfaces { get; private set; } = null!;

        [Output("slug")]
        public Output<string> Slug { get; private set; } = null!;

        [Output("targets")]
        public Output<ImmutableArray<Outputs.WorkloadTarget>> Targets { get; private set; } = null!;

        [Output("version")]
        public Output<string> Version { get; private set; } = null!;

        [Output("virtualMachine")]
        public Output<Outputs.WorkloadVirtualMachine?> VirtualMachine { get; private set; } = null!;

        [Output("virtualMachineRuntimeEnvironment")]
        public Output<Outputs.WorkloadVirtualMachineRuntimeEnvironment?> VirtualMachineRuntimeEnvironment { get; private set; } = null!;

        [Output("volumeClaims")]
        public Output<ImmutableArray<Outputs.WorkloadVolumeClaim>> VolumeClaims { get; private set; } = null!;


        /// <summary>
        /// Create a Workload resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Workload(string name, WorkloadArgs args, CustomResourceOptions? options = null)
            : base("stackpath:compute/workload:Workload", name, args ?? new WorkloadArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Workload(string name, Input<string> id, WorkloadState? state = null, CustomResourceOptions? options = null)
            : base("stackpath:compute/workload:Workload", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/stackpath/pulumi-stackpath",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Workload resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Workload Get(string name, Input<string> id, WorkloadState? state = null, CustomResourceOptions? options = null)
        {
            return new Workload(name, id, state, options);
        }
    }

    public sealed class WorkloadArgs : global::Pulumi.ResourceArgs
    {
        [Input("annotations")]
        private InputMap<string>? _annotations;
        public InputMap<string> Annotations
        {
            get => _annotations ?? (_annotations = new InputMap<string>());
            set => _annotations = value;
        }

        [Input("containerRuntimeEnvironment")]
        public Input<Inputs.WorkloadContainerRuntimeEnvironmentArgs>? ContainerRuntimeEnvironment { get; set; }

        [Input("containers")]
        private InputList<Inputs.WorkloadContainerArgs>? _containers;
        public InputList<Inputs.WorkloadContainerArgs> Containers
        {
            get => _containers ?? (_containers = new InputList<Inputs.WorkloadContainerArgs>());
            set => _containers = value;
        }

        [Input("imagePullCredentials")]
        private InputList<Inputs.WorkloadImagePullCredentialArgs>? _imagePullCredentials;
        public InputList<Inputs.WorkloadImagePullCredentialArgs> ImagePullCredentials
        {
            get => _imagePullCredentials ?? (_imagePullCredentials = new InputList<Inputs.WorkloadImagePullCredentialArgs>());
            set => _imagePullCredentials = value;
        }

        [Input("initContainers")]
        private InputList<Inputs.WorkloadInitContainerArgs>? _initContainers;
        public InputList<Inputs.WorkloadInitContainerArgs> InitContainers
        {
            get => _initContainers ?? (_initContainers = new InputList<Inputs.WorkloadInitContainerArgs>());
            set => _initContainers = value;
        }

        [Input("instances")]
        private InputList<Inputs.WorkloadInstanceArgs>? _instances;
        public InputList<Inputs.WorkloadInstanceArgs> Instances
        {
            get => _instances ?? (_instances = new InputList<Inputs.WorkloadInstanceArgs>());
            set => _instances = value;
        }

        [Input("labels")]
        private InputMap<object>? _labels;
        public InputMap<object> Labels
        {
            get => _labels ?? (_labels = new InputMap<object>());
            set => _labels = value;
        }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("networkInterfaces", required: true)]
        private InputList<Inputs.WorkloadNetworkInterfaceArgs>? _networkInterfaces;
        public InputList<Inputs.WorkloadNetworkInterfaceArgs> NetworkInterfaces
        {
            get => _networkInterfaces ?? (_networkInterfaces = new InputList<Inputs.WorkloadNetworkInterfaceArgs>());
            set => _networkInterfaces = value;
        }

        [Input("slug", required: true)]
        public Input<string> Slug { get; set; } = null!;

        [Input("targets", required: true)]
        private InputList<Inputs.WorkloadTargetArgs>? _targets;
        public InputList<Inputs.WorkloadTargetArgs> Targets
        {
            get => _targets ?? (_targets = new InputList<Inputs.WorkloadTargetArgs>());
            set => _targets = value;
        }

        [Input("virtualMachine")]
        public Input<Inputs.WorkloadVirtualMachineArgs>? VirtualMachine { get; set; }

        [Input("virtualMachineRuntimeEnvironment")]
        public Input<Inputs.WorkloadVirtualMachineRuntimeEnvironmentArgs>? VirtualMachineRuntimeEnvironment { get; set; }

        [Input("volumeClaims")]
        private InputList<Inputs.WorkloadVolumeClaimArgs>? _volumeClaims;
        public InputList<Inputs.WorkloadVolumeClaimArgs> VolumeClaims
        {
            get => _volumeClaims ?? (_volumeClaims = new InputList<Inputs.WorkloadVolumeClaimArgs>());
            set => _volumeClaims = value;
        }

        public WorkloadArgs()
        {
        }
        public static new WorkloadArgs Empty => new WorkloadArgs();
    }

    public sealed class WorkloadState : global::Pulumi.ResourceArgs
    {
        [Input("annotations")]
        private InputMap<string>? _annotations;
        public InputMap<string> Annotations
        {
            get => _annotations ?? (_annotations = new InputMap<string>());
            set => _annotations = value;
        }

        [Input("containerRuntimeEnvironment")]
        public Input<Inputs.WorkloadContainerRuntimeEnvironmentGetArgs>? ContainerRuntimeEnvironment { get; set; }

        [Input("containers")]
        private InputList<Inputs.WorkloadContainerGetArgs>? _containers;
        public InputList<Inputs.WorkloadContainerGetArgs> Containers
        {
            get => _containers ?? (_containers = new InputList<Inputs.WorkloadContainerGetArgs>());
            set => _containers = value;
        }

        [Input("imagePullCredentials")]
        private InputList<Inputs.WorkloadImagePullCredentialGetArgs>? _imagePullCredentials;
        public InputList<Inputs.WorkloadImagePullCredentialGetArgs> ImagePullCredentials
        {
            get => _imagePullCredentials ?? (_imagePullCredentials = new InputList<Inputs.WorkloadImagePullCredentialGetArgs>());
            set => _imagePullCredentials = value;
        }

        [Input("initContainers")]
        private InputList<Inputs.WorkloadInitContainerGetArgs>? _initContainers;
        public InputList<Inputs.WorkloadInitContainerGetArgs> InitContainers
        {
            get => _initContainers ?? (_initContainers = new InputList<Inputs.WorkloadInitContainerGetArgs>());
            set => _initContainers = value;
        }

        [Input("instances")]
        private InputList<Inputs.WorkloadInstanceGetArgs>? _instances;
        public InputList<Inputs.WorkloadInstanceGetArgs> Instances
        {
            get => _instances ?? (_instances = new InputList<Inputs.WorkloadInstanceGetArgs>());
            set => _instances = value;
        }

        [Input("labels")]
        private InputMap<object>? _labels;
        public InputMap<object> Labels
        {
            get => _labels ?? (_labels = new InputMap<object>());
            set => _labels = value;
        }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("networkInterfaces")]
        private InputList<Inputs.WorkloadNetworkInterfaceGetArgs>? _networkInterfaces;
        public InputList<Inputs.WorkloadNetworkInterfaceGetArgs> NetworkInterfaces
        {
            get => _networkInterfaces ?? (_networkInterfaces = new InputList<Inputs.WorkloadNetworkInterfaceGetArgs>());
            set => _networkInterfaces = value;
        }

        [Input("slug")]
        public Input<string>? Slug { get; set; }

        [Input("targets")]
        private InputList<Inputs.WorkloadTargetGetArgs>? _targets;
        public InputList<Inputs.WorkloadTargetGetArgs> Targets
        {
            get => _targets ?? (_targets = new InputList<Inputs.WorkloadTargetGetArgs>());
            set => _targets = value;
        }

        [Input("version")]
        public Input<string>? Version { get; set; }

        [Input("virtualMachine")]
        public Input<Inputs.WorkloadVirtualMachineGetArgs>? VirtualMachine { get; set; }

        [Input("virtualMachineRuntimeEnvironment")]
        public Input<Inputs.WorkloadVirtualMachineRuntimeEnvironmentGetArgs>? VirtualMachineRuntimeEnvironment { get; set; }

        [Input("volumeClaims")]
        private InputList<Inputs.WorkloadVolumeClaimGetArgs>? _volumeClaims;
        public InputList<Inputs.WorkloadVolumeClaimGetArgs> VolumeClaims
        {
            get => _volumeClaims ?? (_volumeClaims = new InputList<Inputs.WorkloadVolumeClaimGetArgs>());
            set => _volumeClaims = value;
        }

        public WorkloadState()
        {
        }
        public static new WorkloadState Empty => new WorkloadState();
    }
}
