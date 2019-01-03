using FlagChecker.Data.Models;
using System.Collections.Generic;

namespace FlagChecker.Services
{
    public interface IHelperService
    {
        List<Country> SortCountries(List<Country> list);

        byte[] Serialize(List<Country> tData);

        List<Country> Deserialize(byte[] tData);
    }
}
