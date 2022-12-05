namespace AdventOfCode2022.Days._5;

public class CrateMover9000 : ICrateMover
{
    private readonly Stack[] stacks;

    public CrateMover9000(Stack[] stacks)
    {
        this.stacks = stacks;
    }
    
    public void Move(int amount, int from, int to)
    {
        var sourceStack = this.stacks[from - 1];
        var destinationStack = this.stacks[to - 1];

        for (var i = 0; i < amount; i++)
        {
            var crate = sourceStack.Crates.Pop();
            destinationStack.Crates.Push(crate);
        }
    }
}