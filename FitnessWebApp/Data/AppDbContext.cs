using FitnessWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessWebApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Ingredient>(ib =>
            {
                ib.Property(i => i.Protein)
                     .HasColumnType("decimal(10,2)");
                ib.Property(i => i.Name)
                     .HasMaxLength(200);
            });
        }
    }
}
