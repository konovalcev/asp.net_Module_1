using System;
using System.ComponentModel.DataAnnotations;

namespace WebStore.Modeis
{
    public class EmployeeView
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Имя является обязательным")]
        [Display(Name = "Имя")]
        [StringLength(maximumLength: 200, MinimumLength = 2, ErrorMessage = "В имени должно быть не менее 2-х и не более 200 символов")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Фамилия является обязательной")]
        [Display(Name = "Фамилия")]
        public string Surname { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Возраст является обязательным")]
        [Range(18, 100)]
        [Display(Name = "Возраст")]
        public int Age { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Должность является обязательной")]
        [Display(Name ="Должность")]
        public string Position { get; set; }

        [Display(Name ="Зарплата")]
        public int Salary { get; set; }
    }
}