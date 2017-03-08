using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Заглавие")]
        public string Title { get; set; }
        [AllowHtml]
        [DisplayName("Съдържание")]
        public string Content { get; set; }      
        public IList<ServicePriceViewModel> ServicePriceViewModels { get; set; }
    }
}