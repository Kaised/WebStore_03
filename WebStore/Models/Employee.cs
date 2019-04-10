using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public class Employee
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Display(Name = "Имя"), Required(ErrorMessage = "Имя является обязательным")]
        [StringLength(maximumLength: 200, MinimumLength = 2,
             ErrorMessage = "В имени должно быть не менее 2х и не более 200 символов")]
        public string FirstName { get; set; }

        [Display(Name = "Фамилия"), Required(ErrorMessage = "Фамилия является обязательной")]
        //[MinLength(2)]
        [RegularExpression(@"(^[А-Я][а-я]{2,150}$)|(^[A-Z][a-z]{2,150}$)", ErrorMessage = "Некорректный формат фамилии")]
        public string SurName { get; set; }

        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }

        [Display(Name = "Возраст"), Required(ErrorMessage = "Возраст является обязательным")]
        [Range(18, 100)]
        public int Age { get; set; }
    }
}
