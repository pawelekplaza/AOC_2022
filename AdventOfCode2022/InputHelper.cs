namespace AdventOfCode2022;

public static class InputHelper
{
    public static string[] SplitIntoGroupsByEmptyLine(string input) => input.Split("\r\n\r\n", StringSplitOptions.RemoveEmptyEntries);

    public static string[] GetAllNotEmptyLines(string input) => input.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);

    public static List<string[]> SplitIntoGroupsOfGivenNumberOfLines(string input, int linesInGroup)
    {
        var lines = GetAllNotEmptyLines(input);
        var groups = new List<string[]>();
        var currentGroup = new List<string>();
        
        for (var i = 0; i < lines.Length; i++)
        {
            currentGroup.Add(lines[i]);

            if (i % linesInGroup != linesInGroup - 1) 
                continue;
            
            groups.Add(currentGroup.ToArray());
            currentGroup.Clear();
        }

        return groups;
    }

    public static List<string[]> SplitLinesByCharacter(string input, char c)
    {
        var lines = GetAllNotEmptyLines(input);
        return lines.Select(line => line.Split(c)).ToList();
    }
}