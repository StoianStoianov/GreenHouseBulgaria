using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouseBulgaria.Models
{
    public class Image
    {
        private ICollection<Service> services;

        public Image()
        {
            this.services = new HashSet<Service>();
        }
        public int Id { get; set; }

        public byte[] ImageBytes { get; set; }

        public virtual ICollection<Service> Services
        {
            get { return this.services; }
            set { this.services = value; }
        }
    }
}
