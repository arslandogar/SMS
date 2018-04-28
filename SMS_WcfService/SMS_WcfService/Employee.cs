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

        public List<Attendance> addAttendance(Attendance A)
        {
            return attendances;
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
    }
}