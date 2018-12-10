using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication1.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage="Пожалуйста, введите своё имя")]
        public string Name { get; set; }

        [Required(ErrorMessage="Пожалуйста, введите email")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage="вы ввели некоректный email")]
        public string Email { get; set; }

        [Required(ErrorMessage="Пожалуйста, введите телефон")]
        public string Phone { get; set; }

        [Required(ErrorMessage="Пожалуйста, укажите, примети ли участие")]
        public bool? WillAttend { get; set; }
    }

}