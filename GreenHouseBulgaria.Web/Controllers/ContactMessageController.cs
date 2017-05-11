using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GreenHouseBulgaria.Services.Contracts;
using GreenHouseBulgaria.Web.ViewModels;
using GreenHouseBulgaria.Models;

namespace GreenHouseBulgaria.Web.Controllers
{
    public class ContactMessageController : BaseClientController
    {
        private IContactMessageService contactMessageService;

        public ContactMessageController(IContactMessageService contactMessageService)
        {
            this.contactMessageService = contactMessageService;
        }
        // GET: ContactMessage
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateContactMessage(ContactMessageViewModel contactMessageViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Contact",contactMessageViewModel);

            }

            var contactMessage = AutoMapper.Mapper.Map<ContactMessageViewModel, ContactMessage>(contactMessageViewModel);
            this.contactMessageService.AddContactMessage(contactMessage);

            return RedirectToAction("Contact");
        }
    }
}