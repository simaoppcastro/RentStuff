using System;
using System.Collections.Generic;
using System.Text;

namespace StuffData.Models
{
    // people in wait (hold) status to rent a stuff
    public class Hold
    {
        public int Id { get; set; }
        public virtual StuffAsset StuffAsset { get; set; }
        public virtual RentStuffCard RentStuffCard { get; set; }
        public DateTime HoldPlaced { get; set; }
    }
}
