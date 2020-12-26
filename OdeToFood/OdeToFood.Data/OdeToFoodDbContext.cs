using Microsoft.EntityFrameworkCore;
using OdeToFood.Core;
using System.Collections.Generic;

namespace OdeToFood.Data
{
    public class OdeToFoodDbContext : DbContext
    {
        public OdeToFoodDbContext(DbContextOptions<OdeToFoodDbContext> options) : base(options)
        {
                
        }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
