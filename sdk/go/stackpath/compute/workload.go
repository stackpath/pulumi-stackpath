// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package compute

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type Workload struct {
	pulumi.CustomResourceState

	Annotations          pulumi.StringMapOutput                 `pulumi:"annotations"`
	Containers           WorkloadContainerArrayOutput           `pulumi:"containers"`
	ImagePullCredentials WorkloadImagePullCredentialArrayOutput `pulumi:"imagePullCredentials"`
	Instances            WorkloadInstanceArrayOutput            `pulumi:"instances"`
	Labels               pulumi.MapOutput                       `pulumi:"labels"`
	Name                 pulumi.StringOutput                    `pulumi:"name"`
	NetworkInterfaces    WorkloadNetworkInterfaceArrayOutput    `pulumi:"networkInterfaces"`
	Slug                 pulumi.StringOutput                    `pulumi:"slug"`
	Targets              WorkloadTargetArrayOutput              `pulumi:"targets"`
	VirtualMachine       WorkloadVirtualMachinePtrOutput        `pulumi:"virtualMachine"`
	VolumeClaims         WorkloadVolumeClaimArrayOutput         `pulumi:"volumeClaims"`
}

// NewWorkload registers a new resource with the given unique name, arguments, and options.
func NewWorkload(ctx *pulumi.Context,
	name string, args *WorkloadArgs, opts ...pulumi.ResourceOption) (*Workload, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.NetworkInterfaces == nil {
		return nil, errors.New("invalid value for required argument 'NetworkInterfaces'")
	}
	if args.Slug == nil {
		return nil, errors.New("invalid value for required argument 'Slug'")
	}
	if args.Targets == nil {
		return nil, errors.New("invalid value for required argument 'Targets'")
	}
	var resource Workload
	err := ctx.RegisterResource("stackpath:compute/workload:Workload", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWorkload gets an existing Workload resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWorkload(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WorkloadState, opts ...pulumi.ResourceOption) (*Workload, error) {
	var resource Workload
	err := ctx.ReadResource("stackpath:compute/workload:Workload", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Workload resources.
type workloadState struct {
	Annotations          map[string]string             `pulumi:"annotations"`
	Containers           []WorkloadContainer           `pulumi:"containers"`
	ImagePullCredentials []WorkloadImagePullCredential `pulumi:"imagePullCredentials"`
	Instances            []WorkloadInstance            `pulumi:"instances"`
	Labels               map[string]interface{}        `pulumi:"labels"`
	Name                 *string                       `pulumi:"name"`
	NetworkInterfaces    []WorkloadNetworkInterface    `pulumi:"networkInterfaces"`
	Slug                 *string                       `pulumi:"slug"`
	Targets              []WorkloadTarget              `pulumi:"targets"`
	VirtualMachine       *WorkloadVirtualMachine       `pulumi:"virtualMachine"`
	VolumeClaims         []WorkloadVolumeClaim         `pulumi:"volumeClaims"`
}

type WorkloadState struct {
	Annotations          pulumi.StringMapInput
	Containers           WorkloadContainerArrayInput
	ImagePullCredentials WorkloadImagePullCredentialArrayInput
	Instances            WorkloadInstanceArrayInput
	Labels               pulumi.MapInput
	Name                 pulumi.StringPtrInput
	NetworkInterfaces    WorkloadNetworkInterfaceArrayInput
	Slug                 pulumi.StringPtrInput
	Targets              WorkloadTargetArrayInput
	VirtualMachine       WorkloadVirtualMachinePtrInput
	VolumeClaims         WorkloadVolumeClaimArrayInput
}

func (WorkloadState) ElementType() reflect.Type {
	return reflect.TypeOf((*workloadState)(nil)).Elem()
}

type workloadArgs struct {
	Annotations          map[string]string             `pulumi:"annotations"`
	Containers           []WorkloadContainer           `pulumi:"containers"`
	ImagePullCredentials []WorkloadImagePullCredential `pulumi:"imagePullCredentials"`
	Instances            []WorkloadInstance            `pulumi:"instances"`
	Labels               map[string]interface{}        `pulumi:"labels"`
	Name                 *string                       `pulumi:"name"`
	NetworkInterfaces    []WorkloadNetworkInterface    `pulumi:"networkInterfaces"`
	Slug                 string                        `pulumi:"slug"`
	Targets              []WorkloadTarget              `pulumi:"targets"`
	VirtualMachine       *WorkloadVirtualMachine       `pulumi:"virtualMachine"`
	VolumeClaims         []WorkloadVolumeClaim         `pulumi:"volumeClaims"`
}

// The set of arguments for constructing a Workload resource.
type WorkloadArgs struct {
	Annotations          pulumi.StringMapInput
	Containers           WorkloadContainerArrayInput
	ImagePullCredentials WorkloadImagePullCredentialArrayInput
	Instances            WorkloadInstanceArrayInput
	Labels               pulumi.MapInput
	Name                 pulumi.StringPtrInput
	NetworkInterfaces    WorkloadNetworkInterfaceArrayInput
	Slug                 pulumi.StringInput
	Targets              WorkloadTargetArrayInput
	VirtualMachine       WorkloadVirtualMachinePtrInput
	VolumeClaims         WorkloadVolumeClaimArrayInput
}

func (WorkloadArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*workloadArgs)(nil)).Elem()
}

type WorkloadInput interface {
	pulumi.Input

	ToWorkloadOutput() WorkloadOutput
	ToWorkloadOutputWithContext(ctx context.Context) WorkloadOutput
}

func (*Workload) ElementType() reflect.Type {
	return reflect.TypeOf((**Workload)(nil)).Elem()
}

func (i *Workload) ToWorkloadOutput() WorkloadOutput {
	return i.ToWorkloadOutputWithContext(context.Background())
}

func (i *Workload) ToWorkloadOutputWithContext(ctx context.Context) WorkloadOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WorkloadOutput)
}

