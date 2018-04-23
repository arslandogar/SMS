using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMS_WcfService
{
    public class Parent:Person
    {
        private Student child;

        public Student Child
        {
            get
            {
                return child;
            }

            set
            {
                child = value;
            }
        }
    }
}