using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouseBulgaria.Models
{
    public class Service
    {
        private ICollection<Subscription> subscriptions;
        private ICollection<ServicePrice> servicePrices;

        public Service()
        {
            this.subscriptions = new HashSet<Subscription>();
            this.servicePrices = new List<ServicePrice>();
        }
        public int Id { get; set; }
      
        public string Title { get; set; }

        public string Content{ get; set; }

        public virtual ICollection<Subscription> Subscriptions
        {
            get { return this.subscriptions; }
            set { this.subscriptions = value; }
        }

        public virtual ICollection<ServicePrice> ServicePrices
        {
            get { return this.servicePrices; }
            set { this.servicePrices = value; }
        }
    }
}
