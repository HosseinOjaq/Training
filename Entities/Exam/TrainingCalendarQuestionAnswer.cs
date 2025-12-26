namespace Hossein.Entities.Exam;

public class TrainingCalendarQuestionAnswer
{
    public int Id { get; set; }
    public int TrainingCalendarQuestionId { get; set; }
    public int PersonelId { get; set; }
    public string? Answer { get; set; }
    public float? AnswerRate { get; set; }
    public int? OptionId { get; set; }
    public DateTime AnsweredAt { get; set; }
}