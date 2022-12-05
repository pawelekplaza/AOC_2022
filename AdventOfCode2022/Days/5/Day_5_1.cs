namespace AdventOfCode2022.Days._5;

[Day(5, 1)]
public class Day_5_1 : DayBase
{
    public override string Run(Func<string> getInput)
    {
        var input = InputHelper.GetAllNotEmptyLines(getInput());
        var numberOfStacks = input[0].Length / 4 + 1;
        var indexWithIds = GetIndexWithIds(input);
        var stacks = GetStacks(input, numberOfStacks, indexWithIds);
        var linesWithInstructions = input.Skip(indexWithIds + 1);
        var instructions = linesWithInstructions
                           .Select(line => line.Split(' ', StringSplitOptions.RemoveEmptyEntries))
                           .Select(split => new Instruction(int.Parse(split[1]), int.Parse(split[3]), int.Parse(split[5])))
                           .ToList();
        var cargoCrane = GetCrateMover(stacks);

        foreach (var instruction in instructions)
        {
            cargoCrane.Move(instruction.Amount, instruction.From, instruction.To);
        }

        var word = string.Join(string.Empty, stacks.Select(x => x.Crates.Peek()));
        return word;
    }

    protected virtual ICrateMover GetCrateMover(Stack[] stacks) => new CrateMover9000(stacks);

    private static int GetIndexWithIds(string[] input)
    {
        for (var i = 0; i < input.Length; i++)
        {
            if (!char.IsDigit(input[i].Trim().First())) 
                continue;

            return i;
        }

        return -1;
    }

    private static Stack[] GetStacks(string[] input, int numberOfStacks, int indexWithIds)
    {
        var stacks = new Stack[numberOfStacks];

        for (var j = 1; j <= numberOfStacks * 4; j += 4)
        {
            stacks[j / 4] = new Stack(j / 4 + 1);
            
            for (var i = indexWithIds - 1; i >= 0 ; i--)
            {
                var crate = input[i][j];
                if (crate == ' ') 
                    continue;
                
                stacks[j / 4].Crates.Push(crate);
            }
        }

        return stacks;
    }
}