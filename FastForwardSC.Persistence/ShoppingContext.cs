using FastForwardSC.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace FastForwardSC.Persistence
{
    public class ShoppingContext : DbContext
    {
        public ShoppingContext(DbContextOptions<ShoppingContext> options) : base(options){}

        public DbSet<Event> Events { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ConfigureRelationships(modelBuilder);
        }

        public static void ConfigureRelationships(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rating>().HasKey(x => new { x.UserId, x.ProductId });
        }
    }
}