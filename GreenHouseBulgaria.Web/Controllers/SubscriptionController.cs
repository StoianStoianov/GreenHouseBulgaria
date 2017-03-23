using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using GreenHouseBulgaria.Services.Contracts;
using GreenHouseBulgaria.Web.ViewModels;
using GreenHouseBulgaria.Models;

namespace GreenHouseBulgaria.Web.Controllers
{
    public class SubscriptionController : BaseClientController
    {
        private ISubscriptionService subscriptionService;
        private IServicePriceService servicePriceService;

        public SubscriptionController(ISubscriptionService subscriptionService, IServicePriceService servicePriceService)
        {
            this.subscriptionService = subscriptionService;
            this.servicePriceService = servicePriceService;
        }
        // GET: Subscription
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SubscribeForService(int servicePriceId)
        {
            var servicePrice = this.servicePriceService.GetServicePrice(servicePriceId);          
            var servicePriceViewModel = Mapper.Map<ServicePrice, ServicePriceViewModel>(servicePrice);          
            var subscriptionViewModel = new SubscriptionViewModel();
            subscriptionViewModel.ServicePriceViewModel = servicePriceViewModel;         
            return View(subscriptionViewModel);
        }

        [HttpPost]
        public ActionResult SubscribeForService(SubscriptionViewModel subscriptionViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(subscriptionViewModel);
            }

            var subscription = Mapper.Map<SubscriptionViewModel, Subscription>(subscriptionViewModel);
            this.subscriptionService.AddSubscription(subscription);

            return View();
        }

    }
}