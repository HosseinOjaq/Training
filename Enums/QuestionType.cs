using System.ComponentModel.DataAnnotations;

namespace Hossein.Enums;

public enum QuestionType
{
    [Display(Name = "تشریحی")]
    Descriptive = 1,

    [Display(Name = "انتخابی")]
    SingleChoice = 2,

    [Display(Name = "چند انتخابی")]
    MultiChoice = 3
}