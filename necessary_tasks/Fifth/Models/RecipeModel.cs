
namespace variables.necessary_tasks.Fifth.Models;
public class RecipeModel
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public List<string>? Ingredients { get; set; }
    public List<string>? Instructions { get; set; }
    public int PrepTimeMinutes { get; set; }
    public int CookTimeMinutes { get; set; }
    public int Servings { get; set; }
    public string? Difficulty { get; set; }
    public string? Cuisine { get; set; }
    public double CaloriesPerServing { get; set; }
    public List<string>? Tags { get; set; }
    public int UserId { get; set; }
    public string? Image { get; set; }
    public double Rating { get; set; }
    public int ReviewCount { get; set; }
    public List<string> MealType { get; set; }
    
    public override string ToString()
    {
        string? ingredientsList = string.Join("\n- ", Ingredients);
        string? instructionsList = string.Join("\n> ", Instructions);
        string? tagsList = string.Join(", ", Tags);
        string? mealTypes = string.Join(", ", MealType);

        return $@"
Recipe: {Name} (ID: {Id})
Cuisine: {Cuisine}
Difficulty: {Difficulty}
Prep Time: {PrepTimeMinutes} min
Cook Time: {CookTimeMinutes} min
Servings: {Servings}
Calories per serving: {CaloriesPerServing}
Rating: {Rating} ({ReviewCount} reviews)
Tags: {tagsList}
Meal Type: {mealTypes}

Ingredients:
- {ingredientsList}

Instructions:
> {instructionsList}

Image URL: {Image}
Created by User ID: {UserId}
        ";
    }

}