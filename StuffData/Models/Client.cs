using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StuffData.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(30, ErrorMessage = "Limit first name to 30 characters.")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(30, ErrorMessage = "Limit last name to 30 characters.")]
        public string LastName { get; set; }

        [Required] public string Address { get; set; }

        [Required] public DateTime DateOfBirth { get; set; }

        public string Telephone { get; set; }
        public string Gender { get; set; }

        [Required]
        [Display(Name = "RentStuff Card")]
        public RentStuffCard RentStuffCard { get; set; }

        // its not required that a user have a local to rent stuff
        // but on submission, the user can write the best location to rent stuff
        public StuffLocation HomeStuffLocation { get; set; }
    }
}
