using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using GreenHouseBulgaria.Services.Contracts;
using GreenHouseBulgaria.Models;
using GreenHouseBulgaria.Web.ViewModels;

namespace GreenHouseBulgaria.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    public class SubscriptionsController : Controller
    {
        private ISubscriptionService subscriptionService; 
        public SubscriptionsController(ISubscriptionService subscriptionService)
        {
            this.subscriptionService = subscriptionService;
        }
        // GET: Admin/Subscriptions
        public ActionResult ViewSubscriptions()
        {
            var subscriptions = this.subscriptionService.GetAllSubscriptions().ToList();
            var subscriptionsViewModels = Mapper.Map<List<Subscription>, List<SubscriptionViewModel>>(subscriptions).OrderBy(subs => subs.SubscriptionDateTime).ToList();
            return View(subscriptionsViewModels);
        }
        [HttpGet]
        public ActionResult CheckSubscription(int subscriptionId)
        {
            var subscription = this.subscriptionService.GetSubscription(subscriptionId);
            var subscriptionViewModel = Mapper.Map<Subscription, SubscriptionViewModel>(subscription);
            return View(subscriptionViewModel);
        }
        [HttpPost]
        public ActionResult CheckSubscription(SubscriptionViewModel subscriptionViewModel)
        {
            return View();

        }


    }
}