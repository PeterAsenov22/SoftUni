using System.Collections.Generic;

public class WeeklyCalendar
{
    public WeeklyCalendar()
    {
        this.WeeklySchedule = new List<WeeklyEntry>();
    }

    public void AddEntry(string weekday, string notes)
    {
        var weeklyEntry = new WeeklyEntry(weekday,notes);
        this.WeeklySchedule.Add(weeklyEntry);
    }

    public List<WeeklyEntry> WeeklySchedule { get; }
}
