namespace AdventOfCode2022.Days._5;

public class Stack
{
    public int Id { get; }
    public Stack<char> Crates { get; } = new();

    public Stack(int id)
    {
        Id = id;
    }
}