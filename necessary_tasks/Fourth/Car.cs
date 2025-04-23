namespace variables.necessary_tasks.Fourth;

internal class Car : Vehicle
{
    public Car(ConsoleColor color, string manufacturer, sbyte gasLevel)
    {
        Color = color;
        Manufacturer = manufacturer;
        GasLevel = gasLevel;
    }
    

    public override void Drive()
    {  
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Motor is running.");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Gas level: {GasLevel}");

        if (!_nextOrFinish())
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Car is broken.");
            Console.ResetColor();
            return;
        }

        const sbyte fuelConsumption = 1;
        GasLevel = (sbyte)(GasLevel - fuelConsumption);

        if (GasLevel <= 1)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Car stopped.");
            Console.ResetColor();
            return;
        }

        Drive();
    }

    private static bool _nextOrFinish()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Continue driving? (y/n)");
        string? userInput = Console.ReadLine();
        return userInput != null && userInput.ToLower() == "y";
    }

    public void OpenWindow()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Car window is opened.");
        Console.WriteLine("Ahh... Fresh Air!");
    }
    
    public void TurnOnRadio()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Car Radio is turned on.");
        Console.WriteLine("Övertorneå radio station!");
    }
}