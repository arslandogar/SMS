using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

namespace SMS_WcfService
{
    public class AdminDataClass
    {
        public static Admin admin = new Admin();
        public static bool adminSet = false;

        public static void setDefaultAdmin()
        {
            admin.Name = "Admin";
            admin.Username = "admin";
            admin.Password = "123";
            admin.Cnic = "1234567891012";
            admin.Address = " ";
            admin.Email = "admin@gmail.com";
            admin.Gender = "Male";
            admin.Mobile_no = "01234567890";
            admin.Picture = new Bitmap(SMS_WcfService.Properties.Resources.user_pic);
        }
    }
    
}