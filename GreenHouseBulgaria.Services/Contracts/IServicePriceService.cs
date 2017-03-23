using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using GreenHouseBulgaria.Models;

namespace GreenHouseBulgaria.Services.Contracts
{
    public interface IServicePriceService
    {
        ServicePrice GetServicePrice(int servicePriceId);
    }
}
