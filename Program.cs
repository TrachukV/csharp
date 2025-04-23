using variables.necessary_tasks.Fifth;
using variables.necessary_tasks.Fourth;
using variables.necessary_tasks.Quiz_Game;
using variables.necessary_tasks.Third;

class Program
{
    static void Main()
    {
        //I did this tasks for myself when I was studying topics on the course. 
        // Runner.RunTasks();
        
        // Task 1
        ShowTaskHeader(1, "Check whether a given substring is present in the given string.");
        Console.WriteLine(First.IsContains("IT-kompetens är en färskvara.", "IT"));
   

        // Task 2
        ShowTaskHeader(2, "Create function to display the n number Fibonacci series.");
        Second.GetFibonacciSeries();


        // Task 3
        ShowTaskHeader(3, "Display the pattern like diamond.");
        Console.Clear();
        Third.DrawDiamond();
   

        // Task 4
        ShowTaskHeader(4, "Create base class Vehicle and three sub classes: Car, eCar and Motorcycle.");
        var car = new Car(ConsoleColor.Red, "BMW", 4);
        car.GetDetails();
        car.TurnOnRadio();
        car.OpenWindow();
        car.Drive();

        var eCar = new ECar(ConsoleColor.Cyan, "Nissan", 4);
        eCar.GetDetails();
        eCar.Drive();

        var motorcycle = new Motorcycle(ConsoleColor.DarkRed, "Harley Davidson", 2);
        motorcycle.GetDetails();
        motorcycle.PutHelmetOn();
        motorcycle.Drive();


        // Task 5
        ShowTaskHeader(5, "Read RESTful API and get a random recipe.");
        new Fifth().GetRandomRecipe();
  

        // Task 6
        ShowTaskHeader(6, "Quiz game about Övertorneå.");
        new QuizGame().StartGame();
    }
    
    static void ShowTaskHeader(int taskNumber, string description)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"Task {taskNumber}: {description}");
        Console.ResetColor();
    }
 

}