namespace variables.necessary_tasks.Third;

internal class Third
{
    public static void DrawDiamond()
    {
        Console.Write("\nEnter number of rows: ");
        if (!int.TryParse(Console.ReadLine(), out int number) || number <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            return;
        }
        
        for (int row = 1; row <= number; row++)
        {
            _printSpaces(number - row);
            _printStars(2 * row - 1);
        }
        
        for (int row = number - 1; row >= 1; row--)
        {
            _printSpaces(number - row);
            _printStars(2 * row - 1);
        }
        
    }

    private static void _printSpaces(int count)
    {
        Console.Write(new string(' ', count));
    }

    private static void _printStars(int count)
    {
        Console.WriteLine(new string('*', count));
    }
}