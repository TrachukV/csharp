class Conditions {
	    public static string GetAdvice(int age)
    {
        if (age <= 14)
        {
            return "Explore Interests.";

        }
        else if (age <= 18)
        {
            return "Focus on your studies.";
        }
        else
        {
            return "Always be a Great Person";
        }
    }
    public static string GetSeason(Season season)
    {
        return season switch
        {
            Season.Spring => "average temperature: 10-15 degrees",
            Season.Summer => "average temperature: 25-35 degrees",
            Season.Autumn => "average temperature: 5-10 degrees",
            Season.Winter => "average temperature: -20 degrees",
            _ => "Error",
        };
    }
}