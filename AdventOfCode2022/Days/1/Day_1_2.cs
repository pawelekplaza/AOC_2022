namespace AdventOfCode2022.Days._1;

[Day(1, 2)]
public class Day_1_2 : DayBase
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

        elves.Sort((elf1, elf2) => elf1.TotalCalories.CompareTo(elf2.TotalCalories) * -1);
        var sum = elves[0].TotalCalories + elves[1].TotalCalories + elves[2].TotalCalories;
        return sum.ToString();
    }
}