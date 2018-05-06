using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMS_WcfService
{
    public class Teacher:Employee
    {
        private List<Course> assignedCourses = new List<Course>();

        public void addCourse(Course c)
        {
             assignedCourses.Add(c);
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