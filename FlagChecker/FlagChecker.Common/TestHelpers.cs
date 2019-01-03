using System.Collections.Generic;
using FlagChecker.Data.Models;
using Ploeh.AutoFixture;

namespace FlagChecker.Common
{
    public class TestHelpers
    {
        public List<Country> ProvideSampleCountries()
        {
            var fixture = new Fixture();
            var list = new List<Country>();

            Country country = new Country
            {
                Area = 1337,
                Code = "FU",
                Continent = "Africa",
                Id = 13,
                Source = "Damn.png",
                NameEn = "English",
                NamePl = "Polish"
            };

            Country country2 = fixture.Create<Country>();
            list.Add(country);
            list.Add(country2);

            return list;
        }
    }
}
