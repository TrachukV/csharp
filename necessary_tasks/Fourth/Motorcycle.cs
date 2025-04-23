namespace variables.necessary_tasks.Fourth;

internal  class Motorcycle : Vehicle
{
    public Motorcycle(ConsoleColor color, string manufacturer, sbyte gasLevel)
    {
        Color = color;
        Manufacturer = manufacturer;
        GasLevel = gasLevel;
    }
    
    public override void Drive()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Motorcycle is running.");
        Console.WriteLine("shhhhhhh....!");
    }

    public void PutHelmetOn()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Helmet suits well...");
        Console.WriteLine("Nice and sage!");
        Console.ResetColor();
    }
}