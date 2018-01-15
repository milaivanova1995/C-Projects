using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Online_Photo_Effects.Model
{
    public class ImageDetails
    {
        private int _w;
        private int _h;

        public int ImageWidth
        {
            get
            {
                return _w;
            }
            set
            {
                _w = value;
            }
        }

        public int ImageHeight
        {
            get
            {
                return _h;
            }
            set
            {
                _h = value;
            }
        }
    }
}