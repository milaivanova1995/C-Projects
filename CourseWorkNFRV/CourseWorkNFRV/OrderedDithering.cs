using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkNFRV
{
    public partial class CourseWorkNFRV_N3 : Form
    {

        private Bitmap inBitMap;
        private Bitmap outBitMap;
        private int width;
        private int height;
        private int[,] ditherMatrix; 



        public CourseWorkNFRV_N3()
        {
            InitializeComponent();

            inBitMap = null;
            outBitMap = null;
            ditherMatrix = new int[4, 4];
            ditherMatrix[0, 0] = 0;
            ditherMatrix[0, 1] = 1;
            ditherMatrix[0, 2] = 2;
            ditherMatrix[0, 3] = 3;

            ditherMatrix[1, 0] = 4;
            ditherMatrix[1, 1] = 5;
            ditherMatrix[1, 2] = 6;
            ditherMatrix[1, 3] = 7;

            ditherMatrix[2, 0] = 8;
            ditherMatrix[2, 1] = 9;
            ditherMatrix[2, 2] = 10;
            ditherMatrix[2, 3] = 11;

            ditherMatrix[3, 0] = 12;
            ditherMatrix[3, 1] = 13;
            ditherMatrix[3, 2] = 14;
            ditherMatrix[3, 3] = 15;


        }

        private int Aproxim(int intensity)
        {
            if (intensity > 0 && intensity < 16)
                return 15;
            else
                if (intensity >= 16 && intensity < 32)
                return 14;
            else
                    if (intensity >= 32 && intensity < 48)
                return 13;
            else
                        if (intensity >= 48 && intensity < 64)
                return 12;
            else
                        if (intensity >= 64 && intensity < 80)
                return 11;
            else
                        if (intensity >= 80 && intensity < 96)
                return 10;
            else
                        if (intensity >= 96 && intensity < 112)
                return 9;
            else
                        if (intensity >= 112 && intensity < 128)
                return 8;
            else
                        if (intensity >= 128 && intensity < 144)
                return 7;
            else
                        if (intensity >= 144 && intensity < 160)
                return 6;
            else
                        if (intensity >= 160 && intensity < 176)
                return 5;
            else
                        if (intensity >= 176 && intensity < 192)
                return 4;
            else
                        if (intensity >= 192 && intensity < 208)
                return 3;
            else
                        if (intensity >= 208 && intensity < 224)
                return 2;
            else
                        if (intensity >= 224 && intensity < 240)
                return 1;
            else
                        if (intensity >= 240 && intensity < 255)
                return 0;
            else
                return 0;
        }


        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fname = openFileDialog1.FileName;
                inBitMap = new Bitmap(Image.FromFile(fname));
                width = inBitMap.Width;
                height = inBitMap.Height;
                imageBox.Size = new System.Drawing.Size(width, height);
                imageBox.Image = inBitMap;
            }

        }

        private void CourseWorkNFRV_Load(object sender, EventArgs e)
        {


        }

        private void btnOrderedDither_Click(object sender, EventArgs e)
        {
            int k;
            int m;
            
            outBitMap = new Bitmap(inBitMap);

            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                {
                    k = i % 2;
                    m = j % 2;
                    if (Aproxim(outBitMap.GetPixel(i, j).R) < ditherMatrix[k, m])
                    {
                        outBitMap.SetPixel(i, j, Color.White);
                    }
                    else
                    {
                        outBitMap.SetPixel(i, j, Color.Black);
                    }
                }
            imageBox.Image = outBitMap;


        }
    }
}
