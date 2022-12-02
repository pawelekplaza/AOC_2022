namespace AdventOfCode2022;

[AttributeUsage(AttributeTargets.Class)]
public class DayAttribute : Attribute
{
    public int Day { get; set; }
    
    public int Exercise { get; set; }

    public DayAttribute()
    {
    }

    public DayAttribute(int day, int exercise)
    {
        Day = day;
        Exercise = exercise;
    }
}