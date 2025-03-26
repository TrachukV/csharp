using System.IO;
using System.Text.Json;
class ReadPlayers
{
	public static List<PlayerModel> GetPlayersFromLocal()
	{
		var options = new JsonSerializerOptions
		{
			PropertyNameCaseInsensitive = true
		};

		string json = File.ReadAllText(@"C:\Users\Vladyslav\Develop\csharp_variables\tasks\assets\players.json");


		List<PlayerModel> players = JsonSerializer.Deserialize<List<PlayerModel>>(json,options) ?? [];

		return players;
	}
}