namespace Hossein.Entities;

public class TrainingCalendarEvaluationQuestion
{
    public int Id { get; set; }
    public int? TrainingCalendarId { get; set; }
    public int EvaluationQuestionId { get; set; }
    public int Priority { get; set; }
    public float Rate { get; set; }
}