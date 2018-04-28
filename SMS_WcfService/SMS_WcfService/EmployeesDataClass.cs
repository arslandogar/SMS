using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMS_WcfService
{
    public class EmployeesDataClass
    {
        private List<Teacher> teachers = new List<Teacher>();

        private Librarian librarian;

        public void addTeacher(Teacher t)
        {

        }

        public List<Teacher> searchByCourse(string name)
        {
            return teachers;
        }

        public void changeLibrarian(Librarian lb)
        {

        }

        public List<Teacher> Teachers
        {
            get
            {
                return teachers;
            }

            set
            {
                teachers = value;
            }
        }

        public Librarian Librarian
        {
            get
            {
                return librarian;
            }

            set
            {
                librarian = value;
            }
        }
    }
}