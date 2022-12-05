namespace AdventOfCode2022.Days._3;

[Day(3, 2)]
public class Day_3_2 : DayBase
{
    public override string Run(Func<string> getInput)
    {
        var input = InputHelper.SplitIntoGroupsOfGivenNumberOfLines(getInput(), 3);
        var groups = input.Select(x => new Group(x));

        return groups.Sum(x => x.PriorityOfCommonItem).ToString();
    }
}