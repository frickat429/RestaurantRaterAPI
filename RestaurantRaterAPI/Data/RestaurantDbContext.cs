using Microsoft.EntityFrameworkCore;
using RestaurantRaterAPI.Data;

namespace RestaurantRaterAPI;

public class RestaurantDbContext : DbContext
{
    public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : base(options) {  } 
    
    public DbSet<Restaurant> Restaurants { get; set; } 
    public DbSet<Rating> Ratings { get; set; }
}