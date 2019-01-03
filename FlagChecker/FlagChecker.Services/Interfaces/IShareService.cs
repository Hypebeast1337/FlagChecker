using FlagChecker.Data.Models;
using System;
using System.Collections.Generic;

namespace FlagChecker.Services
{
    public interface IShareService
    {
        string GenerateGuid();
        void SaveShareLink(string uid, DateTime date, List<Country> countries);
        List<Country> GetCountriesByShareUid(string uid);
    }
}
