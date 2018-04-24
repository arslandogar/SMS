using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMS_WcfService
{
    public class Admin:Person
    {
        private string username;
        private string password;

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
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
    }
}