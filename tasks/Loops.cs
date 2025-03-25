class Loops
{
	public static void PrintSeasonNames()
	{
		Season[] seasons = Enum.GetValues<Season>();
		string[] names = [.. seasons.Select(s => s.ToString())];
		foreach (var item in names)
		{
			Console.WriteLine(item);
		}
	}
	public static void GenerateLogNum()
	{
		List<int> ints = [.. Enumerable.Range(1, 8)];
		for (int i = 0; i < ints.Count; i++)
		{
			Console.WriteLine(ints[i]);
		}
	}
}