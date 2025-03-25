class DimensionalArrays
{
	public static void GetResult()
	{
		int[,] numatrix = { { 1, 4, 2 }, { 3, 6, 8 } };
		int sum = 0;

		foreach (int i in numatrix)
		{
			sum += i;
		}
		Console.WriteLine(sum);
	}
}