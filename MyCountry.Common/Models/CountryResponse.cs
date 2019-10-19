using System;
using System.Collections.Generic;

namespace MyCountry.Common.Model
{
    public class CountryResponse
    {
        public string Name { get; set; }

        public ICollection<string> TopLevelDomain { get; set; }

        public string Alpha2Code { get; set; }

        public string Alpha3Code { get; set; }

        public ICollection<string> CallingCodes { get; set; }

        public string Capital { get; set; }

        public ICollection<string> AltSpellings { get; set; }

        public string Region { get; set; }

        public string Subregion { get; set; }

        public long Population { get; set; }

        public double[] Latlng { get; set; }

        public string Demonym { get; set; }

        public double? Area { get; set; }

        public double? Gini { get; set; }

        public ICollection<string> Timezones { get; set; }

        public ICollection<Object> Borders { get; set; }

        public string NativeName { get; set; }

        public string NumericCode { get; set; }

        public ICollection<Currency> Currencies { get; set; }

        public ICollection<Language> Languages { get; set; }

        public Translations Translations { get; set; }

        public string Flag { get; set; }

        public ICollection<object> RegionalBlocs { get; set; }

        public string Cioc { get; set; }
    }
}
