using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoAlbumViewer.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {

        #region Property Changed Event Handler
        public event PropertyChangedEventHandler PropertyChanged;
        protected void SetPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion Property Changed Event Handler

    }
}
