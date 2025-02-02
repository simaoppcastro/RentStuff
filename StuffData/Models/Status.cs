﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StuffData.Models
{
    public class Status
    {
        public int Id { get; set; }

        [Required] public string Name { get; set; }

        [Required] public string Description { get; set; }
    }
}
