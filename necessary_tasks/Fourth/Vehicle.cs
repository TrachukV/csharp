namespace variables.necessary_tasks.Fourth;

internal abstract class Vehicle
{
    protected ConsoleColor Color { get; init; } = ConsoleColor.Black;
    protected string Manufacturer { get; init; } = String.Empty;
    protected sbyte GasLevel { get; set; } = 4;


    public abstract void Drive();

    public void GetDetails()
    {
        Console.Write("Color:");
        Console.ForegroundColor = Color;
        Console.Write($" {Color.ToString()}\n");
        Console.ResetColor();
        Console.WriteLine($"Vehicle brand: \n{Manufacturer}");
    }
}