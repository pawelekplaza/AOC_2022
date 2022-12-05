namespace AdventOfCode2022.Days._3;

public class Item
{
    public int Priority { get; }
    
    public Item(char item)
    {
        var asInt = (int)item;
        
        Priority = asInt is >= 97 and <= 122 
            ? asInt - 96 
            : asInt - 38;
    }
}