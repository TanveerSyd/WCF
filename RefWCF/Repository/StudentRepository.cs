using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reference.Repository
{
    public class StudentRepository
    {
        public Student GetStudent(int studentId)
        {
            TestEntities studentEntities = new TestEntities();
            Student std = studentEntities.Students.Where(student => student.StudentID == studentId).FirstOrDefault();
            return std;
        }
    }
}
