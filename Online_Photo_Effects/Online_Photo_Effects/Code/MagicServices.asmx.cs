using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Online_Photo_Effects.Code
{
    /// <summary>
    /// Summary description for MagicServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MagicServices : System.Web.Services.WebService
    {

        private int matrixN;
        private double dist;
        private Bitmap inBitMap;
        int[,] ditherMatrix;

        [WebMethod(EnableSession = true)]
        public string Magic1(int w, int h, string fileName)
        {
            double sum;
            Bitmap bm = new Bitmap(Server.MapPath("~/Images/" + fileName));

            matrixN = 2; // set the dimension of the matrix (matrix 2 by 2)
            dist = 255 / 4.0;  // set the step used to determine the four shades of gray

            for (int i = 0; i < w; i = i + matrixN)
            {
                for (int j = 0; j < h; j = j + matrixN)
                {
                    sum = 0;
                    for (int k = i; k < i + matrixN; k++)
                        for (int m = j; m < j + matrixN; m++)
                        {
                            sum += bm.GetPixel(k, m).R;
                        }
                    sum /= 4.0;
                    if (sum == 255.0)
                    {
                        bm.SetPixel(i, j, Color.White);
                        bm.SetPixel(i, j + 1, Color.White);
                        bm.SetPixel(i + 1, j, Color.White);
                        bm.SetPixel(i + 1, j + 1, Color.White);
                    }
                    else
                    {
                        if (sum >= 3 * dist && sum < 255)
                        {
                            bm.SetPixel(i, j, Color.White);
                            bm.SetPixel(i, j + 1, Color.White);
                            bm.SetPixel(i + 1, j, Color.Black);
                            bm.SetPixel(i + 1, j + 1, Color.White);
                        }
                        else
                        {
                            if (sum >= 2 * dist && sum < 3 * dist)
                            {
                                bm.SetPixel(i, j, Color.White);
                                bm.SetPixel(i, j + 1, Color.Black);
                                bm.SetPixel(i + 1, j, Color.Black);
                                bm.SetPixel(i + 1, j + 1, Color.White);
                            }
                            else
                            {
                                if (sum >= dist && sum < 2 * dist)
                                {
                                    bm.SetPixel(i, j, Color.White);
                                    bm.SetPixel(i, j + 1, Color.Black);
                                    bm.SetPixel(i + 1, j, Color.Black);
                                    bm.SetPixel(i + 1, j + 1, Color.Black);
                                }
                                if (sum >= 0.0 && sum < dist)
                                {
                                    bm.SetPixel(i, j, Color.Black);
                                    bm.SetPixel(i, j + 1, Color.Black);
                                    bm.SetPixel(i + 1, j, Color.Black);
                                    bm.SetPixel(i + 1, j + 1, Color.Black);
                                }
                            }
                        }
                    }
                }
                bm.Save(Server.MapPath("~/Images/bm/") + fileName + ".jpg", ImageFormat.Jpeg);

            }
            return "~/Images/bm/" + fileName + ".jpg";
        }





        [WebMethod(EnableSession = true)]
        public string Magic2(int w, int h, string fileName)
        {
            int k;
            int m;

        inBitMap = new Bitmap(Server.MapPath("~/Images/" + fileName));
            initializeMarixForOrderedDithering();

            for (int i = 0; i < w; i++)
                for (int j = 0; j < h; j++)
                {
                    k = i % 2;
                    m = j % 2;
                    if (Aproxim(inBitMap.GetPixel(i, j).R) < ditherMatrix[k, m])
                    {
                        inBitMap.SetPixel(i, j, Color.White);
                    }
                    else
                    {
                        inBitMap.SetPixel(i, j, Color.Black);
                    }
                }

            inBitMap.Save(Server.MapPath("~/Images/bm/") + fileName + ".jpg", ImageFormat.Jpeg);
            return "~/Images/bm/" + fileName + ".jpg";
        }


        [WebMethod(EnableSession = true)]
        public string Magic3(int w, int h, string fileName)
        {
            int k;
            int m;

            inBitMap = new Bitmap(Server.MapPath("~/Images/" + fileName));
            initializeMarixForOrderedDithering();

            for (int i = 0; i < w; i++)
                for (int j = 0; j < h; j++)
                {
                    k = i % 2;
                    m = j % 2;
                    if (Aproxim2(inBitMap.GetPixel(i, j).R) < ditherMatrix[k, m])
                    {
                        inBitMap.SetPixel(i, j, Color.White);
                    }
                    else
                    {
                        inBitMap.SetPixel(i, j, Color.Black);
                    }
                }

            inBitMap.Save(Server.MapPath("~/Images/bm/") + fileName + ".jpg", ImageFormat.Jpeg);
            return "~/Images/bm/" + fileName + ".jpg";
        }







        private void initializeMarixForOrderedDithering()
        {
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


        private int Aproxim2(int intensity)
        {
            if (intensity > 0 && intensity < 16)
                return 0;
            else
                if (intensity >= 16 && intensity < 32)
                return 1;
            else
                    if (intensity >= 32 && intensity < 48)
                return 2;
            else
                        if (intensity >= 48 && intensity < 64)
                return 3;
            else
                        if (intensity >= 64 && intensity < 80)
                return 4;
            else
                        if (intensity >= 80 && intensity < 96)
                return 5;
            else
                        if (intensity >= 96 && intensity < 112)
                return 6;
            else
                        if (intensity >= 112 && intensity < 128)
                return 7;
            else
                        if (intensity >= 128 && intensity < 144)
                return 8;
            else
                        if (intensity >= 144 && intensity < 160)
                return 9;
            else
                        if (intensity >= 160 && intensity < 176)
                return 10;
            else
                        if (intensity >= 176 && intensity < 192)
                return 11;
            else
                        if (intensity >= 192 && intensity < 208)
                return 12;
            else
                        if (intensity >= 208 && intensity < 224)
                return 13;
            else
                        if (intensity >= 224 && intensity < 240)
                return 14;
            else
                        if (intensity >= 240 && intensity < 255)
                return 15;
            else
                return 0;
        }


    }
}
