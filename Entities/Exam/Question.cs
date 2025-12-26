using Hossein.Enums;

namespace Hossein.Entities.Exam;

public class Question
{
    public int Id { get; set; }
    public string Title { get; set; }
    public QuestionType Type { get; set; }
    public bool IsActive { get; set; }
}