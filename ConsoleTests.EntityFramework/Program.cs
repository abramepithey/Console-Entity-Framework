using System;
using ConsoleTests.EntityFramework.Models;

namespace ConsoleTests.EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            FridgeContext context = new FridgeContext();

            var salt = new Ingredient
            {
                Name = "Salt",
                Description = "Salty lead of the four flavors of the Alickmylips"
            };

            context.Ingredients.Add(salt);
            
            var pepper = new Ingredient
            {
                Name = "Pepper",
                Description = "Spicy."
            };

            context.Add(pepper);

            context.SaveChanges();
        }
    }
}