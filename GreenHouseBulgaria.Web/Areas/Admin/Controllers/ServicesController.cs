using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GreenHouseBulgaria.Web.ViewModels;
using AutoMapper;
using GreenHouseBulgaria.Models;
using GreenHouseBulgaria.Services.Contracts;

namespace GreenHouseBulgaria.Web.Areas.Admin.Controllers
{
    public class ServicesController : Controller
    {
        private IServiceService serviceSevice;

        public ServicesController(IServiceService serviceSevice)
        {
            this.serviceSevice = serviceSevice;
        }
        // GET: Admin/Services
        public ActionResult Index()
        {
            return View();
        }
       

        [HttpGet]
        public ActionResult CreateService()
        {           
            return View(new ServiceViewModel());
        }
        [HttpPost]
        public ActionResult CreateService(ServiceViewModel serviceViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(serviceViewModel);

            }
            var service = Mapper.Map<ServiceViewModel, Service>(serviceViewModel);
            this.serviceSevice.AddService(service);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateService(int id)
        {
            var service = this.serviceSevice.GetServiceById(id);
            var serviceViewModel = Mapper.Map<Service, ServiceViewModel>(service);
            return View(serviceViewModel);
        }

        [HttpPost]
        public ActionResult UpdateService(ServiceViewModel serviceViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(serviceViewModel);
            }

            var service = Mapper.Map<ServiceViewModel, Service>(serviceViewModel);
            this.serviceSevice.UpdateServce(service);
            return View();
        }

        public ActionResult DeleteService()
        {
            return View();

        }

        public ActionResult RenderServicePrice()
        {
            return PartialView("ServicePrice");
        }
    }
}