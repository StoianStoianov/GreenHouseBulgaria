using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouseBulgaria.Models
{
    public class ServicePrice
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Descriptions { get; set; }
      
        public decimal Price { get; set; }
        public int ServiceId { get; set; }
        public virtual Service Service { get; set; }
    }
}
