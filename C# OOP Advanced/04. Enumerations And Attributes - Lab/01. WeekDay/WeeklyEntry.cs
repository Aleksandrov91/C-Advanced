using System;
public class WeeklyEntry : IComparable<WeeklyEntry>
{
    private WeekDay weekday;
    public WeeklyEntry(string weekday, string notes)
    {
        Enum.TryParse(weekday, out this.weekday);
        this.Notes = notes;
    }

    public WeekDay Weekday
    {
        get { return this.weekday; }
    }

    public string Notes { get; }

    public int CompareTo(WeeklyEntry other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        var weekdayComparison = this.weekday.CompareTo(other.weekday);
        if (weekdayComparison != 0) return weekdayComparison;
        return string.Compare(this.Notes, other.Notes, StringComparison.Ordinal);
    }

    public override string ToString()
    {
        return $"{this.weekday} - {this.Notes}";
    }
}
