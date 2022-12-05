namespace AdventOfCode2022.Days._3;

[Day(3, 1)]
public class Day_3_1 : DayBase
{
    public override string Run(Func<string> getInput)
    {
        var input = InputHelper.GetAllNotEmptyLines(getInput());
        var rucksacks = input.Select(x => new Rucksack(x));

        return rucksacks.Sum(x => x.PriorityOfItemInBothCompartments).ToString();
    }
}