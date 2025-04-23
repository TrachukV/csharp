using variables.necessary_tasks.Fifth.Models;
using variables.necessary_tasks.Fifth.Repository;

namespace variables.necessary_tasks.Fifth;

internal class Fifth
{
    public void GetRandomRecipe()
    {
        List<RecipeModel> recipes = new RecipeRepository().GetAllRecipes().Result;
        int randomIndex = new Random().Next(0, recipes.Count);
        RecipeModel recipe = recipes[randomIndex];
        Console.WriteLine(recipe.ToString());
    }
}