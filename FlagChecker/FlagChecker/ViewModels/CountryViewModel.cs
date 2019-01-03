using FlagChecker.Data.Models;
using System.Collections.Generic;

namespace FlagChecker.Models
{
    public class CountryViewModel
    {
        public List<Country> Countries { get; set; }
        public int CountriesCount { get; set; }
        public double CountriesPercent { get; set; }
        public string CountriesArea { get; set; }
        public double CountriesAreaPercent { get; set; }
        public int EuropeanCountriesCount { get; set; }
        public int AsianCountriesCount { get; set; }
        public int AfricanCountriesCount { get; set; }
        public int SAmericanCountriesCount { get; set; }
        public int NAmericanCountriesCount { get; set; }
        public int AustralianCountriesCount { get; set; }
        public string ShareLink { get; set; }
    }
}