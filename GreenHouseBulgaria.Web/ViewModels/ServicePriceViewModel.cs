using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace GreenHouseBulgaria.Web.ViewModels
{
    public class ServicePriceViewModel
    {
        public int? Id { get; set; }
        [DisplayName("Заглавие на цената")]
        public string Title { get; set; }
        [DisplayName("Описание")]
        public string Description { get; set; }
        [DisplayName("Цена")]
        public decimal Price { get; set; }
        public int? ServiceId { get; set; }
        public  ServiceViewModel ServiceViewModel { get; set; }
    }
}