﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BuddhaTerapiasAPI.Models
{
    public class Therapist : User
    {
        public string Address { get; set; }
        public string Email { get; set; }
        [MaxLength(9)]
        public int MobilePhone { get; set; }
    }
}
