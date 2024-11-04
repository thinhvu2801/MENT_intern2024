using Microsoft.EntityFrameworkCore;

namespace MVPPetManagement.Models
{
    public class PetDbContext : DbContext
    {
        public PetDbContext(DbContextOptions<PetDbContext> options) : base(options)
        {
        }

        public DbSet<PetModel> Pet { get; set; }
    }
}
