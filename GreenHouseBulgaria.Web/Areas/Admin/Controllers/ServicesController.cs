using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using GreenHouseBulgaria.Web.ViewModels;
using AutoMapper;
using GreenHouseBulgaria.Models;
using GreenHouseBulgaria.Services.Contracts;

namespace GreenHouseBulgaria.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
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
            var services = this.serviceSevice.GetAllServices().ToList();
            var servicesViewModels = Mapper.Map<List<Service>, List<ServiceViewModel>>(services);
            WebGrid grid = new WebGrid(servicesViewModels);
            return View(grid);
        }
       

        [HttpGet]
        public ActionResult CreateService()
        {           
            return View(new ServiceViewModel());
        }
        [HttpPost]
        public ActionResult CreateService(ServiceViewModel serviceViewModel, HttpPostedFileBase imageBytes)
        {
            if (!ModelState.IsValid)
            {
                return View(serviceViewModel);

            }
            if (imageBytes != null)
            {
                serviceViewModel.Image = new ImageViewModel();
                serviceViewModel.Image.ImageBytes = new byte[imageBytes.ContentLength];
                imageBytes.InputStream.Read(serviceViewModel.Image.ImageBytes, 0, imageBytes.ContentLength);
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
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult DeleteService(int id)
        {
            var service = this.serviceSevice.GetServiceById(id);
            var serviceViewModel = Mapper.Map<Service, ServiceViewModel>(service);
            return View(serviceViewModel);

        }

        [HttpPost]
        public ActionResult DeleteService(ServiceViewModel serviceViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(serviceViewModel);
            }

            var service = Mapper.Map<ServiceViewModel, Service>(serviceViewModel);
            this.serviceSevice.DeleteService(service.Id);
            return RedirectToAction("Index");
        }

        public ActionResult RenderServicePrice()
        {
            return PartialView("ServicePrice");
        }
    }
}