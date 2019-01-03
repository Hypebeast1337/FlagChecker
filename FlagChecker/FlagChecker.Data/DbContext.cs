using System.Data.Entity;
using FlagChecker.Data.Models;

namespace FlagChecker.Data
{
    public class FlagCheckerContext : DbContext
    {
        public FlagCheckerContext()
        {
            
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Share> Shares { get; set; }
    }
}
