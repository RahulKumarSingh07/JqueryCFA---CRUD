﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace First.Models
{
    public class Country
    {
        [Key]
        [Required]
        public int C_Id { get; set; }
        [Required]
        public string CountryName { get; set; }
    }
}
