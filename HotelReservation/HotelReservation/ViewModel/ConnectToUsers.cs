using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservation.Model;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Collections;
using HotelReservation.Data;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace HotelReservation.ViewModel
{
    public class ConnectToUsers : ViewModelBase
    {

        private Users _usr;
        private string userNm;
        private string pass;
        private string firstN;
        private string lastN;
        private string ph;
        private ICommand _addUsr;
        private bool _canExecute;
        private string _err;

        #region errors
        const string emptyFieldsError = "Fill the empty fields";
        const string existingUsernameError = "This user name already exists";
        const string emptyUsernameError = "Username cannot be an empty field";
        const string emptyPasswordError = "Password cannot be an empty field";
        const string emptyFNameError = "First name cannot be an empty field";
        const string emptyLNameError = "Last name cannot be an empty field";
        const string emptyPhoneError = "Phone cannot be an empty field";
        const string nameRequirementError = "Name must contain only letters";
        const string passwordRequirementError = "Password must contain upper and lower letters and digits";
        const string phoneRequirementError = "Wrong phone";
        #endregion

        #region getters and setters
        public string Err
        {
            get
            {
                return _err;
            }
            set
            {
                _err = value;
                NotifyPropertyChanged();
            }
        }

        public string userName
        {
            get
            {
                return userNm;
            }
            set
            {
                userNm = value;
                NotifyPropertyChanged();
            }
        }
        public string password
        {
            get
            {
                return pass;
            }
            set
            {
                pass = value;
                NotifyPropertyChanged();
            }
        }
        public string fName
        {
            get
            {
                return firstN;
            }
            set
            {
                firstN = value;
                NotifyPropertyChanged();
            }
        }
        public string lName
        {
            get
            {
                return lastN;
            }
            set
            {
                lastN = value;
                NotifyPropertyChanged();
            }
        }
        public string phone
        {
            get
            {
                return ph;
            }
            set
            {
                ph = value;
                NotifyPropertyChanged();
            }
        }

        public Users usr
        {
            get
            {
                return _usr;
            }
            set
            {
                _usr = value;
                NotifyPropertyChanged();
            }

        }

        public ICommand addUsr
        {
            get
            {
                return _addUsr ?? (_addUsr = new DelegateCommand(() => getData(), _canExecute));
            }

        }

        #endregion


        #region get and check user input

        public void getData()
        {
            string usName, passW = null, first = null, second = null, mob = null;


            try
            {


                if (checkUserName() == true)
                {
                    Err = existingUsernameError;
                }

                else if (!Regex.IsMatch(fName, "^[\\p{L} \\.\\-]+$") || !Regex.IsMatch(lName, "^[\\p{L} \\.\\-]+$"))
                {
                    Err = nameRequirementError;
                }
                else if (!Regex.IsMatch(password, "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).{8,15}$"))
                {

                    Err = passwordRequirementError;
                }
                else if (!Regex.IsMatch(phone, @"^\+?[0-9][0-9\s.-]{7,11}$"))
                {

                    Err = phoneRequirementError;

                }
                else
                {
                    Err = null;
                }
            }
            catch (Exception e)
            {
                Err = emptyFieldsError;
            }

            if (Err == null)
            {
                usName = userName;
                passW = password;
                first = fName;
                second = lName;
                mob = phone;

                DatabaseHelperClass Db_Helper = new DatabaseHelperClass();
                Db_Helper.InsertUser(new Users(usName, passW, first, second, mob));
            }
            else
            {
                ConnectToUsers cn = new ConnectToUsers();
            }

        }


        public bool checkUserName()
        {
            DatabaseHelperClass Db_helper = new DatabaseHelperClass();
            ObservableCollection<Users> listUsr = Db_helper.ReadAllUsers();
            bool isRegistrated = false;
            foreach (Users u in listUsr)
            {
                if (userName.Equals(u.userName))
                {
                    isRegistrated = true;
                }
            }
            return isRegistrated;
        }

        #endregion

        public ConnectToUsers()
        {
            _canExecute = true;


        }
    }
}
