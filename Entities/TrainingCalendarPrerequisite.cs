using Hossein.Enums;

namespace Hossein.Entities;

// پیش نیازهای تقویم آموزشی
public class TrainingCalendarPrerequisite
{
    public int Id { get; set; }
    public int? TrainingCalendarId { get; set; }
    public int? TrainingStandardId { get; set; }
    public PrerequisiteType Type { get; set; }
}