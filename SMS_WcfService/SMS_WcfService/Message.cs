using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMS_WcfService
{
    public class Message
    {
        private string message;
        private string sender;

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

        public string Sender
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