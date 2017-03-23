using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenHouseBulgaria.Data.Repositories;
using GreenHouseBulgaria.Models;
using GreenHouseBulgaria.Services.Contracts;

namespace GreenHouseBulgaria.Services
{
    public class SubscriptionService : ISubscriptionService
    {
        private IRepository<Subscription> subscriptionRepository;

        public SubscriptionService(IRepository<Subscription> subscriptionServiceRepository)
        {
            this.subscriptionRepository = subscriptionServiceRepository;
        }
        public IQueryable<Subscription> GetAllSubscriptionServices()
        {
            return this.subscriptionRepository.All();
        }

        public Subscription GetSubscription(int subscriptionId)
        {
            return this.subscriptionRepository.GetById(subscriptionId);
        }

        public void AddSubscription(Subscription subscription)
        {
            this.subscriptionRepository.Add(subscription);
            this.subscriptionRepository.SaveChanges();
        }

        
    }
}
