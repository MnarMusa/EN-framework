﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN_framework.Entities
{
    internal class Instructor
    {

        public int Id { get; set; }
        public string  Name { get; set; }

        public int Bouns { get; set; }

        public int Salary{ get; set; }

        public string? Address { get; set; }
        public int Hour_rate { get; set; }

        public int Dept_Id { get; set; }
    }
}
