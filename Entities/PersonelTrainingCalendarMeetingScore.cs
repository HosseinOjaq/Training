namespace Hossein.Entities;

public class PersonelTrainingCalendarMeetingScore
{
    public int Id { get; set; }
    public int PersonelTrainingCalendarId { get; set; }
    public decimal Score { get; set; }
    public string Description { get; set; }
}