class Second
{

	private static int[] CalcFibonacciSeries(int count)
	{
		int a = 0;
		int b = 1;
		int[] series = new int[count];
		for (int index = 0; index < count; index++)
		{
			series[index] = a;
			int temproraryInt = a;
			a = b;
			b = temproraryInt + b;

		}
		return series;
	}
	public static void GetFibonacciSeries()
	{
		string? userInput = Console.ReadLine();
		if (int.TryParse(userInput, out int parsedCount))
		{
			int[] fib = CalcFibonacciSeries(parsedCount);
			Console.WriteLine("Fibonacci series:");
			foreach (int number in fib)
			{
				Console.Write(number + " ");
			}
		}
		else
		{
			Console.WriteLine("Invalid number!");
		}
	}
}