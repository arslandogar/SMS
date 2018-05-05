using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMS_WcfService
{
    public class StudentsDataClass
    {
        private static List<Student> students = new List<Student>();
        private static Student current_student;
        private static Parent current_parent;

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

        public static Student Current_student
        {
            get
            {
                return current_student;
            }

            set
            {
                current_student = value;
            }
        }

        public static Parent Current_parent
        {
            get
            {
                return current_parent;
            }

            set
            {
                current_parent = value;
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