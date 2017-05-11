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
    public class ContactMessageService : IContactMessageService
    {
        private IRepository<ContactMessage> contactMessageRepository;

        public ContactMessageService(IRepository<ContactMessage> contactMessageRepository)
        {
            this.contactMessageRepository = contactMessageRepository;
        }
        public void AddContactMessage(ContactMessage contactMessage)
        {
            this.contactMessageRepository.Add(contactMessage);
            this.contactMessageRepository.SaveChanges();
        }

        public IQueryable<ContactMessage> GetAllMessages()
        {
            throw new NotImplementedException();
        }

        public ContactMessage GetMessage(int contactMessageId)
        {
            throw new NotImplementedException();
        }
    }
}
