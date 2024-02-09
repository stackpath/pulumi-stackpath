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
    [StackpathResourceType("stackpath:compute/networkSubnet:NetworkSubnet")]
    public partial class NetworkSubnet : global::Pulumi.CustomResource
    {
        [Output("annotations")]
        public Output<ImmutableDictionary<string, string>?> Annotations { get; private set; } = null!;

        [Output("labels")]
        public Output<ImmutableDictionary<string, string>?> Labels { get; private set; } = null!;

        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("networkId")]
        public Output<string> NetworkId { get; private set; } = null!;

        [Output("prefix")]
        public Output<string> Prefix { get; private set; } = null!;

        [Output("slug")]
        public Output<string> Slug { get; private set; } = null!;

        [Output("version")]
        public Output<string> Version { get; private set; } = null!;


        /// <summary>
        /// Create a NetworkSubnet resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public NetworkSubnet(string name, NetworkSubnetArgs args, CustomResourceOptions? options = null)
            : base("stackpath:compute/networkSubnet:NetworkSubnet", name, args ?? new NetworkSubnetArgs(), MakeResourceOptions(options, ""))
        {
        }

        private NetworkSubnet(string name, Input<string> id, NetworkSubnetState? state = null, CustomResourceOptions? options = null)
            : base("stackpath:compute/networkSubnet:NetworkSubnet", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "https://github.com/stackpath/pulumi-stackpath/releases/download/v${VERSION}",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing NetworkSubnet resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static NetworkSubnet Get(string name, Input<string> id, NetworkSubnetState? state = null, CustomResourceOptions? options = null)
        {
            return new NetworkSubnet(name, id, state, options);
        }
    }

    public sealed class NetworkSubnetArgs : global::Pulumi.ResourceArgs
    {
        [Input("annotations")]
        private InputMap<string>? _annotations;
        public InputMap<string> Annotations
        {
            get => _annotations ?? (_annotations = new InputMap<string>());
            set => _annotations = value;
        }

        [Input("labels")]
        private InputMap<string>? _labels;
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("networkId", required: true)]
        public Input<string> NetworkId { get; set; } = null!;

        [Input("prefix", required: true)]
        public Input<string> Prefix { get; set; } = null!;

        [Input("slug")]
        public Input<string>? Slug { get; set; }

        public NetworkSubnetArgs()
        {
        }
        public static new NetworkSubnetArgs Empty => new NetworkSubnetArgs();
    }

    public sealed class NetworkSubnetState : global::Pulumi.ResourceArgs
    {
        [Input("annotations")]
        private InputMap<string>? _annotations;
        public InputMap<string> Annotations
        {
            get => _annotations ?? (_annotations = new InputMap<string>());
            set => _annotations = value;
        }

        [Input("labels")]
        private InputMap<string>? _labels;
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("networkId")]
        public Input<string>? NetworkId { get; set; }

        [Input("prefix")]
        public Input<string>? Prefix { get; set; }

        [Input("slug")]
        public Input<string>? Slug { get; set; }

        [Input("version")]
        public Input<string>? Version { get; set; }

        public NetworkSubnetState()
        {
        }
        public static new NetworkSubnetState Empty => new NetworkSubnetState();
    }
}
