using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Reference.Repository;

namespace RefWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class StudentService : IStudentService
    {
        public Reference.Repository.Student GetStudentById(int value)
        {
            StudentRepository rs = new StudentRepository();
            return rs.GetStudent(17);

            //return new Student { StudentID = 1, FirstName = "Rowan", LastName = "Atkinson", Age = 55 };
        }

        
    }
}
