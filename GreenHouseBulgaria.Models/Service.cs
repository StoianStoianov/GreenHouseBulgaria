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

        public Service()
        {
            this.subscriptions = new HashSet<Subscription>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Subscription> Subscriptions
        {
            get { return this.subscriptions; }
            set { this.subscriptions = value; }
        } 
    }
}
