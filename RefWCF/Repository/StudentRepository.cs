using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reference.Repository
{
    public class StudentRepository
    {
        public Student GetStudent(string studentId)
        {
            int id = Convert.ToInt32(studentId);
            TestEntities studentEntities = new TestEntities();
            Student std = studentEntities.Students.Where(student => student.StudentID ==id).FirstOrDefault();
            return std;
        }
    }
}
