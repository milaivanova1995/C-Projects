using HotelReservation.Data;
using HotelReservation.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;

namespace HotelReservation.ViewModel
{
    public class SigIn : ViewModelBase
    {
        private string _usrNm;
        private string _pass;
        private ICommand _sigIn;
        private bool _canExecute;
        private string _info;

        public string info
        {
            get
            {
                return _info;
            }
            set
            {
                _info = value;
                NotifyPropertyChanged();
            }
        }

        public string usrNm
        {
            get
            {
                return _usrNm;
            }
            set
            {
                _usrNm = value;
                NotifyPropertyChanged();

            }
        }

        public string pass
        {
            get
            {
                return _pass;
            }
            set
            {
                _pass = value;
                NotifyPropertyChanged();
            }
        }
        public ICommand sigIn
        {
            get
            {
                return _sigIn ?? (_sigIn = new DelegateCommand(() => getData(), _canExecute));
            }
        }

        public SigIn()
        {
            _canExecute = true;
        }
        public void getData()
        {
            Users usr = new Users();
            string message = "No user with this username and password!";
            string name, passW;
            bool result;
            name = usrNm;
            passW = pass;
            result = searchUser(name, passW);
            if (result == false)
            {
                info = message.ToString();
            }
            else
            {
                info = null;
            }

        }
        public bool searchUser(string usName, string passW)
        {

            bool result = false;
            DatabaseHelperClass Db_helper = new DatabaseHelperClass();
            ObservableCollection<Users> list = Db_helper.ReadAllUsers();
            foreach (Users selUsr in list)
            {
                try
                {
                    if (usName.Equals(selUsr.userName) && passW.Equals(selUsr.password))
                    {
                        result = true;
                    }
                }
                catch (NullReferenceException e)
                {
                    result = false;
                }

            }
            return result;
        }
    }
}
