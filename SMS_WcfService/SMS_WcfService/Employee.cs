using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMS_WcfService
{
    public class Employee:Person
    {
        private string employee_no;
        private string joining_date;
        private List<Attendance> attendances = new List<Attendance>();

        public void addAttendance(Attendance a)
        {
            attendances.Add(a);
        }
        public string Joining_date
        {
            get
            {
                return joining_date;
            }

            set
            {
                joining_date = value;
            }
        }

        public string Employee_no
        {
            get
            {
                return employee_no;
            }

            set
            {
                employee_no = value;
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
    }
}