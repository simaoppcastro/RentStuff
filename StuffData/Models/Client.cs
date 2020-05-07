using System;
using System.Collections.Generic;
using System.Text;

namespace StuffData.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string TelephoneNumber { get; set; }

        // virtual keyword for lazy load
        // public virtual RentStuffCard RentStuffCard { get; set; }
    }
}
