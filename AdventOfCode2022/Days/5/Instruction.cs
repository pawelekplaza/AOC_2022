namespace AdventOfCode2022.Days._5;

public class Instruction
{
    public int Amount { get; }
    public int From { get; }
    public int To { get; }

    public Instruction(int amount, int from, int to)
    {
        Amount = amount;
        From = from;
        To = to;
    }
}