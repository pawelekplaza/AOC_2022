namespace AdventOfCode2022.Days._3;

public class Rucksack
{
    public int PriorityOfItemInBothCompartments { get; }
    
    public Rucksack(string items)
    {
        var firstCompartment = items.Take(items.Length / 2);
        var secondCompartment = items.Skip(items.Length / 2);
        var repeatingItem = firstCompartment.Intersect(secondCompartment).Single();

        var item = new Item(repeatingItem);
        PriorityOfItemInBothCompartments = item.Priority;
    }
}