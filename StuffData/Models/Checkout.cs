using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StuffData.Models
{
    public class Checkout
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Stuff Asset")]
        public StuffAsset StuffAsset { get; set; }

        [Display(Name = "RentStuff Card")] public RentStuffCard RentStuffCard { get; set; }

        [Display(Name = "Checked Out Since")] public DateTime Since { get; set; }

        [Display(Name = "Checked Out Until")] public DateTime Until { get; set; }
    }
}
