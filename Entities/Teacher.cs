using Hossein.Enums;

namespace Hossein.Entities;

public class Teacher
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public TeacherType Type { get; set; }
}