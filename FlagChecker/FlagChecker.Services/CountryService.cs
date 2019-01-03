using System;
using System.Collections.Generic;
using FlagChecker.Data.Models;
using FlagChecker.Data.Repositories;

namespace FlagChecker.Services
{
    public class CountryService : ICountryService
    {
        private ICountryRepository _countryRepository;
        private readonly int countriesTotal = Data.Properties.Settings.Default.countriesTotal;

        public CountryService(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public List<Country> GetAllCountries()
        {
            return _countryRepository.GetAllCountries();
        }

        public List<Country> GetCountriesByIds(List<string> idList)
        {
            return _countryRepository.GetCountriesByIds(idList);
        }

        public int GetContinentCount(string continent, List<Country>countries)
        {
            var continentCount = 0;

            for (int i = 0; i < countries.Count; i++)
            {
                if(countries[i].Continent == continent)
                {
                    continentCount++;
                }
            }

            return continentCount;
        }

        public int GetCountriesArea(List<Country>countries)
        {
            var countriesArea = 0; 

            for (int i = 0; i < countries.Count; i++)
            {
                countriesArea = countriesArea + countries[i].Area;
            }

            return countriesArea;
        }

        public double CountCountriesPercent(int countries)
        {
            return Math.Round(((double)countries / (countriesTotal-1)) * 100, 2);
        }

        public double CountCountriesAreaPercent(int totalArea)
        {
            int worldArea = 134940000;
            return Math.Round(((double)totalArea / worldArea) * 100, 2);
        }
    }
}


