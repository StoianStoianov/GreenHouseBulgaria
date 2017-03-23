﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenHouseBulgaria.Data.Repositories;
using GreenHouseBulgaria.Models;
using GreenHouseBulgaria.Services.Contracts;

namespace GreenHouseBulgaria.Services
{
    public class ServiceService : IServiceService
    {
        private readonly IRepository<Service> serviceRepository;
        private readonly IRepository<ServicePrice> servicePriceRepository;

        public ServiceService(IRepository<Service> serviceRepository, IRepository<ServicePrice> servicePriceInfoRepository)
        {
            this.serviceRepository = serviceRepository;
            this.servicePriceRepository = servicePriceInfoRepository;
        }
        public IQueryable<Service> GetAllServices()
        {
            return this.serviceRepository.All();
        }

        public void AddService(Service service)
        {
            this.serviceRepository.Add(service);

            foreach (var servicePriceInfo in service.ServicePrices)
            {
                this.servicePriceRepository.Add(servicePriceInfo);
            }
            
            this.serviceRepository.SaveChanges();

        }

        public Service GetServiceById(int serviceId)
        {
            var service = this.serviceRepository.GetById(serviceId);

            if (service == null)
            {
                throw new Exception("Грешка");
            }
            return this.serviceRepository.GetById(serviceId);
        }

        public void UpdateServce(Service service)
        {
            var existingPrices = this.serviceRepository.FindBy(ser => ser.Id == service.Id).FirstOrDefault().ServicePrices;
            var newPrices = service.ServicePrices;
                       
            foreach (var servicePrice in newPrices)
            {
                if (existingPrices.Any(pr => pr.Id == servicePrice.Id))
                {
                    servicePriceRepository.Update(servicePrice);
                }
                else
                {
                    servicePrice.ServiceId = service.Id;
                    servicePriceRepository.Add(servicePrice);
                }
            }

            foreach (var servicePrice in existingPrices)
            {
                if (!newPrices.Any(pr => pr.Id == servicePrice.Id))
                {
                    servicePriceRepository.Delete(servicePrice.Id);
                }
            }
            this.servicePriceRepository.SaveChanges();       
            this.serviceRepository.Update(service);
            this.serviceRepository.SaveChanges();
        }

        public void DeleteService(int serviceId)
        {
            var services = this.servicePriceRepository.FindBy(serPr => serPr.ServiceId == serviceId).ToList();
            

            foreach (var servicePrice in services)
            {           
                servicePriceRepository.Delete(servicePrice);
            }

            this.servicePriceRepository.SaveChanges();
            this.serviceRepository.Delete(serviceId);          
            this.serviceRepository.SaveChanges();
        }
    }
}