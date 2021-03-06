﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using GreenHouseBulgaria.Models;
using GreenHouseBulgaria.Services.Contracts;
using GreenHouseBulgaria.Web.ViewModels;

namespace GreenHouseBulgaria.Web.Controllers
{
    public class PublicServicesController : BaseClientController
    {
        private IServiceService service;

        public PublicServicesController(IServiceService service)
        {
            this.service = service;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetService(int serviceId)
        {
            var service = this.service.GetServiceById(serviceId);

            
        
            var serviceViewModel = Mapper.Map<Service, ServiceViewModel>(service);
            return View(serviceViewModel);

        }

        public ActionResult GetAllServices()
        {
            var services = this.service.GetAllServices().ToList();
            var servicesViewModels = Mapper.Map<List<Service>, List<ServiceViewModel>>(services);
            return View(servicesViewModels);

        }
    }
}