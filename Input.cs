class Input {
	    public static String GetUserInput()
    {
        Console.WriteLine("Enter your age:");
        string? takeResonse = Console.ReadLine();
        bool isSuccess = int.TryParse(takeResonse, out int parsedAge);
        if (isSuccess)
        {
            return $"Converted '{takeResonse}' to {parsedAge}.";
        }
        else
        {
            return $"Attempted conversion of '{takeResonse ?? "empty"}' failed";
        }
        ;
    }
}