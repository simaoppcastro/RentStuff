﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StuffData.Models
{
    public class RentStuffCard
    {
        public int Id { get; set; }

        [Display(Name = "Overdue Fees")] public decimal Fees { get; set; }

        [Display(Name = "Card Issued Date")] public DateTime Created { get; set; }

        [Display(Name = "Materials on Loan")] public virtual IEnumerable<Checkout> Checkouts { get; set; }
    }
}
