using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner.Data.Entities
{
    public class Meal
    {
        [Key]
        public int Id { get; set; }
        public int Index { get; set; }
        public Guid UserId { get; set; }

        // nav props
        public virtual ICollection<MealIngredient> MealIngredients { get; set; } = new List<MealIngredient>();
    }
}
