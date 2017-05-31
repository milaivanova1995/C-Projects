using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoAlbumViewer
{
    public class AlbumModel
    {
        private string _folderPath;
        private string _photoPath;

        public string Folder
        {
            get
            {
                return _folderPath;
            }
            set
            {
                _folderPath = value;
            }
        }

        public string Photo
        {
            get
            {
                return _photoPath;
            }
            set
            {
                _photoPath = value;
            }
        }

        public AlbumModel() { }

        public AlbumModel(string folderName, string photoPath)
        {
            this.Folder = folderName;
            this.Photo = photoPath;
        }

        public AlbumModel(string photoPath)
        {
            this.Photo = photoPath;
        }
    }
}
