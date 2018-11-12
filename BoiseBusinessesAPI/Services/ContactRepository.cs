using System;
using BoiseBusinessesAPI.Models;

namespace BoiseBusinessesAPI.Services
{
    public class ContactRepository
    {
        public Contact[] GetAllContacts()
        {
            return new Contact[]
            {
            new Contact
            {
                Id = 1,
                Name = "Micron"
            },
            new Contact
            {
                Id = 2,
                Name = "HP"
            },
            new Contact
            {
                Id = 3,
                Name = "BSU"
            }, 
            new Contact
            {
                Id = 4,
                Name = "Simplot"
            },
            new Contact
            {
                Id = 5,
                Name = "Alavita"
            }, 
            new Contact
            {
                Id = 6,
                Name = "Tsheets"
            },
            new Contact
            {
                Id = 7,
                Name = "Paylocity"
            },
            new Contact
            {
                Id = 8,
                Name = "Clearwater Analytics"
            }
            };
        }
    }
}
