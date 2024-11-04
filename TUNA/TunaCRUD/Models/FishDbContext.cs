using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TunaCRUD.Models
{
    public class FishDbContext : DbContext
    {
        public DbSet<FishInformation> FishInformations { get; set; }

        public FishDbContext() : base("name=FishDbConnection")
        {
        }
    }
}
