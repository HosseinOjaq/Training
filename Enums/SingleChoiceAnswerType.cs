using System.ComponentModel.DataAnnotations;

namespace Hossein.Enums;

public enum SingleChoiceAnswerType
{
    [Display(Name = "بیش از انتظار")]
    BeyondExpectation = 1,

    [Display(Name = "در حد انتظار")]
    MeetsExpectation = 2,

    [Display(Name = "کمتر از انتظار")]
    BelowExpectation = 3,

    [Display(Name = "تاثیر کم")]
    LowImpact = 4,

    [Display(Name = "بدون تاثیر")]
    NoImpact = 5
}