// WorkloadArrayInput is an input type that accepts WorkloadArray and WorkloadArrayOutput values.
// You can construct a concrete instance of `WorkloadArrayInput` via:
//
//          WorkloadArray{ WorkloadArgs{...} }
type WorkloadArrayInput interface {
	pulumi.Input

	ToWorkloadArrayOutput() WorkloadArrayOutput
	ToWorkloadArrayOutputWithContext(context.Context) WorkloadArrayOutput
}

type WorkloadArray []WorkloadInput

func (WorkloadArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Workload)(nil)).Elem()
}

func (i WorkloadArray) ToWorkloadArrayOutput() WorkloadArrayOutput {
	return i.ToWorkloadArrayOutputWithContext(context.Background())
}

func (i WorkloadArray) ToWorkloadArrayOutputWithContext(ctx context.Context) WorkloadArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WorkloadArrayOutput)
}

// WorkloadMapInput is an input type that accepts WorkloadMap and WorkloadMapOutput values.
// You can construct a concrete instance of `WorkloadMapInput` via:
//
//          WorkloadMap{ "key": WorkloadArgs{...} }
type WorkloadMapInput interface {
	pulumi.Input

	ToWorkloadMapOutput() WorkloadMapOutput
	ToWorkloadMapOutputWithContext(context.Context) WorkloadMapOutput
}

type WorkloadMap map[string]WorkloadInput

func (WorkloadMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Workload)(nil)).Elem()
}

func (i WorkloadMap) ToWorkloadMapOutput() WorkloadMapOutput {
	return i.ToWorkloadMapOutputWithContext(context.Background())
}

func (i WorkloadMap) ToWorkloadMapOutputWithContext(ctx context.Context) WorkloadMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WorkloadMapOutput)
}

type WorkloadOutput struct{ *pulumi.OutputState }

func (WorkloadOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Workload)(nil)).Elem()
}

func (o WorkloadOutput) ToWorkloadOutput() WorkloadOutput {
	return o
}

func (o WorkloadOutput) ToWorkloadOutputWithContext(ctx context.Context) WorkloadOutput {
	return o
}

func (o WorkloadOutput) Annotations() pulumi.StringMapOutput {
	return o.ApplyT(func(v *Workload) pulumi.StringMapOutput { return v.Annotations }).(pulumi.StringMapOutput)
}

