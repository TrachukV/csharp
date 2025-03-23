using System;
using System.Runtime.InteropServices;
using static Program;
enum Season { Spring, Summer, Autumn, Winter }
class Program
{


    static void Main()
    {
        Program program = new();
        int age = 27;
        string advice = GetAdvice(age);
        Console.WriteLine(advice);

        const Season season = Season.Spring;
        string seasonName = GetSeason(season);
        Console.WriteLine(seasonName);

        GenerateLogNum();

        PrintSeasonNames();


    }

    private static void PrintSeasonNames()
    {
        Season[] seasons = Enum.GetValues<Season>();
        string[] names = [.. seasons.Select(s => s.ToString())];
        foreach (var item in names)
        {
            Console.WriteLine(item);
        }
    }
    private static void GenerateLogNum()
    {
        List<int> ints = [.. Enumerable.Range(1, 8)];
        for (int i = 0; i < ints.Count; i++)
        {
            Console.WriteLine(ints[i]);
        }
    }

    private static string GetAdvice(int age)
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
    private static string GetSeason(Season season)
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

