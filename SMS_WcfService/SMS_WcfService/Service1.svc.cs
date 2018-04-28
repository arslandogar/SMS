using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SMS_WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public void sChangeLibrarian(string name, string cnic, string gender, string email, string mobile_no, string address, string date_of_birth, string joing_date, string employee_no)
        {
            Librarian librarian = new Librarian();
            librarian.Name = name;
            librarian.Cnic = cnic;
            librarian.Gender = gender;
            librarian.Email = email;
            librarian.Mobile_no = mobile_no;
            librarian.Address = address;
            librarian.Date_of_birth = date_of_birth;
            librarian.Joining_date = joing_date;
            librarian.Employee_no = employee_no;
            EmployeesDataClass.changeLibrarian(librarian);
        }

        public void sSetDefaultAdmin()
        {
            if(AdminDataClass.adminSet)
            {
                return;
            } else
            {
                AdminDataClass.setDefaultAdmin();
                AdminDataClass.adminSet = true;
            }
        }

        public bool sValidAdmin(string username, string password)
        {
            if(AdminDataClass.admin.Username == username && AdminDataClass.admin.Password == password)
            {
                return true;
            }
            return false;
        }
    }
}
