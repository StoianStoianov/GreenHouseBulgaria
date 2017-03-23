using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenHouseBulgaria.Data.Repositories;
using GreenHouseBulgaria.Services.Contracts;
using GreenHouseBulgaria.Models;

namespace GreenHouseBulgaria.Services
{
    public class ServicePriceService : IServicePriceService
    {
        private IRepository<ServicePrice> servicePriceRepository;

        public ServicePriceService(IRepository<ServicePrice> servicePriceRepository)
        {
            this.servicePriceRepository = servicePriceRepository;
        }
        public ServicePrice GetServicePrice(int servicePriceId)
        {
            return this.servicePriceRepository.GetById(servicePriceId);
        }
    }
}
