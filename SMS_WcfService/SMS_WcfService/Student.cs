using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMS_WcfService
{
    public class Student:Person
    {
        private string roll_no;
        private Parent parent;
        private List<Attendance> attendances = new List<Attendance>();
        private List<Course> courses_enrolled = new List<Course>();

        public void addAttendance(Attendance a)
        {

        }

        public void addCourse(Course c)
        {
            courses_enrolled.Add(c);
        }

        public string Roll_no
        {
            get
            {
                return roll_no;
            }

            set
            {
                roll_no = value;
            }
        }

        public Parent Parent
        {
            get
            {
                return parent;
            }

            set
            {
                parent = value;
            }
        }

        public List<Attendance> Attendances
        {
            get
            {
                return attendances;
            }

            set
            {
                attendances = value;
            }
        }

        public List<Course> Courses_enrolled
        {
            get
            {
                return courses_enrolled;
            }

            set
            {
                courses_enrolled = value;
            }
        }
    }
}