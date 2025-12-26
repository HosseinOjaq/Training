namespace Hossein.Entities;

public class TrainingCalendarAttachment
{
    public int Id { get; set; }
    public int TrainingCalendarId { get; set; }
    public string Title { get; set; }
    public string FileName { get; set; }
    public string Description { get; set; }
}