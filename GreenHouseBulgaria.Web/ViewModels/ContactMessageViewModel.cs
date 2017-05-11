using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace GreenHouseBulgaria.Web.ViewModels
{
    public class ContactMessageViewModel
    {
        public int Id { get; set; }
        
        public string FullName { get; set; }

        public string Email { get; set; }

        public string Subject { get; set; }

        public string Text { get; set; }
    }
}