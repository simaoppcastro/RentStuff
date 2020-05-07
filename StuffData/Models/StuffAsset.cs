using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StuffData.Models
{
    public abstract class StuffAsset
    {
        // id of the stuff
        public int Id { get; set; }

        // name of the stuff, like a "car" or a "book" 
        [Required]
        public string stuffName { get; set; }

        // year of the stuff (product)
        [Required]
        public int stuffYear { get; set; }

        // stuff status
        [Required]
        public Status Status { get; set; }

        // Cost for the replacement, not the actual rent cost
        [Required]
        public decimal Cost { get; set; }

        // url for the image of the stuff
        public string ImageUrl { get; set; }

        // number of items of this type of asset
        public int NumberOfItems { get; set; }

        // location of the stuff item
        public virtual StuffLocation Location { get; set; }



    }
}
