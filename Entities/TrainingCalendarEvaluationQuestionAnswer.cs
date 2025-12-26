using Hossein.Enums;

namespace Hossein.Entities;

public class TrainingCalendarEvaluationQuestionAnswer
{
    public int Id { get; set; }
    public int TrainingCalendarEvaluationQuestionId { get; set; }
    public string? Description { get; set; }
    public SingleChoiceAnswerType? AnswerType { get; set; }
}