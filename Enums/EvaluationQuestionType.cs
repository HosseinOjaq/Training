using System.ComponentModel.DataAnnotations;

namespace Hossein.Enums;

public enum EvaluationQuestionType
{
    [Display(Name = "تشریحی")]
    Descriptive = 1,

    [Display(Name = "انتخابی")]
    SingleChoice = 2
}