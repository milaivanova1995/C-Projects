using Online_Photo_Effects.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Photo_Effects.View
{
    public partial class Editor : System.Web.UI.Page
    {

        private Bitmap bm;
        ImageDetails imgD = new ImageDetails();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (fileUploader.HasFile)
            {
                string fileName = System.IO.Path.GetFileName(fileUploader.PostedFile.FileName);
                fileUploader.PostedFile.SaveAs(Server.MapPath("~/Images/" + fileName));
                imageBox.ImageUrl = "~/Images/" + fileName;
                Session["fileName"] = fileName;
                bm = new Bitmap(Server.MapPath(imageBox.ImageUrl));
                Session["bitMap"] = bm;
                imgD.ImageWidth = bm.Width;
                Session["w"] = imgD.ImageWidth;
                imgD.ImageHeight = bm.Height;
                Session["h"] = imgD.ImageHeight;
            }
            else
            {

            }
        }

        protected void btnMagic1_Click(object sender, EventArgs e)
        {
            imgD.ImageWidth = (int)Session["w"];
            imgD.ImageHeight = (int)Session["h"];
            string fileName = Session["fileName"].ToString();
            MagicServicesReference.MagicServicesSoapClient magic = new MagicServicesReference.MagicServicesSoapClient();
            string imageUrl = magic.Magic1(imgD.ImageWidth, imgD.ImageHeight, fileName);
            imageBox.ImageUrl = imageUrl;

        }

        protected void btnMagic2_Click(object sender, EventArgs e)
        {
            imgD.ImageWidth = (int)Session["w"];
            imgD.ImageHeight = (int)Session["h"];
            string fileName = Session["fileName"].ToString();
            MagicServicesReference.MagicServicesSoapClient magic = new MagicServicesReference.MagicServicesSoapClient();
            string imageUrl = magic.Magic2(imgD.ImageWidth, imgD.ImageHeight, fileName);

            imageBox.ImageUrl = imageUrl;

        }

        protected void btnMagic3_Click(object sender, EventArgs e)
        {
            imgD.ImageWidth = (int)Session["w"];
            imgD.ImageHeight = (int)Session["h"];
            string fileName = Session["fileName"].ToString();
            MagicServicesReference.MagicServicesSoapClient magic = new MagicServicesReference.MagicServicesSoapClient();
            string imageUrl = magic.Magic3(imgD.ImageWidth, imgD.ImageHeight, fileName);

            imageBox.ImageUrl = imageUrl;
        }
    }
}