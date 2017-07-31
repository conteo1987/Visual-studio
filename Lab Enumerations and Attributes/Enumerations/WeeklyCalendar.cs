using System.Collections.Generic;
using static StartUp;

public class WeeklyCalendar
{
    private IList<WeeklyEntry> entries;

    public WeeklyCalendar()
    {
        this.entries = new List<WeeklyEntry>();
    }

    public IEnumerable<WeeklyEntry> WeeklySchedule => this.entries;

    public void AddEntry(string weekday, string notes)
    {
        this.entries.Add(new WeeklyEntry(weekday, notes));
    }
}

