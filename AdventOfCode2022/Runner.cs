using System.Reflection;

namespace AdventOfCode2022;

public class Runner
{
    public static string Run(int day, int exercise, bool isItTest)
    {
        var dayClass = Assembly.GetExecutingAssembly()
                               .GetTypes()
                               .Where(type =>
                               {
                                   if (!type.IsSubclassOf(typeof(DayBase)))
                                   {
                                       return false;
                                   }

                                   var attribute = type.GetCustomAttribute<DayAttribute>();
                                   if (attribute == null)
                                   {
                                       return false;
                                   }

                                   return day == attribute.Day && exercise == attribute.Exercise;
                               })
                               .Single();

        var dayBase = Activator.CreateInstance(dayClass) as DayBase;
        return dayBase?.Run(isItTest ? () => GetTestInput(day) : () => GetInput(day)) ?? $"ERROR: Could not find day {day} exercise {exercise}.";
    }
    
    private static string GetInput(int day)
    {
        return File.ReadAllText($"Days\\{day}\\input.txt");
    }

    private static string GetTestInput(int day)
    {
        return File.ReadAllText($"Days\\{day}\\test.txt");
    }
}