using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMS_WcfService
{
    public class CoursesDataClass
    {
        private static List<Course> courses = new List<Course>();

        public void addCourse(Course c)
        {

        }

        public static List<Course> Courses
        {
            get
            {
                return courses;
            }

            set
            {
                courses = value;
            }
        }     
    }
}