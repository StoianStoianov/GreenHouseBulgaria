using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GreenHouseBulgaria.Web.ViewModels
{
    public class ServiceViewModel
    {
        public ServiceViewModel()
        {
            this.ServicePriceViewModels = new List<ServicePriceViewModel>();
        }
        public int Id { get; set; }
        [Required]
        [DisplayName("Заглавие")]
        public string Title { get; set; }
        [Required]
        [AllowHtml]
        [DisplayName("Съдържание")]
        public string Content { get; set; }      
        public IList<ServicePriceViewModel> ServicePriceViewModels { get; set; }
    }
}