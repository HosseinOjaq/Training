using System.ComponentModel.DataAnnotations;

namespace Hossein.Enums;

public enum PrerequisiteType
{
    [Display(Name = "تقویم آموزشی")]
    Calendar = 1,

    [Display(Name = "استاندارد")]
    Standard = 2
}