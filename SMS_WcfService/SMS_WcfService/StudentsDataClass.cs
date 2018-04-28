using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMS_WcfService
{
    public class StudentsDataClass
    {
        private static List<Student> students = new List<Student>();

        public void addStudent(Student s)
        {

        }

        public List<Student> searchByCourse(string name)
        {
            return students;
        }
    }
}