// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Stackpath.Compute.Outputs
{

    [OutputType]
    public sealed class WorkloadInstanceLocation
    {
        public readonly string? City;
        public readonly string? CityCode;
        public readonly string? Continent;
        public readonly string? ContinentCode;
        public readonly string? Country;
        public readonly string? CountryCode;
        public readonly double? Latitude;
        public readonly double? Longitude;
        public readonly string? Name;
        public readonly string? Region;
        public readonly string? RegionCode;
        public readonly string? Subdivision;
        public readonly string? SubdivisionCode;

        [OutputConstructor]
        private WorkloadInstanceLocation(
            string? city,

            string? cityCode,

            string? continent,

            string? continentCode,

            string? country,

            string? countryCode,

            double? latitude,

            double? longitude,

            string? name,

            string? region,

            string? regionCode,

            string? subdivision,

            string? subdivisionCode)
        {
            City = city;
            CityCode = cityCode;
            Continent = continent;
            ContinentCode = continentCode;
            Country = country;
            CountryCode = countryCode;
            Latitude = latitude;
            Longitude = longitude;
            Name = name;
            Region = region;
            RegionCode = regionCode;
            Subdivision = subdivision;
            SubdivisionCode = subdivisionCode;
        }
    }
}
