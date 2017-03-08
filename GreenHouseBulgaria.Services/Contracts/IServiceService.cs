using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenHouseBulgaria.Models;

namespace GreenHouseBulgaria.Services.Contracts
{
    public interface IServiceService
    {
        IQueryable<Service> GetAllServices();

        Service GetServiceById(int serviceId);
        void AddService(Service service);

        void UpdateServce(Service service);


    }
}
