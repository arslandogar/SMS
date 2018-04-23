using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMS_WcfService
{
    public class Message
    {
        private string message;
        private Person sender;

        public string MessageText
        {
            get
            {
                return message;
            }

            set
            {
                message = value;
            }
        }

        public Person Sender
        {
            get
            {
                return sender;
            }

            set
            {
                sender = value;
            }
        }
    }
}