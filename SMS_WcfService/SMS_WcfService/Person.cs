using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

namespace SMS_WcfService
{
    public class Person
    {
        private string name;
        private string password;
        private string cnic;
        private string gender;
        private string email;
        private string mobile_no;
        private string address;
        private Image picture;
        private List<Message> inbox;

        public void ReceiveMessage(Message msg) { 
        
            
        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Cnic
        {
            get
            {
                return cnic;
            }

            set
            {
                cnic = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Mobile_no
        {
            get
            {
                return mobile_no;
            }

            set
            {
                mobile_no = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public Image Picture
        {
            get
            {
                return picture;
            }

            set
            {
                picture = value;
            }
        }

        public List<Message> Inbox
        {
            get
            {
                return inbox;
            }

            set
            {
                inbox = value;
            }
        }
    }
}