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
        public string SubscriberName { get; set; }
        [Required]
        public string Adress { get; set; }
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
        public string TelephoneNumber { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        public DateTime SubscriptionDateTime { get; set; }

        public int ServicePriceId { get; set; }

        public  ServicePriceViewModel ServicePriceViewModel { get; set; }

    }
}