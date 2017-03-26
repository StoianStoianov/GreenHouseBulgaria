using GreenHouseBulgaria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouseBulgaria.Services.Contracts
{
    public interface ISubscriptionService
    {
        IQueryable<Subscription> GetAllSubscriptions();

        Subscription GetSubscription(int subscriptionId);

        void AddSubscription(Subscription subscriptionService);
    }
}
