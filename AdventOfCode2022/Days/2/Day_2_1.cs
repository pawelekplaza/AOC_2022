namespace AdventOfCode2022.Days._2;

[Day(2, 1)]
public class Day_2_1 : DayBase
{
    public override string Run(Func<string> getInput)
    {
        var input = InputHelper.GetAllNotEmptyLines(getInput());

        for (var i = 0; i < input.Length; i++)
        {
            input[i] = input[i].Replace(" ", string.Empty);
        }

        var totalScore = input.Sum(GetPoints);
        return totalScore.ToString();
    }
    
    private static int GetPoints(string input)
    {
        return input switch
        {
            "AX" => 4,
            "AY" => 8,
            "AZ" => 3,
            "BX" => 1,
            "BY" => 5,
            "BZ" => 9,
            "CX" => 7,
            "CY" => 2,
            "CZ" => 6,
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}