func (o WorkloadOutput) Containers() WorkloadContainerArrayOutput {
	return o.ApplyT(func(v *Workload) WorkloadContainerArrayOutput { return v.Containers }).(WorkloadContainerArrayOutput)
}

func (o WorkloadOutput) ImagePullCredentials() WorkloadImagePullCredentialArrayOutput {
	return o.ApplyT(func(v *Workload) WorkloadImagePullCredentialArrayOutput { return v.ImagePullCredentials }).(WorkloadImagePullCredentialArrayOutput)
}

func (o WorkloadOutput) Instances() WorkloadInstanceArrayOutput {
	return o.ApplyT(func(v *Workload) WorkloadInstanceArrayOutput { return v.Instances }).(WorkloadInstanceArrayOutput)
}

func (o WorkloadOutput) Labels() pulumi.MapOutput {
	return o.ApplyT(func(v *Workload) pulumi.MapOutput { return v.Labels }).(pulumi.MapOutput)
}

func (o WorkloadOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *Workload) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

func (o WorkloadOutput) NetworkInterfaces() WorkloadNetworkInterfaceArrayOutput {
	return o.ApplyT(func(v *Workload) WorkloadNetworkInterfaceArrayOutput { return v.NetworkInterfaces }).(WorkloadNetworkInterfaceArrayOutput)
}

func (o WorkloadOutput) Slug() pulumi.StringOutput {
	return o.ApplyT(func(v *Workload) pulumi.StringOutput { return v.Slug }).(pulumi.StringOutput)
}

func (o WorkloadOutput) Targets() WorkloadTargetArrayOutput {
	return o.ApplyT(func(v *Workload) WorkloadTargetArrayOutput { return v.Targets }).(WorkloadTargetArrayOutput)
}

func (o WorkloadOutput) VirtualMachine() WorkloadVirtualMachinePtrOutput {
	return o.ApplyT(func(v *Workload) WorkloadVirtualMachinePtrOutput { return v.VirtualMachine }).(WorkloadVirtualMachinePtrOutput)
}

func (o WorkloadOutput) VolumeClaims() WorkloadVolumeClaimArrayOutput {
	return o.ApplyT(func(v *Workload) WorkloadVolumeClaimArrayOutput { return v.VolumeClaims }).(WorkloadVolumeClaimArrayOutput)
}

type WorkloadArrayOutput struct{ *pulumi.OutputState }

func (WorkloadArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Workload)(nil)).Elem()
}

func (o WorkloadArrayOutput) ToWorkloadArrayOutput() WorkloadArrayOutput {
	return o
}

func (o WorkloadArrayOutput) ToWorkloadArrayOutputWithContext(ctx context.Context) WorkloadArrayOutput {
	return o
}

func (o WorkloadArrayOutput) Index(i pulumi.IntInput) WorkloadOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *Workload {
		return vs[0].([]*Workload)[vs[1].(int)]
	}).(WorkloadOutput)
}

type WorkloadMapOutput struct{ *pulumi.OutputState }

func (WorkloadMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Workload)(nil)).Elem()
}

func (o WorkloadMapOutput) ToWorkloadMapOutput() WorkloadMapOutput {
	return o
}

func (o WorkloadMapOutput) ToWorkloadMapOutputWithContext(ctx context.Context) WorkloadMapOutput {
	return o
}

func (o WorkloadMapOutput) MapIndex(k pulumi.StringInput) WorkloadOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *Workload {
		return vs[0].(map[string]*Workload)[vs[1].(string)]
	}).(WorkloadOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*WorkloadInput)(nil)).Elem(), &Workload{})
	pulumi.RegisterInputType(reflect.TypeOf((*WorkloadArrayInput)(nil)).Elem(), WorkloadArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*WorkloadMapInput)(nil)).Elem(), WorkloadMap{})
	pulumi.RegisterOutputType(WorkloadOutput{})
	pulumi.RegisterOutputType(WorkloadArrayOutput{})
	pulumi.RegisterOutputType(WorkloadMapOutput{})
}
