using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeApp
{
   public  class SignIn
    {
        public string Authenticate(string userName, string password)
        {
            string msg;
            if(string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                msg = "user name and password required ";
            }
            else
            {
                if((userName == "admin") && ( password == "admin123@"))
                {
                    msg = "Authentication pass";
                }
                else
                {
                    msg = "Authentcation fail";
                }
            }
            return "provide user details";
        }
    }
}
