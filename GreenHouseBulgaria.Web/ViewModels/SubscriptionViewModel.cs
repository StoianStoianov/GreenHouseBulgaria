using GreenHouseBulgaria.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GreenHouseBulgaria.Web.ViewModels
{
    public class SubscriptionViewModel
    {     
        public int Id { get; set; }
        [Required(ErrorMessage = "Името е задължително")]
        [Display(Name = "Име")]
        public string SubscriberName { get; set; }
        [Required(ErrorMessage = "Адресът е задължителен")]
        [Display(Name = "Адрес")]
        public string Adress { get; set; }
        [Required(ErrorMessage = "Телефонният номер е задължителен")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Невалиден номер")]
        [Display(Name = "Телефонен номер")]
        public string TelephoneNumber { get; set; }
        [Required(ErrorMessage = "Мейлът е задължителен")]
        [EmailAddress(ErrorMessage = "Невалиден мейл адрес")]
        [Display(Name = "Имейл")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Датата е задължителна")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Дата")]
        public DateTime? SubscriptionDateTime { get; set; }

        public int ServicePriceId { get; set; }

        public  ServicePriceViewModel ServicePriceViewModel { get; set; }

        public bool IsChecked { get; set; }

    }
}