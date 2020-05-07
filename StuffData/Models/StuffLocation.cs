using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StuffData.Models
{
    public class StuffLocation
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Location Name")]
        [StringLength(30, ErrorMessage = "Limit location name to 30 characters.")]
        public string Name { get; set; }

        [Required] public string Address { get; set; }

        [Required] public string Telephone { get; set; }

        public string Description { get; set; }

        // not so much importante, but is used for know when this location open
        public DateTime OpenDate { get; set; }

        // collections of clients and locations with stuff to rent
        public virtual IEnumerable<Client> Clients { get; set; }
        public virtual IEnumerable<StuffAsset> LocationAssets { get; set; }

        public string ImageUrl { get; set; }
    }
}
