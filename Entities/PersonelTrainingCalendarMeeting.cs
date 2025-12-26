using Hossein.Enums;

namespace Hossein.Entities;

// جلسات تقویم آموزشی پرسنل
public class PersonelTrainingCalendarMeeting
{
    public int Id { get; set; }
    public int PersonelTrainingCalendarId { get; set; }
    public DateTime ScheduledStartAt { get; set; }
    public DateTime ScheduledEndAt { get; set; }
    public DateTime? ActualStartAt { get; set; }
    public DateTime? ActualEndAt { get; set; }
    public TrainingCalendarMeetingType Type { get; set; }
    public string? Venue { get; set; }
    public int Capacity { get; set; }
    public int TeacherId { get; set; }
    public string Description { get; set; }
}