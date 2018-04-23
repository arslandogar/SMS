using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMS_WcfService
{
    public class Teacher:Employee
    {
        private List<Course> assignedCourses;

        public void addCourse(Course c)
        {

        }

        public List<Course> AssignedCourses
        {
            get
            {
                return assignedCourses;
            }

            set
            {
                assignedCourses = value;
            }
        }
    }
}