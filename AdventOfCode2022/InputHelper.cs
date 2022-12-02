namespace AdventOfCode2022;

public static class InputHelper
{
    public static string[] SplitIntoGroupsByEmptyLine(string input) => input.Split("\r\n\r\n", StringSplitOptions.RemoveEmptyEntries);

    public static string[] GetAllNotEmptyLines(string input) => input.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);
}