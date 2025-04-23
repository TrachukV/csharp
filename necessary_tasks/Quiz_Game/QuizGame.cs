namespace variables.necessary_tasks.Quiz_Game;

public class QuizGame
{
    private List<Question> _questions;
    private int _score;

    public QuizGame()
    {
        _questions = new List<Question>
        {
            new Question("Which country is Övertorneå located in?", ["Sweden", "Norway", "Finland"], 0),
            new Question("Which river runs through Övertorneå?", ["Lule River", "Torne River", "Kalix River"], 1),
            new Question("Which region is Övertorneå part of?", ["Norrbotten", "Stockholm", "Dalarna"], 0),
            new Question("What minority language is common in Övertorneå?", ["Finnish", "Norwegian", "Sami"], 0),
            new Question("Approximate population of Övertorneå?", ["Around 3,500", "Around 10,000", "Around 50,000" ], 0),
            new Question("Övertorneå borders which country?", [  "Norway", "Danmark", "Finland" ], 2)
        };
    }

    public void StartGame()
    {
        _score = 0;

        foreach (var question in _questions)
        {
            bool correct = question.Ask();

            if (correct)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!\n");
                _score++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect.\n");
            }

            Console.ResetColor();
            Thread.Sleep(1000);
        }

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Game Over! Your score: {_score}/{_questions.Count}");
        Console.ResetColor();
    }
}
