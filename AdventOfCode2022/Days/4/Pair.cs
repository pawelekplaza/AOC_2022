namespace AdventOfCode2022.Days._4;

public class Pair
{
    public bool NeedsReconsideration { get; }
    public bool HasOverlappingSection { get; }
    
    public Pair(string[] sections)
    {
        var firstElf = sections[0];
        var secondElf = sections[1];

        var firstSplit = firstElf.Split('-');
        var secondSplit = secondElf.Split('-');

        var firstElfStartSection = int.Parse(firstSplit[0]);
        var firstElfEndSection = int.Parse(firstSplit[1]);
        var secondElfStartSection = int.Parse(secondSplit[0]);
        var secondElfEndSection = int.Parse(secondSplit[1]);

        var firstHasAllSeconds = firstElfStartSection <= secondElfStartSection && firstElfEndSection >= secondElfEndSection;
        var secondHasAllFirsts = secondElfStartSection <= firstElfStartSection && secondElfEndSection >= firstElfEndSection;

        var firstOverlaps = firstElfStartSection <= secondElfEndSection && firstElfEndSection >= secondElfStartSection;
        var secondOverlaps = secondElfStartSection <= firstElfEndSection && secondElfEndSection >= firstElfStartSection;

        NeedsReconsideration = firstHasAllSeconds || secondHasAllFirsts;
        HasOverlappingSection = firstOverlaps || secondOverlaps;
    }
}