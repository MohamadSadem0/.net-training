using Microsoft.EntityFrameworkCore;
using Restaurant.Domain.Entities;
namespace Restaurant.Infrastructure.Persistence;

internal class RestaurantDbContext :DbContext
{
        internal DbSet<Restaurants> Restaurants { get; set;}
        internal DbSet<Dish> Dishes { get; set;}
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer ("Server=DESKTOP-H92M2PS\\SQLEXPRESS;Database=RestaurantsDb;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Restaurants>()
            .OwnsOne(r=>r.Address);

            modelBuilder.Entity<Restaurants>()
            .HasMany(r=>r.Dishes)
            .WithOne()
            .HasForeignKey(d=>d.RestaurantId);
            
        }
    }