interface IPrinter
{
	void Start();
}

interface IScanner
{
	void Start();
}

class OfficeMachine : IPrinter, IScanner
{
	void IPrinter.Start()
	{
		Console.WriteLine("Printing started...");
	}
	void IScanner.Start()
	{
		Console.WriteLine("Scanning started...");
	}
}


