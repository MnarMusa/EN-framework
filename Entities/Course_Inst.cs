using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN_framework.Entities
{
    internal class Course_Inst
    {
        public int ID { get; set; }
        public int Course_Id { get; set; }
        public int Inst_Id { get; set; }
        public int Evaluate { get; set; }
    }
}
