namespace variables.necessary_tasks.Fourth;

internal class ECar : Vehicle
{
    public ECar(ConsoleColor color, string manufacturer, sbyte gasLevel)
    {
        Color = color;
        Manufacturer = manufacturer;
        GasLevel = gasLevel;
    }

    public override void Drive()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("E-Motor is running.");
        Console.WriteLine("shhhhhhh....!");
        Console.ResetColor();
    }

}