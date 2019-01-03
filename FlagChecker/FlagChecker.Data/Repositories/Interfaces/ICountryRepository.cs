using FlagChecker.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagChecker.Data.Repositories
{
    public interface ICountryRepository
    {
        List<Country> GetAllCountries();
        Country GetCountryById(int id);
        List<Country> GetCountriesByIds(List<string> idList);
    }
}
