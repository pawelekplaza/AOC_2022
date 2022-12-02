namespace AdventOfCode2022.Days._1;

[Day(1, 1)]
public class Day_1_1 : DayBase
{
    public override string Run(Func<string> getInput)
    {
        var input = InputHelper.SplitIntoGroupsByEmptyLine(getInput());
        var elves = new List<Elf>();

        foreach (var group in input)
        {
            var elf = new Elf();

            foreach (var calorie in group.Split("\r\n"))
            {
                elf.Calories.Add(Convert.ToInt32(calorie));
            }
            
            elves.Add(elf);
        }

        var topCalories = elves.Max(elf => elf.TotalCalories);
        return topCalories.ToString();
    }
}