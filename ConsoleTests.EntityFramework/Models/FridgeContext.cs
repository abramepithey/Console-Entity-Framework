using Microsoft.EntityFrameworkCore;

namespace ConsoleTests.EntityFramework.Models
{
    public class FridgeContext : DbContext
    {
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<ListIngredient> ListIngredients { get; set; }
        public DbSet<BoughtIngredient> BoughtIngredients { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=/Users/abrampithey/RiderProjects/ConsoleTests/ConsoleTests.EntityFramework/app.db");
        }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<ListIngredient>().HasOne(e => e.Ingredient).WithMany(e => e.ListIngredients)
        //         .HasForeignKey(e => e.IngredientId);
        //     
        //     modelBuilder.Entity<BoughtIngredient>().HasOne(b => b.Ingredient).WithMany(b => b.BoughtIngredients)
        //         .HasForeignKey(e => e.IngredientId);
        // }
    }
}