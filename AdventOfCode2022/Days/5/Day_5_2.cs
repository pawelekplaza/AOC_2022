namespace AdventOfCode2022.Days._5;

[Day(5, 2)]
public class Day_5_2 : Day_5_1
{
    protected override ICrateMover GetCrateMover(Stack[] stacks) => new CrateMover9001(stacks);
}