namespace variables.necessary_tasks.Quiz_Game;

public class Question
{
    public string Text { get; }
    public string[] Answers { get; }
    public int CorrectIndex { get; }

    public Question(string text, string[] answers, int correctIndex)
    {
        Text = text;
        Answers = answers;
        CorrectIndex = correctIndex;
    }

    public bool Ask()
    {
        int selected = 0;
        ConsoleKey key;

        do
        {
            Console.Clear();
            Console.WriteLine(Text);
            for (int i = 0; i < Answers.Length; i++)
            {
                if (i == selected)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.WriteLine($"  {Answers[i]}");
                Console.ResetColor();
            }

            key = Console.ReadKey(true).Key;

            if (key == ConsoleKey.UpArrow)
                selected = (selected - 1 + Answers.Length) % Answers.Length;
            else if (key == ConsoleKey.DownArrow)
                selected = (selected + 1) % Answers.Length;

        } while (key != ConsoleKey.Enter);

        return selected == CorrectIndex;
    }
}
