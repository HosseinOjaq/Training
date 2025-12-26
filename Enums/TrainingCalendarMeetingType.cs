using System.ComponentModel.DataAnnotations;

namespace Hossein.Enums;

public enum TrainingCalendarMeetingType
{
    [Display(Name = "درون سازمانی")]
    Internal = 1,

    [Display(Name = "برون سازمانی")]
    External = 2
}