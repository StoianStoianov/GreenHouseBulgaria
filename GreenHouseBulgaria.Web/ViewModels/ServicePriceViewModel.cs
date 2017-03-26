using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GreenHouseBulgaria.Web.ViewModels
{
    public class ServicePriceViewModel
    {
        public int? Id { get; set; }
        [Required]
        [DisplayName("Заглавие на цената")]
        public string Title { get; set; }
        [Required]
        [DisplayName("Описание")]
        public string Description { get; set; }
        [Required]
        [DisplayName("Цена")]
        public string Price { get; set; }
        public int? ServiceId { get; set; }
        public  ServiceViewModel ServiceViewModel { get; set; }
    }
}