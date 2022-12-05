namespace AdventOfCode2022.Days._3;

public class Group
{
    public int PriorityOfCommonItem { get; }

    public Group(string[] items)
    {
        var commonItem = items[0].Intersect(items[1]).Intersect(items[2]).Single();
        var item = new Item(commonItem);
        PriorityOfCommonItem = item.Priority;
    }
}