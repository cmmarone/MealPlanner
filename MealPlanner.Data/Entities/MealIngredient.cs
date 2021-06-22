using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner.Data.Entities
{
    public class MealIngredient
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Meal))]
        public int MealId { get; set; }
        [ForeignKey(nameof(Ingredient))]
        public int IngredientId { get; set; }
        public int Amount { get; set; }
        public Guid UserId { get; set; }

        // nav props
        public virtual Meal Meal { get; set; }
        public virtual Ingredient Ingredient { get; set; }
    }
}
