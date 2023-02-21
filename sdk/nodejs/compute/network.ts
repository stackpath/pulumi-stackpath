// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

export class Network extends pulumi.CustomResource {
    /**
     * Get an existing Network resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: NetworkState, opts?: pulumi.CustomResourceOptions): Network {
        return new Network(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'stackpath:compute/network:Network';

    /**
     * Returns true if the given object is an instance of Network.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Network {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Network.__pulumiType;
    }

    public readonly annotations!: pulumi.Output<{[key: string]: string} | undefined>;
    public readonly labels!: pulumi.Output<{[key: string]: string} | undefined>;
    public readonly name!: pulumi.Output<string>;
    public readonly rootSubnet!: pulumi.Output<string>;
    public readonly slug!: pulumi.Output<string>;
    public /*out*/ readonly version!: pulumi.Output<string>;
    public /*out*/ readonly virtualNetworkIdentifier!: pulumi.Output<number>;

    /**
     * Create a Network resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: NetworkArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: NetworkArgs | NetworkState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as NetworkState | undefined;
            resourceInputs["annotations"] = state ? state.annotations : undefined;
            resourceInputs["labels"] = state ? state.labels : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["rootSubnet"] = state ? state.rootSubnet : undefined;
            resourceInputs["slug"] = state ? state.slug : undefined;
            resourceInputs["version"] = state ? state.version : undefined;
            resourceInputs["virtualNetworkIdentifier"] = state ? state.virtualNetworkIdentifier : undefined;
        } else {
            const args = argsOrState as NetworkArgs | undefined;
            if ((!args || args.rootSubnet === undefined) && !opts.urn) {
                throw new Error("Missing required property 'rootSubnet'");
            }
            if ((!args || args.slug === undefined) && !opts.urn) {
                throw new Error("Missing required property 'slug'");
            }
            resourceInputs["annotations"] = args ? args.annotations : undefined;
            resourceInputs["labels"] = args ? args.labels : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["rootSubnet"] = args ? args.rootSubnet : undefined;
            resourceInputs["slug"] = args ? args.slug : undefined;
            resourceInputs["version"] = undefined /*out*/;
            resourceInputs["virtualNetworkIdentifier"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Network.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Network resources.
 */
export interface NetworkState {
    annotations?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    name?: pulumi.Input<string>;
    rootSubnet?: pulumi.Input<string>;
    slug?: pulumi.Input<string>;
    version?: pulumi.Input<string>;
    virtualNetworkIdentifier?: pulumi.Input<number>;
}

/**
 * The set of arguments for constructing a Network resource.
 */
export interface NetworkArgs {
    annotations?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    name?: pulumi.Input<string>;
    rootSubnet: pulumi.Input<string>;
    slug: pulumi.Input<string>;
}