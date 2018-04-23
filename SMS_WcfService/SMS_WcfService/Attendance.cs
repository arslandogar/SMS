using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMS_WcfService
{
    public class Attendance
    {
        private string date;
        private Person person;

        public string Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public Person Person
        {
            get
            {
                return person;
            }

            set
            {
                person = value;
            }
        }
    }
}