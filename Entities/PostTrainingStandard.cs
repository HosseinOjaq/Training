namespace Hossein.Entities;

public class PostTrainingStandard
{
    public int Id { get; set; }
    public int PostId { get; set; }
    public int TrainingStandardId { get; set; }
    public bool IsMandatory { get; set; }
}