using Microsoft.EntityFrameworkCore;

namespace Restaurant.Infrastructure.Persistence
{
    internal class RestaurantDbContext :DbContext
    {
        internal DbSet<Restaurant> Restaurants { get; set;}
        internal DbSet<Dish> Dishes { get; set;}
    }

    protected override void OnConfiguring(DbContxtOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer ("")
    }
}