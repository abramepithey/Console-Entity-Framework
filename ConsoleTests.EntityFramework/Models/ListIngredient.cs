using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleTests.EntityFramework.Models
{
    public class ListIngredient
    {
        [Key]
        public Guid ListIngredientId { get; set; }
        public string UnitOfMeasure { get; set; }
        public int Quantity { get; set; }
        public bool IsActive { get; set; }
        public Guid IngredientId { get; set; }

        public Ingredient Ingredient { get; set; }
    }
}