class Recursion
{
	static public void Countdown(int second)

	{
		const int oneSecond = 1000;
		if (second < 0)
			throw new ArgumentException("Error: seconds must be >= 0");
		if (second == 0)
		{
			Console.WriteLine("GO!");
			return;
		}
		Console.WriteLine(second);
		Thread.Sleep(oneSecond);
		Countdown(second - 1);
	}
}