using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouseBulgaria.Models
{
    public class Subscription
    {
        public int Id { get; set; }

        public string SubscriberName { get; set; }

        public string Adress { get; set; }
        public string TelephoneNumber { get; set; }

        public int ServiceId { get; set; }

        public virtual Service Service { get; set; }


    }
}
