using RecipeApp.Model;

namespace RecipeApp.Data
{
    public class RecipeService : IRecipeService
    {
        public static List<Recipe> Recipes { get; set; }

        public RecipeService()
        {
            if (Recipes is null)
            {
                Recipes = new List<Recipe>();
                //Recipe recipe1 = new Recipe();
                //recipe1.Title = "Margarita Pizza";
                //recipe1.Calories = 1000;
                //recipe1.TimeToCook = 10;
                //recipe1.Description = "Delicious pizza from the heart of Napoli!";
                //recipe1.Id = 1;
                //recipes.Add(recipe1);

                Recipes.Add(new Recipe()
                {
                    Id = 1,
                    Title = "Margarita Pizza",
                    Calories = 1000,
                    Description = "Delicious pizza from the heart of Napoli!",
                    TimeToCook = 10,
                    ImageLink = "https://kookidee.nl/wp-content/uploads/2018/11/pizza-margherita.jpg"
                });

                Recipes.Add(new Recipe()
                {
                    Id = 2,
                    Title = "BBQ Chicken",
                    Calories = 800,
                    Description = "The best BBQ chicken breast recipe doesn’t call for complicated marinades or rubs. It’s all about this easy on-the-grill or in-the-oven cooking method sweetened with BBQ sauce for moist and juicy barbecue chicken breasts every time.\r\n\r\n",
                    TimeToCook = 45,
                    ImageLink = "https://www.foodiecrush.com/wp-content/uploads/2019/07/BBQ-Chicken-Breasts-foodiecrush.com-012-683x1024.jpg.webp"
                });

                Recipes.Add(new Recipe()
                {
                    Id = 3,
                    Title = "Stuffed Bell Peppers",
                    Calories = 1121,
                    Description = "Classic stuffed peppers with rice, ground beef, and a healthy rainbow of sweet red, yellow and orange bell peppers makes the best easy dinner idea any night of the week",
                    TimeToCook = 25,
                    ImageLink = "https://www.foodiecrush.com/wp-content/uploads/2014/09/Stuffed-Bell-Peppers-foodiecrush.com-081.jpg"
                });
            }


        }
        public List<Recipe> GetRecipes()
        {
            return Recipes;
        }

        public void AddRecipe(Recipe newRecipe)
        {
            newRecipe.Id = Recipes.Max(x => x.Id) + 1;
            Recipes.Add(newRecipe);
        }
        public void AddRecipe(string title, int calories, string desc, string imageLink, int timeToCook)
        {
            var recipe = new Recipe()
            {
                Id = Recipes.Max(x => x.Id) + 1,
                Title = title,
                Calories = calories,
                Description = desc,
                ImageLink = imageLink,
                TimeToCook = timeToCook
            };
            Recipes.Add(recipe);
        }
        public void DeleteRecipe(int id)
        {
            var recipe = Recipes.Where(x => x.Id == id).FirstOrDefault();
            if (recipe != null)
            {
                Recipes.Remove(recipe);
            }
        }
    }
}
