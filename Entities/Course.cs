﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN_framework.Entities
{
    internal class Course
    {
        public int Id { get; set; }
        public string? Name { get; set; }
       


        public double? Duration { get; set; }
        public string? Description { get; set; }
        public int Top_Id { get; set; }
    }
}
