// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package compute

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type NetworkRoute struct {
	pulumi.CustomResourceState

	Annotations         pulumi.StringMapOutput                 `pulumi:"annotations"`
	DestinationPrefixes pulumi.StringArrayOutput               `pulumi:"destinationPrefixes"`
	GatewaySelectors    NetworkRouteGatewaySelectorArrayOutput `pulumi:"gatewaySelectors"`
	Labels              pulumi.StringMapOutput                 `pulumi:"labels"`
	Name                pulumi.StringOutput                    `pulumi:"name"`
	NetworkId           pulumi.StringOutput                    `pulumi:"networkId"`
	Slug                pulumi.StringOutput                    `pulumi:"slug"`
	Version             pulumi.StringOutput                    `pulumi:"version"`
}

// NewNetworkRoute registers a new resource with the given unique name, arguments, and options.
func NewNetworkRoute(ctx *pulumi.Context,
	name string, args *NetworkRouteArgs, opts ...pulumi.ResourceOption) (*NetworkRoute, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.DestinationPrefixes == nil {
		return nil, errors.New("invalid value for required argument 'DestinationPrefixes'")
	}
	if args.NetworkId == nil {
		return nil, errors.New("invalid value for required argument 'NetworkId'")
	}
	var resource NetworkRoute
	err := ctx.RegisterResource("stackpath:compute/networkRoute:NetworkRoute", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetNetworkRoute gets an existing NetworkRoute resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetNetworkRoute(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *NetworkRouteState, opts ...pulumi.ResourceOption) (*NetworkRoute, error) {
	var resource NetworkRoute
	err := ctx.ReadResource("stackpath:compute/networkRoute:NetworkRoute", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering NetworkRoute resources.
type networkRouteState struct {
	Annotations         map[string]string             `pulumi:"annotations"`
	DestinationPrefixes []string                      `pulumi:"destinationPrefixes"`
	GatewaySelectors    []NetworkRouteGatewaySelector `pulumi:"gatewaySelectors"`
	Labels              map[string]string             `pulumi:"labels"`
	Name                *string                       `pulumi:"name"`
	NetworkId           *string                       `pulumi:"networkId"`
	Slug                *string                       `pulumi:"slug"`
	Version             *string                       `pulumi:"version"`
}

type NetworkRouteState struct {
	Annotations         pulumi.StringMapInput
	DestinationPrefixes pulumi.StringArrayInput
	GatewaySelectors    NetworkRouteGatewaySelectorArrayInput
	Labels              pulumi.StringMapInput
	Name                pulumi.StringPtrInput
	NetworkId           pulumi.StringPtrInput
	Slug                pulumi.StringPtrInput
	Version             pulumi.StringPtrInput
}

func (NetworkRouteState) ElementType() reflect.Type {
	return reflect.TypeOf((*networkRouteState)(nil)).Elem()
}

type networkRouteArgs struct {
	Annotations         map[string]string             `pulumi:"annotations"`
	DestinationPrefixes []string                      `pulumi:"destinationPrefixes"`
	GatewaySelectors    []NetworkRouteGatewaySelector `pulumi:"gatewaySelectors"`
	Labels              map[string]string             `pulumi:"labels"`
	Name                *string                       `pulumi:"name"`
	NetworkId           string                        `pulumi:"networkId"`
	Slug                *string                       `pulumi:"slug"`
}

// The set of arguments for constructing a NetworkRoute resource.
type NetworkRouteArgs struct {
	Annotations         pulumi.StringMapInput
	DestinationPrefixes pulumi.StringArrayInput
	GatewaySelectors    NetworkRouteGatewaySelectorArrayInput
	Labels              pulumi.StringMapInput
	Name                pulumi.StringPtrInput
	NetworkId           pulumi.StringInput
	Slug                pulumi.StringPtrInput
}

func (NetworkRouteArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*networkRouteArgs)(nil)).Elem()
}

type NetworkRouteInput interface {
	pulumi.Input

	ToNetworkRouteOutput() NetworkRouteOutput
	ToNetworkRouteOutputWithContext(ctx context.Context) NetworkRouteOutput
}

func (*NetworkRoute) ElementType() reflect.Type {
	return reflect.TypeOf((**NetworkRoute)(nil)).Elem()
}

func (i *NetworkRoute) ToNetworkRouteOutput() NetworkRouteOutput {
	return i.ToNetworkRouteOutputWithContext(context.Background())
}

func (i *NetworkRoute) ToNetworkRouteOutputWithContext(ctx context.Context) NetworkRouteOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NetworkRouteOutput)
}

// NetworkRouteArrayInput is an input type that accepts NetworkRouteArray and NetworkRouteArrayOutput values.
// You can construct a concrete instance of `NetworkRouteArrayInput` via:
//
//          NetworkRouteArray{ NetworkRouteArgs{...} }
type NetworkRouteArrayInput interface {
	pulumi.Input

	ToNetworkRouteArrayOutput() NetworkRouteArrayOutput
	ToNetworkRouteArrayOutputWithContext(context.Context) NetworkRouteArrayOutput
}

type NetworkRouteArray []NetworkRouteInput

func (NetworkRouteArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*NetworkRoute)(nil)).Elem()
}

