using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdsClient
{
    public partial class laptop : System.Web.UI.Page
    {
        productservice.Service1Client client = new productservice.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void ClearControls()
        {
            txtname.Text = string.Empty;
            txtcolor.Text = string.Empty;
            txtprice.Text = string.Empty;
            txtmodel.Text = string.Empty;
            txtsname.Text = string.Empty;
            txtsmno.Text = string.Empty;
            txtsaddress.Text = string.Empty;
            txtpdesc.Text = string.Empty;
            
            btnlaptop.Text = "Add";
            txtname.Focus();
        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
            productservice.Electronic laptop = new productservice.Electronic();
            string year = dpyear.SelectedValue;

            int imagefilelenth = uploadimg1.PostedFile.ContentLength;
            byte[] imgarray = new byte[imagefilelenth];
            HttpPostedFile image = uploadimg1.PostedFile;
            image.InputStream.Read(imgarray, 0, imagefilelenth);

            // code for upoad image 2
            int imagefilelenth2 = uploadimg2.PostedFile.ContentLength;
            byte[] imgarray2 = new byte[imagefilelenth2];
            HttpPostedFile image2 = uploadimg2.PostedFile;
            image.InputStream.Read(imgarray, 0, imagefilelenth2);
            // code for upoad image 3
            int imagefilelenth3 = uploadimg3.PostedFile.ContentLength;
            byte[] imgarray3 = new byte[imagefilelenth3];
            HttpPostedFile image3 = uploadimg3.PostedFile;
            image.InputStream.Read(imgarray, 0, imagefilelenth3);

            
           laptop.Name = txtname.Text.ToString();
            laptop.Type = dpitem.SelectedItem.Value.ToString();
            laptop.Model = txtmodel.ToString();
            laptop.Price = Int32.Parse(txtprice.Text.ToString());
            laptop.Year = Int32.Parse(year);
            laptop.Color = txtcolor.Text.ToString();
            laptop.Description = txtpdesc.Text.ToString();
            laptop.Image1 = imgarray;
            laptop.Image2 = imgarray2;
            laptop.Image3 = imgarray3;
            laptop.SellarName = txtsname.Text.ToString();
            laptop.SellarAddress = txtsaddress.Text.ToString();
            laptop.SellarContact = txtsmno.Text.ToString();

            string myStringVariable = "data inserted succes";
            string msg = "not inserted";
            if (client.addElectornics(laptop))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + myStringVariable + "');", true);
            }
            else {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + msg + "');", true);
            }
            // car.Image1 = imgByte.ToString();
            

            ClearControls();

        }
    }
}