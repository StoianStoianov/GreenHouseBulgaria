using GreenHouseBulgaria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouseBulgaria.Services.Contracts
{
    public interface IContactMessageService
    {
        IQueryable<ContactMessage> GetAllMessages();

        ContactMessage GetMessage(int contactMessageId);

        void AddContactMessage(ContactMessage contactMessage);
    }
}
