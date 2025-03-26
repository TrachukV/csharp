class Program
{

    static void Main()
    {
        IPrinter printer = new OfficeMachine();
        printer.Start();
        IScanner scanner = new OfficeMachine();
        scanner.Start();
        int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
        const byte initialSeconds = 5;
        Recursion.Countdown(initialSeconds);

        DimensionalArrays.GetResult();


        const byte age = 27;
        Console.WriteLine(age.GetTypeCode());


        string advice = Conditions.GetAdvice(age);
        Console.WriteLine(advice);

        const Season season = Season.Spring;
        string seasonName = Conditions.GetSeason(season);
        Console.WriteLine(seasonName);

        Loops.GenerateLogNum();
        Loops.PrintSeasonNames();


        string result = Input.GetUserInput();
        Console.WriteLine(result);

        // Console.ReadLine();
    }







}

