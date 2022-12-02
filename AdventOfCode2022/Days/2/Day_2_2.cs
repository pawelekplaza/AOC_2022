namespace AdventOfCode2022.Days._2;

[Day(2, 2)]
public class Day_2_2 : DayBase
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
        // A rock
        // B paper
        // C scissors
        
        // X lose
        // Y draw
        // Z win
        
        return input switch
        {
            "AX" => 3,
            "AY" => 4,
            "AZ" => 8,
            "BX" => 1,
            "BY" => 5,
            "BZ" => 9,
            "CX" => 2,
            "CY" => 6,
            "CZ" => 7,
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}