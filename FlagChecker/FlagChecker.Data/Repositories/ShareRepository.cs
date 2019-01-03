using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlagChecker.Data.Models;

namespace FlagChecker.Data.Repositories
{
    public class ShareRepository : IShareRepository
    {
        
        public void Save(string uid, DateTime date, byte[] countries)
        {
            using (var context = new FlagCheckerContext())
            {
                var entity = context.Set<Share>();
                var share = new Share {Uid = uid, Countries = countries, Date = date};

                entity.Add(share);
                context.SaveChanges();
            }
        }

        public Share GetCountriesByUid(string uid)
        {
            Share countries = new Share();

            using (var context = new FlagCheckerContext())
            {
                var shares = context.Shares.FirstOrDefault(x => x.Uid == uid);
                if (shares != null)
                    countries = shares;
            }
            return countries;
        }
    }
}
