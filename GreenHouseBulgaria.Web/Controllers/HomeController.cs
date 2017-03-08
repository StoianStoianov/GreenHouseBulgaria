using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GreenHouseBulgaria.Services.Contracts;
using AutoMapper;
using GreenHouseBulgaria.Models;
using GreenHouseBulgaria.Web.ViewModels;

namespace GreenHouseBulgaria.Web.Controllers
{
    public class HomeController : Controller
    {
        private IServiceService service;

        public HomeController(IServiceService service)
        {
            this.service = service;
        }
        public ActionResult Index()
        {
            var services = this.service.GetAllServices().ToList();
            return View(services);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ServicesNavigation()
        {
            var services = this.service.GetAllServices().ToList();
            var servicesViewModels = Mapper.Map<List<Service>, List<ServiceViewModel>>(services);
            return PartialView(servicesViewModels);
        }
    }
}