﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCodeFirstApproachApplication.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string Name { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Country { get; set; }

    }
}
