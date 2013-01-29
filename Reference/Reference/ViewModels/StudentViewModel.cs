using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reference.Repository;
using System.Data.Entity;

namespace Reference.ViewModels
{
    public class StudentViewModel : Student
    {
        public Student newStudent { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}