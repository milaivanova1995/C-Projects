using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Online_Photo_Effects.Model
{
    public class AccountsInfo
    {
        private int _id;
        private string _fullName;
        private string _userName;
        private string _password;
        private string _email;


        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                _fullName = value;
            }
        }

        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
    }
}