using Microsoft.Win32;
using PhotoAlbumViewer.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;


namespace PhotoAlbumViewer
{
    public class MainViewModel : ViewModelBase
    {
        #region Property variables
        private string _imagePath;
        private string _folderPath;
        private int index = 0;
        private string[] _listPhotos;
        private AlbumModel _am;
        private ICommand _loadImageCommand;
        private ICommand _loadNextImageCommand;
        private ICommand _loadPreviousImageCommand;
        #endregion


        #region Public property getters and setters
        public string[] ListPhotos
        {
            get
            {
                return _listPhotos;
            }
            set
            {
                _listPhotos = value;
                SetPropertyChanged("ListPhotos");
            }
        }

        public string FolderPath
        {
            get
            {
                return _folderPath;
            }
            set
            {
                _folderPath = value;
                SetPropertyChanged("FolderPath");
            }
        }

        public string ImagePath
        {
            get
            {
                return _imagePath;
            }
            set
            {
                _imagePath = value;
                SetPropertyChanged("ImagePath");
            }
        }

        public AlbumModel Am
        {
            get
            {
                return _am;
            }
            set
            {
                _am = value;
                SetPropertyChanged("Am");
            }
        }
        #endregion


        #region ICommand getters
        public ICommand LoadImageCommand
        {
            get
            {
                if (_loadImageCommand == null)
                {
                    _loadImageCommand = new RelayCommand(param => LoadImage());
                }
                return _loadImageCommand;
            }
        }


        public ICommand LoadNextImageCommand
        {
            get
            {
                if (_loadNextImageCommand == null)
                {
                    _loadNextImageCommand = new RelayCommand(param => NextPhoto());
                }
                return _loadNextImageCommand;
            }
        }

        public ICommand LoadPreviousImageCommand
        {
            get
            {
                if (_loadPreviousImageCommand == null)
                {
                    _loadPreviousImageCommand = new RelayCommand(param => PreviousPhoto());
                }
                return _loadPreviousImageCommand;
            }
        }
        #endregion


        #region Next and Previous button commands
        private void NextPhoto()
        {
            try
            {
                if (index < ListPhotos.Length)
                {
                    index += 1;
                    ImagePath = ListPhotos[index];
                }
            }
            catch (NullReferenceException ex)
            {
                LoadImage();
            }
            catch (Exception e)
            {
                index = 0;
                NextPhoto();
            }

        }

        private void PreviousPhoto()
        {
            try
            {
                index -= 1;
                ImagePath = ListPhotos[index];
            }
            catch (NullReferenceException ex)
            {
                LoadImage();
            }
            catch (Exception e)
            {
                index = ListPhotos.Length;
                PreviousPhoto();
            }

        }
        #endregion


        #region Load Image button command
        private void LoadImage()
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.DefaultExt = (".png");
                open.Filter = "Pictures (*.jpg;*.gif;*.png)|*.jpg;*.gif;*.png";


                if (open.ShowDialog() == true)
                {
                    ImagePath = open.FileName;
                    FolderPath = setFilePath(ImagePath);
                    Am = new AlbumModel(FolderPath, ImagePath);
                    ListPhotos = Directory.GetFiles(FolderPath, "*.jpg");
                }
            }
            catch (Exception e)
            {
               string err = e.Message;
            }


        }

        private string setFilePath(string photoPath)
        {
            return Path.GetDirectoryName(photoPath);
        }

        #endregion

        
    }
}
