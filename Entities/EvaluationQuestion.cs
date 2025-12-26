using Hossein.Enums;

namespace Hossein.Entities;

public class EvaluationQuestion
{
    public int Id { get; set; }
    public string Title { get; set; }
    public bool IsActive { get; set; }
    public float Rate { get; set; }
    public EvaluationQuestionType Type { get; set; }
}