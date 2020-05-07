using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StuffData.Models
{
    public class CheckoutHistory
    {
        public int Id { get; set; }

        [Required] public StuffAsset StuffAsset { get; set; }

        [Required] public RentStuffCard RentStuffCard { get; set; }

        [Required] public DateTime CheckedOut { get; set; }

        public DateTime? CheckedIn { get; set; }
    }
}
