using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using FlagChecker.Common;
using FlagChecker.Data.Models;

namespace FlagChecker.Services
{
    public class HelperService : IHelperService
    {
        public List<Country> SortCountries(List<Country> list)
        {
            try
            {
                if (CultureInfo.CurrentCulture.Name == "pl-PL")
                {
                    return list.OrderBy(o => o.NamePl).ToList();
                }
                if (CultureInfo.CurrentCulture.Name == "en-US")
                {
                    return list.OrderBy(o => o.NameEn).ToList();
                }
            }
            catch (Exception ex)
            {
                new LogHelpers(ex.ToString());
                return list;
            }
            return list;
        }

        public byte[] Serialize(List<Country> tData)
        {
            using (var ms = new MemoryStream())
            {
                ProtoBuf.Serializer.Serialize(ms, tData);
                return ms.ToArray();
            }
        }

        public List<Country> Deserialize(byte[] tData)
        {
            try
            {
                using (var ms = new MemoryStream(tData))
                {
                    return ProtoBuf.Serializer.Deserialize<List<Country>>(ms);
                }
            }
            catch (Exception ex)
            {
                new LogHelpers(ex.ToString());
                return null;
            }
        }

    }
}
