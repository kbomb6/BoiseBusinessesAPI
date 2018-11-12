using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Web.Http.
using Microsoft.AspNetCore.Mvc;
using BoiseBusinessesAPI.Models;
using BoiseBusinessesAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BoiseBusinessesAPI.Controllers
{
    //[System.Web.Http.Route("api/contact")]
    [Route("api/contact")]
    public class ContactController : Controller
    {
        private ContactRepository contactRepository;
        
        public ContactController()
        {
            this.contactRepository = new ContactRepository();
        }

        public Contact[] Get()
        {
            return contactRepository.GetAllContacts();
        }
    }
}
