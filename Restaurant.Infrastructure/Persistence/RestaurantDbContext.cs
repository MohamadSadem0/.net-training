using Microsoft.EntityFrameworkCore;
using Restaurant.Domain.Entities;
namespace Restaurant.Infrastructure.Persistence;

internal class RestaurantDbContext (DbContextOptions<RestaurantDbContext> options) :DbContext(options)
{
        internal DbSet<Restaurants> Restaurants { get; set;}
        internal DbSet<Dish> Dishes { get; set;}
        

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