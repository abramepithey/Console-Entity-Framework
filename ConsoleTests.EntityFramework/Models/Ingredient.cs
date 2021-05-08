using System;
using System.Collections.Generic;

namespace ConsoleTests.EntityFramework.Models
{
    public class Ingredient
    {
        public Guid IngredientId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        public virtual ICollection<ListIngredient> ListIngredients { get; set; }
        public virtual ICollection<BoughtIngredient> BoughtIngredients { get; set; }
    }
}