using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMS_WcfService
{
    public class StudentsDataClass
    {
        private static List<Student> students = new List<Student>();

        public static List<Student> Students
        {
            get
            {
                return students;
            }

            set
            {
                students = value;
            }
        }

        public static void addStudent(Student s)
        {
            students.Add(s);
        }

        public static List<Student> searchByCourse(string name)
        {
            return Students;
        }
    }
}