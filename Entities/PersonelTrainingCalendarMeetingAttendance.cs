namespace Hossein.Entities;

// حضور غیاب تقویم آموزشی پرسنل
public class PersonelTrainingCalendarMeetingAttendance
{
    public int Id { get; set; }
    public int PersonelTrainingCalendarMeetingId { get; set; }
    public int PersonelId { get; set; }
    public bool Status { get; set; }
    public int LateMinutes { get; set; }
}