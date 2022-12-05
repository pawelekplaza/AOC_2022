namespace AdventOfCode2022.Days._4;

[Day(4, 1)]
public class Day_4_1 : DayBase
{
    public override string Run(Func<string> getInput)
    {
        var input = InputHelper.SplitLinesByCharacter(getInput(), ',');
        var pairs = input.Select(x => new Pair(x));

        var needsReconsideration = pairs.Where(x => x.NeedsReconsideration).ToArray();

        return needsReconsideration.Length.ToString();
    }
}