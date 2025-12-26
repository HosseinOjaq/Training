namespace Hossein.Entities;

public class PersonelTrainingCalendarCost
{
    public int Id { get; set; }
    public int PersonelTrainingCalendarId { get; set; }
    public int CalendarCostTypeId { get; set; }
    public DateTime CreationDate { get; set; }
    public decimal Amount { get; set; }
    public string Description { get; set; }
}