using FlagChecker.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagChecker.Data.Repositories
{
    public interface IShareRepository
    {
        void Save(string uid, DateTime date, byte[] countries);
        Share GetCountriesByUid(string uid);
    }
}
