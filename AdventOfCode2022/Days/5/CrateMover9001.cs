namespace AdventOfCode2022.Days._5;

public class CrateMover9001 : ICrateMover
{
    private readonly Stack[] stacks;

    public CrateMover9001(Stack[] stacks)
    {
        this.stacks = stacks;
    }
    
    public void Move(int amount, int from, int to)
    {
        var sourceStack = this.stacks[from - 1];
        var destinationStack = this.stacks[to - 1];
        var temporaryStack = new Stack<char>();
        
        for (var i = 0; i < amount; i++)
        {
            var crate = sourceStack.Crates.Pop();
            temporaryStack.Push(crate);
        }

        for (var i = 0; i < amount; i++)
        {
            var crate = temporaryStack.Pop();
            destinationStack.Crates.Push(crate);
        }
    }
}