using System.Collections.Generic;
using System.Linq;
using FlagChecker.Data.Models;

namespace FlagChecker.Data.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        public List<Country> GetAllCountries()
        {
            using (var context = new FlagCheckerContext())
            {
                return context.Countries.ToList();
            }
        }

        public Country GetCountryById(int id)
        {
            using (var context = new FlagCheckerContext())
            {
                return context.Countries.FirstOrDefault(u => u.Id == id);
            }
        }

        public List<Country> GetCountriesByIds(List<string> idList)
        {
            var list = new List<Country>();

            using (var context = new FlagCheckerContext())
            {
                foreach (var element in idList)
                {
                    list.Add(context.Countries.FirstOrDefault(u => u.Id.ToString() == element));
                }

                return list;
            }
        }
    }
}
