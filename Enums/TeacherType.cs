using System.ComponentModel.DataAnnotations;

namespace Hossein.Enums;

public enum TeacherType
{
    [Display(Name = "داخلی")]
    Internal = 1,

    [Display(Name = "خارجی")]
    External = 2
}