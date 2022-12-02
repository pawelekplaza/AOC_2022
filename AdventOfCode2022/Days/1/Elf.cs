namespace AdventOfCode2022.Days._1;

public class Elf
{
    public List<int> Calories { get; } = new();

    public int TotalCalories => Calories.Sum();
}