using FlowerShop.Models;
using Microsoft.EntityFrameworkCore;

namespace FlowerShop.Data
{
    public class MagazinDbContext : DbContext
    {
        public MagazinDbContext(DbContextOptions<MagazinDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Produs> Prosuse { get; set; }
        public DbSet<User> Users { get; set; }


    }
}
