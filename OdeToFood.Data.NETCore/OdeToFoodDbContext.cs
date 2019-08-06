using Microsoft.EntityFrameworkCore;
using OdeToFood.Core.NETCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Data.NETCore
{
    public class OdeToFoodDbContext : DbContext
    {
        public OdeToFoodDbContext(DbContextOptions<OdeToFoodDbContext> options) : base(options)
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