func (i NetworkRouteArray) ToNetworkRouteArrayOutput() NetworkRouteArrayOutput {
	return i.ToNetworkRouteArrayOutputWithContext(context.Background())
}

func (i NetworkRouteArray) ToNetworkRouteArrayOutputWithContext(ctx context.Context) NetworkRouteArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NetworkRouteArrayOutput)
}

// NetworkRouteMapInput is an input type that accepts NetworkRouteMap and NetworkRouteMapOutput values.
// You can construct a concrete instance of `NetworkRouteMapInput` via:
//
//          NetworkRouteMap{ "key": NetworkRouteArgs{...} }
type NetworkRouteMapInput interface {
	pulumi.Input

	ToNetworkRouteMapOutput() NetworkRouteMapOutput
	ToNetworkRouteMapOutputWithContext(context.Context) NetworkRouteMapOutput
}

type NetworkRouteMap map[string]NetworkRouteInput

func (NetworkRouteMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*NetworkRoute)(nil)).Elem()
}

func (i NetworkRouteMap) ToNetworkRouteMapOutput() NetworkRouteMapOutput {
	return i.ToNetworkRouteMapOutputWithContext(context.Background())
}

func (i NetworkRouteMap) ToNetworkRouteMapOutputWithContext(ctx context.Context) NetworkRouteMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NetworkRouteMapOutput)
}

type NetworkRouteOutput struct{ *pulumi.OutputState }

func (NetworkRouteOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**NetworkRoute)(nil)).Elem()
}

func (o NetworkRouteOutput) ToNetworkRouteOutput() NetworkRouteOutput {
	return o
}

func (o NetworkRouteOutput) ToNetworkRouteOutputWithContext(ctx context.Context) NetworkRouteOutput {
	return o
}

func (o NetworkRouteOutput) Annotations() pulumi.StringMapOutput {
	return o.ApplyT(func(v *NetworkRoute) pulumi.StringMapOutput { return v.Annotations }).(pulumi.StringMapOutput)
}

func (o NetworkRouteOutput) DestinationPrefixes() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *NetworkRoute) pulumi.StringArrayOutput { return v.DestinationPrefixes }).(pulumi.StringArrayOutput)
}

func (o NetworkRouteOutput) GatewaySelectors() NetworkRouteGatewaySelectorArrayOutput {
	return o.ApplyT(func(v *NetworkRoute) NetworkRouteGatewaySelectorArrayOutput { return v.GatewaySelectors }).(NetworkRouteGatewaySelectorArrayOutput)
}

func (o NetworkRouteOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v *NetworkRoute) pulumi.StringMapOutput { return v.Labels }).(pulumi.StringMapOutput)
}

func (o NetworkRouteOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *NetworkRoute) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

func (o NetworkRouteOutput) NetworkId() pulumi.StringOutput {
	return o.ApplyT(func(v *NetworkRoute) pulumi.StringOutput { return v.NetworkId }).(pulumi.StringOutput)
}

func (o NetworkRouteOutput) Slug() pulumi.StringOutput {
	return o.ApplyT(func(v *NetworkRoute) pulumi.StringOutput { return v.Slug }).(pulumi.StringOutput)
}

func (o NetworkRouteOutput) Version() pulumi.StringOutput {
	return o.ApplyT(func(v *NetworkRoute) pulumi.StringOutput { return v.Version }).(pulumi.StringOutput)
}

type NetworkRouteArrayOutput struct{ *pulumi.OutputState }

func (NetworkRouteArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*NetworkRoute)(nil)).Elem()
}

func (o NetworkRouteArrayOutput) ToNetworkRouteArrayOutput() NetworkRouteArrayOutput {
	return o
}

func (o NetworkRouteArrayOutput) ToNetworkRouteArrayOutputWithContext(ctx context.Context) NetworkRouteArrayOutput {
	return o
}

func (o NetworkRouteArrayOutput) Index(i pulumi.IntInput) NetworkRouteOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *NetworkRoute {
		return vs[0].([]*NetworkRoute)[vs[1].(int)]
	}).(NetworkRouteOutput)
}

type NetworkRouteMapOutput struct{ *pulumi.OutputState }

func (NetworkRouteMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*NetworkRoute)(nil)).Elem()
}

func (o NetworkRouteMapOutput) ToNetworkRouteMapOutput() NetworkRouteMapOutput {
	return o
}

func (o NetworkRouteMapOutput) ToNetworkRouteMapOutputWithContext(ctx context.Context) NetworkRouteMapOutput {
	return o
}

func (o NetworkRouteMapOutput) MapIndex(k pulumi.StringInput) NetworkRouteOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *NetworkRoute {
		return vs[0].(map[string]*NetworkRoute)[vs[1].(string)]
	}).(NetworkRouteOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*NetworkRouteInput)(nil)).Elem(), &NetworkRoute{})
	pulumi.RegisterInputType(reflect.TypeOf((*NetworkRouteArrayInput)(nil)).Elem(), NetworkRouteArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*NetworkRouteMapInput)(nil)).Elem(), NetworkRouteMap{})
	pulumi.RegisterOutputType(NetworkRouteOutput{})
	pulumi.RegisterOutputType(NetworkRouteArrayOutput{})
	pulumi.RegisterOutputType(NetworkRouteMapOutput{})
}
