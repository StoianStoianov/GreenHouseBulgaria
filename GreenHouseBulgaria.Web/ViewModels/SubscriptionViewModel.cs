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
        [Required]
        [Display(Name = "Име")]
        public string SubscriberName { get; set; }
        [Required]
        [Display(Name = "Адрес")]
        public string Adress { get; set; }
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
        [Display(Name = "Телефонен номер")]
        public string TelephoneNumber { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Дата")]
        public DateTime? SubscriptionDateTime { get; set; }

        public int ServicePriceId { get; set; }

        public  ServicePriceViewModel ServicePriceViewModel { get; set; }

        public bool IsChecked { get; set; }

    }
}