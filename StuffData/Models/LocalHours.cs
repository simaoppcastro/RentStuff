using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StuffData.Models
{
    // time open of the this location
    public class LocalHours
    {
        public int Id { get; set; }
        public StuffLocation Location { get; set; }

        [Range(0, 6, ErrorMessage = "Day of Week must be between 0 and 6")]
        public int DayOfWeek { get; set; }

        [Range(0, 23, ErrorMessage = "Hour open must be between 0 and 23")]
        public int OpenTime { get; set; }

        [Range(0, 23, ErrorMessage = "Hour closed must be between 0 and 23")]
        public int CloseTime { get; set; }
    }
}
