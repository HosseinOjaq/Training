namespace Hossein.Entities.Exam;

public class TrainingCalendarQuestion
{
    public int Id { get; set; }
    public int QuestionId { get; set; }
    public int TrainingCalendarId { get; set; }
    public float Rate { get; set; }
}