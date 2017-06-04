using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GreenHouseBulgaria.Web.ViewModels
{
    public class ContactMessageViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Името е задължително")]
        [Display(Name = "Име")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Мейлът е задължителен")]
        [EmailAddress(ErrorMessage = "Невалиден мейл адрес")]
        [Display(Name = "Мейл")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Темата е задължителна")]
        [Display(Name = "Тема")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Текстът е задължителен")]
        [Display(Name = "Текст")]
        public string Text { get; set; }
    }
}