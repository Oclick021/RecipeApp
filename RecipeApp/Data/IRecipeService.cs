using RecipeApp.Model;

namespace RecipeApp.Data
{
    public interface IRecipeService
    {
        void AddRecipe(Recipe newRecipe);
        void AddRecipe(string title, int calories, string desc, string imageLink, int timeToCook);
        void DeleteRecipe(int id);
        List<Recipe> GetRecipes();
    }
}