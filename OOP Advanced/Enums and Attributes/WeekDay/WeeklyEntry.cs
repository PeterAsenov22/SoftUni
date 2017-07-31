using System;

public class WeeklyEntry:IComparable<WeeklyEntry>
{
    private WeekDay weekDay;

    public WeeklyEntry(string weekday, string notes)
    {
        this.weekDay = (WeekDay) Enum.Parse(typeof(WeekDay), weekday);
        this.Notes = notes;
    }

    public WeekDay WeekDay => this.weekDay;

    public string Notes { get; private set; }

    public int CompareTo(WeeklyEntry other)
    {
        if (ReferenceEquals(this, other))
        {
            return 0;
        }

        if (ReferenceEquals(null, other))
        {
            return 1;
        }

        var weekDayComparison = this.WeekDay.CompareTo(other.WeekDay);
        if (weekDayComparison != 0)
        {
            return weekDayComparison;
        }

        return string.Compare(this.Notes, other.Notes, StringComparison.Ordinal);
    }

    public override string ToString()
    {
        return $"{this.WeekDay} - {this.Notes}";
    }
}
