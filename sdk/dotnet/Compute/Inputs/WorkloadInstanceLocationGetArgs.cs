// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Stackpath.Stackpath.Compute.Inputs
{

    public sealed class WorkloadInstanceLocationGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("city")]
        public Input<string>? City { get; set; }

        [Input("cityCode")]
        public Input<string>? CityCode { get; set; }

        [Input("continent")]
        public Input<string>? Continent { get; set; }

        [Input("continentCode")]
        public Input<string>? ContinentCode { get; set; }

        [Input("country")]
        public Input<string>? Country { get; set; }

        [Input("countryCode")]
        public Input<string>? CountryCode { get; set; }

        [Input("latitude")]
        public Input<double>? Latitude { get; set; }

        [Input("longitude")]
        public Input<double>? Longitude { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("region")]
        public Input<string>? Region { get; set; }

        [Input("regionCode")]
        public Input<string>? RegionCode { get; set; }

        [Input("subdivision")]
        public Input<string>? Subdivision { get; set; }

        [Input("subdivisionCode")]
        public Input<string>? SubdivisionCode { get; set; }

        public WorkloadInstanceLocationGetArgs()
        {
        }
        public static new WorkloadInstanceLocationGetArgs Empty => new WorkloadInstanceLocationGetArgs();
    }
}
