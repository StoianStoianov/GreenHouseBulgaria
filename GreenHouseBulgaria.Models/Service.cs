﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouseBulgaria.Models
{
    public class Service
    {
        
        private ICollection<ServicePrice> servicePrices;

        public Service()
        {          
            this.servicePrices = new HashSet<ServicePrice>();
        }
        public int Id { get; set; }
      
        public string Title { get; set; }

        public string Content{ get; set; }

        public virtual ICollection<ServicePrice> ServicePrices
        {
            get { return this.servicePrices; }
            set { this.servicePrices = value; }
        }       
        public virtual Image Image { get; set; }
    }
}
