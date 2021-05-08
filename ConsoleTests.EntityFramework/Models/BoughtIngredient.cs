using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleTests.EntityFramework.Models
{
    public class BoughtIngredient
    {
        [Key]
        public Guid BoughtIngredientId { get; set; }
        public string UnitOfMeasure { get; set; }
        public int Quantity { get; set; }
        public DateTime DateBought { get; set; }
        public DateTime? Expiration { get; set; }
        public Guid IngredientId { get; set; }
        
        public Ingredient Ingredient { get; set; }
    }
}