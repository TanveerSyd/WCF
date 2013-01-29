using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RefWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class StudentService : IStudentService
    {
        public Student GetStudentById(int value)
        {
            return new Student { StudentID = 1, FirstName = "Rowan", LastName = "Atkinson", Age = 55 };
        }

        
    }
}
