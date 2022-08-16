using System.ComponentModel.DataAnnotations;

namespace RecipeApp.Model
{
    public class Recipe
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public int? TimeToCook { get; set; }
        public int? Calories { get; set; }

        [Required]
        public string ImageLink { get; set; }

    }
}
