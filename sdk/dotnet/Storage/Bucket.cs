// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Stackpath.Stackpath.Storage
{
    [StackpathResourceType("stackpath:storage/bucket:Bucket")]
    public partial class Bucket : global::Pulumi.CustomResource
    {
        [Output("endpointUrl")]
        public Output<string> EndpointUrl { get; private set; } = null!;

        [Output("label")]
        public Output<string> Label { get; private set; } = null!;

        [Output("region")]
        public Output<string> Region { get; private set; } = null!;

        [Output("visibility")]
        public Output<string?> Visibility { get; private set; } = null!;


        /// <summary>
        /// Create a Bucket resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Bucket(string name, BucketArgs args, CustomResourceOptions? options = null)
            : base("stackpath:storage/bucket:Bucket", name, args ?? new BucketArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Bucket(string name, Input<string> id, BucketState? state = null, CustomResourceOptions? options = null)
            : base("stackpath:storage/bucket:Bucket", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Bucket resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Bucket Get(string name, Input<string> id, BucketState? state = null, CustomResourceOptions? options = null)
        {
            return new Bucket(name, id, state, options);
        }
    }

    public sealed class BucketArgs : global::Pulumi.ResourceArgs
    {
        [Input("label", required: true)]
        public Input<string> Label { get; set; } = null!;

        [Input("region", required: true)]
        public Input<string> Region { get; set; } = null!;

        [Input("visibility")]
        public Input<string>? Visibility { get; set; }

        public BucketArgs()
        {
        }
        public static new BucketArgs Empty => new BucketArgs();
    }

    public sealed class BucketState : global::Pulumi.ResourceArgs
    {
        [Input("endpointUrl")]
        public Input<string>? EndpointUrl { get; set; }

        [Input("label")]
        public Input<string>? Label { get; set; }

        [Input("region")]
        public Input<string>? Region { get; set; }

        [Input("visibility")]
        public Input<string>? Visibility { get; set; }

        public BucketState()
        {
        }
        public static new BucketState Empty => new BucketState();
    }
}
