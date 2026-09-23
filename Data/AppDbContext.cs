using Microsoft.EntityFrameworkCore;
using TP02.Models;

namespace TP02.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<BL> BLs { get; set; }
        public DbSet<Container> Containers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Mapeamento do relacionamento 1 para N (1 BL para N Containers)
            modelBuilder.Entity<Container>()
                .HasOne(c => c.BL)
                .WithMany(b => b.Containers)
                .HasForeignKey(c => c.BL_ID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}