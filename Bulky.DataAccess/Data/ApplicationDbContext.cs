using Bulky.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        //ctor-> tab tab-new constructor snippet
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DispalyOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DispalyOrder = 2 },
                new Category { Id = 3, Name = "History", DispalyOrder = 3 }
            );
        }
    }
}
