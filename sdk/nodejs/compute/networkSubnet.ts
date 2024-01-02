// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

export class NetworkSubnet extends pulumi.CustomResource {
    /**
     * Get an existing NetworkSubnet resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: NetworkSubnetState, opts?: pulumi.CustomResourceOptions): NetworkSubnet {
        return new NetworkSubnet(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'stackpath:compute/networkSubnet:NetworkSubnet';

    /**
     * Returns true if the given object is an instance of NetworkSubnet.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is NetworkSubnet {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === NetworkSubnet.__pulumiType;
    }

    public readonly annotations!: pulumi.Output<{[key: string]: string} | undefined>;
    public readonly labels!: pulumi.Output<{[key: string]: string} | undefined>;
    public readonly name!: pulumi.Output<string>;
    public readonly networkId!: pulumi.Output<string>;
    public readonly prefix!: pulumi.Output<string>;
    public readonly slug!: pulumi.Output<string>;
    public /*out*/ readonly version!: pulumi.Output<string>;

    /**
     * Create a NetworkSubnet resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: NetworkSubnetArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: NetworkSubnetArgs | NetworkSubnetState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as NetworkSubnetState | undefined;
            resourceInputs["annotations"] = state ? state.annotations : undefined;
            resourceInputs["labels"] = state ? state.labels : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["networkId"] = state ? state.networkId : undefined;
            resourceInputs["prefix"] = state ? state.prefix : undefined;
            resourceInputs["slug"] = state ? state.slug : undefined;
            resourceInputs["version"] = state ? state.version : undefined;
        } else {
            const args = argsOrState as NetworkSubnetArgs | undefined;
            if ((!args || args.networkId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'networkId'");
            }
            if ((!args || args.prefix === undefined) && !opts.urn) {
                throw new Error("Missing required property 'prefix'");
            }
            resourceInputs["annotations"] = args ? args.annotations : undefined;
            resourceInputs["labels"] = args ? args.labels : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["networkId"] = args ? args.networkId : undefined;
            resourceInputs["prefix"] = args ? args.prefix : undefined;
            resourceInputs["slug"] = args ? args.slug : undefined;
            resourceInputs["version"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(NetworkSubnet.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering NetworkSubnet resources.
 */
export interface NetworkSubnetState {
    annotations?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    name?: pulumi.Input<string>;
    networkId?: pulumi.Input<string>;
    prefix?: pulumi.Input<string>;
    slug?: pulumi.Input<string>;
    version?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a NetworkSubnet resource.
 */
export interface NetworkSubnetArgs {
    annotations?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    name?: pulumi.Input<string>;
    networkId: pulumi.Input<string>;
    prefix: pulumi.Input<string>;
    slug?: pulumi.Input<string>;
}
