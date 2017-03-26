using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouseBulgaria.Models
{
    public class ServicePrice
    {
        private ICollection<Subscription> subscriptions;

        public ServicePrice()
        {
            this.subscriptions = new HashSet<Subscription>();
        }

        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
      
        public string Price { get; set; }
        public int ServiceId { get; set; }
        public virtual Service Service { get; set; }

        public virtual ICollection<Subscription> Subscriptions
        {
            get { return this.subscriptions; }
            set { this.subscriptions = value; }
        }
    }
}
