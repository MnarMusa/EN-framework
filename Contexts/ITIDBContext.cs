using EN_framework.Entities;
using Microsoft.EntityFrameworkCore;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN_framework.Contexts
{
    internal class ITIDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Servver= LAPTOP-1LQO0EC5 ;Database = ITI ; Trusted_Connection = True ; Encrypt=False");
        }

        public DbSet <Student> Students { get; set; }   
        public DbSet <Course> Courses { get; set; }

        public DbSet <Course_Inst> course_Insts { get; set; }
        public DbSet <Department> Departments { get; set; }
        public DbSet <Instructor> Instructors { get; set; }
        public DbSet <Stud_Course> Studs { get; set; }  
        public DbSet <Topic> Topic { get; set; }
    }
}
