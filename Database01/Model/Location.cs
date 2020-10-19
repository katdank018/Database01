﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Database01.Model
{
    public class Location
    {
        public float Area { get; set; }
        [Key]
        public int LocationID { get; set; }
        public string Name { get; set; }

        public ICollection<Place> Places { get; set; }
    }
}