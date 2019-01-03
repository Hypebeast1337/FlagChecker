using FlagChecker.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagChecker.Services
{
    public interface ICountryService
    {
        List<Country> GetAllCountries();
        List<Country> GetCountriesByIds(List<string> idList);
        int GetContinentCount(string continent, List<Country> countries);
        int GetCountriesArea(List<Country> countries);
        double CountCountriesPercent(int countries);
        double CountCountriesAreaPercent(int totalArea);
    }
}
