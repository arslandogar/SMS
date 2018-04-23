using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMS_WcfService
{
    public class Course
    {
        private string title;
        private Teacher teacher;

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public Teacher Teacher
        {
            get
            {
                return teacher;
            }

            set
            {
                teacher = value;
            }
        }
    }
}