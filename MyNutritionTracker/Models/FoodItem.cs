using System.ComponentModel.DataAnnotations;

namespace MyNutritionTracker.Models
{
    public class FoodItem
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
        

    }
}
