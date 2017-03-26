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

        public DateTime SubscriptionDateTime { get; set; }

        public int ServicePriceId { get; set; }

        public virtual ServicePrice ServicePrice { get; set; }

        public bool IsChecked { get; set; }
    }
}
