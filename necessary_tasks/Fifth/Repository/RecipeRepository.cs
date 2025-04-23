

using variables.necessary_tasks.Fifth.Models;

namespace variables.necessary_tasks.Fifth.Repository;

using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

public class RecipeRepository
{
    private readonly HttpClient _httpClient = new HttpClient();
    private const string ApiUrl = "https://dummyjson.com/";

    public async Task<List<RecipeModel>> GetAllRecipes()
    {
        const string endpoint = "recipes";
        const string fullUrl = ApiUrl + endpoint;

        try
        {
            var response = await _httpClient.GetFromJsonAsync<RecipeResponse>(fullUrl);
            return response?.Recipes ?? new List<RecipeModel>();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error fetching recipes: {ex.Message}");
            return new List<RecipeModel>();
        }
    }
}