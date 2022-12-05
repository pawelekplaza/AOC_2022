namespace AdventOfCode2022.Days._4;

[Day(4, 2)]
public class Day_4_2 : DayBase
{
    public override string Run(Func<string> getInput)
    {
        var input = InputHelper.SplitLinesByCharacter(getInput(), ',');
        var pairs = input.Select(x => new Pair(x));

        var hasOverlappingSections = pairs.Where(x => x.HasOverlappingSection).ToArray();

        return hasOverlappingSections.Length.ToString();
    }
}