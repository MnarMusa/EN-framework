using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN_framework.Entities
{
    internal class Stud_Course
    {
        public int id { get; set; }

        public int Stud_Id { get; set; }
        public int Course_Id { get; set; }
        public double Grade { get; set; }
    }
}
