using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StuffData.Models
{
    public class Stuff : StuffAsset
    {
        // stuff reference, like a serial number
        [Required]
        [Display(Name = "REF #")]
        public string stuffRef { get; set; }
        
        // brand and model name of the stuff or other type name for the object
        [Required]
        public string suffBrandModel { get; set; }
        
        // internal number of the stuff
        [Required]
        // RSR = RentStuffReference (internal reference)
        [Display(Name = "RSR")]
        public string rentStuffNumber { get; set; }
    }
}
