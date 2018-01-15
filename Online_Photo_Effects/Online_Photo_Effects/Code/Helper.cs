using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Online_Photo_Effects.Code
{
    public class Helper
    {
     
        public bool checkUsername(string username)
        {
            if (username.Length != 0 && username.Length < 51)
            {
                if (username.All(Char.IsLetterOrDigit))
                {
                    return true;
                }
            }
            
            return false;
        }


        public bool checkPassword(string password)
        {
            if (password.Length > 5 && password.Length < 37)
            {
                return true;
            }
            return false;
        }

    }
}