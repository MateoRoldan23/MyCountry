﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace MyCountry.Common.Model
{
    public partial class CountryResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("topLevelDomain")]
        public ICollection<string> TopLevelDomain { get; set; }

        [JsonProperty("alpha2Code")]
        public string Alpha2Code { get; set; }

        [JsonProperty("alpha3Code")]
        public string Alpha3Code { get; set; }

        [JsonProperty("callingCodes")]
        public ICollection<string> CallingCodes { get; set; }

        [JsonProperty("capital")]
        public string Capital { get; set; }

        [JsonProperty("altSpellings")]
        public ICollection<string> AltSpellings { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("subregion")]
        public string Subregion { get; set; }

        [JsonProperty("population")]
        public long Population { get; set; }

        [JsonProperty("latlng")]
        public ICollection<string> Latlng { get; set; }

        [JsonProperty("demonym")]
        public string Demonym { get; set; }

        [JsonProperty("area")]
        public double? Area { get; set; }

        [JsonProperty("gini")]
        public double? Gini { get; set; }

        [JsonProperty("timezones")]
        public ICollection<string> Timezones { get; set; }

        [JsonProperty("borders")]
        public ICollection<string> Borders { get; set; }

        [JsonProperty("nativeName")]
        public string NativeName { get; set; }

        [JsonProperty("numericCode")]
        public string NumericCode { get; set; }

        [JsonProperty("currencies")]
        public ICollection<Currency> Currencies { get; set; }

        [JsonProperty("languages")]
        public ICollection<Language> Languages { get; set; }

        [JsonProperty("translations")]
        public Translations Translations { get; set; }

        [JsonProperty("flag")]
        public string Flag { get; set; }

        [JsonProperty("regionalBlocs")]
        public ICollection<object> RegionalBlocs { get; set; }

        [JsonProperty("cioc")]
        public string Cioc { get; set; }
    }
}