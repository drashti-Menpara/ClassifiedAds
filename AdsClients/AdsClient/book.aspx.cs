using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdsClient
{
    public partial class book : System.Web.UI.Page
    {
        productservice.Service1Client client = new productservice.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void ClearControls()
        {
            txtname.Text = string.Empty;
          
            txtprice.Text = string.Empty;
           
            txtsname.Text = string.Empty;
            txtsmno.Text = string.Empty;
            txtsaddress.Text = string.Empty;
            txtpdesc.Text = string.Empty;

            Button1.Text = "Add";
            txtname.Focus();
        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
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

            productservice.Book book = new productservice.Book();
            book.Name = txtname.Text.ToString();

            book.Price = Int32.Parse(txtprice.Text.ToString());
            book.Year = Int32.Parse(year);

            book.Description = txtpdesc.Text.ToString();
            book.Image1 = imgarray;
            book.Image2 = imgarray2;
            book.Image3 = imgarray3;
            book.SellarName = txtsname.Text.ToString();
            book.sellarAddress = txtsaddress.Text.ToString();
            book.SellarContact = txtsmno.Text.ToString();

            // car.Image1 = imgByte.ToString();
            client.addBook(book);
            ClearControls();
        }
    }
}