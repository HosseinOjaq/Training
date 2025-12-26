namespace Hossein.Entities;

// تقویم آموزشی
public class TrainingCalendar
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime StartAt { get; set; }
    public DateTime EndAt { get; set; }
    public int DepartmentId { get; set; }
    public int CourseId { get; set; }
    public int Duration { get; set; }
    public int TotalCapacity { get; set; }
}