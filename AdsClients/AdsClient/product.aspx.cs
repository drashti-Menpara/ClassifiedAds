using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;
using System.IO;
using System.Text;

namespace AdsClient
{
    public partial class product : System.Web.UI.Page
    {
        productservice.Service1Client client = new productservice.Service1Client();
       // productservicereference.Service1Client client = new productservicereference.Service1.Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (Request.QueryString["Id"] != null)
            {
                // LoadControlS(Convert.ToInt32(Request.QueryString["Id"]));
                loaddata();
               

            }
        }
        public static string StringToBinary(string data)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in data.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }
        private void ClearControls()
        {
            txtname.Text = string.Empty;
            txtbrand.Text = string.Empty;
            txtprice.Text = string.Empty;
            txtfuel.Text = string.Empty;
            txtsname.Text = string.Empty;
            txtsmno.Text = string.Empty;
            txtsaddress.Text = string.Empty;
            txtpdesc.Text = string.Empty;
          
            Button1.Text = "Add";
            txtname.Focus();
        }

        protected void btn_add(object sender, EventArgs e)
        {
            string year = dpyear.SelectedValue;

            int imagefilelenth = uploadimg1.PostedFile.ContentLength;
            byte[] imgarray = new byte[imagefilelenth];
            HttpPostedFile image = uploadimg1.PostedFile;
            image.InputStream.Read(imgarray, 0, imagefilelenth);

            // code for upoad image 2
            int imagefilelenth2 = uploadimg1.PostedFile.ContentLength;
            byte[] imgarray2 = new byte[imagefilelenth2];
            HttpPostedFile image2 = uploadimg1.PostedFile;
            image.InputStream.Read(imgarray, 0, imagefilelenth2);
            // code for upoad image 3
            int imagefilelenth3 = uploadimg1.PostedFile.ContentLength;
            byte[] imgarray3 = new byte[imagefilelenth3];
            HttpPostedFile image3 = uploadimg1.PostedFile;
            image.InputStream.Read(imgarray, 0, imagefilelenth3);

            productservice.Car car = new productservice.Car();
            car.Name = txtname.Text.ToString();
            car.Brand = txtbrand.Text.ToString();
            car.Price = Int32.Parse(txtprice.Text.ToString());
            car.Year = Int32.Parse(year);
            car.Fuel = txtfuel.Text.ToString();
            car.Description = txtpdesc.Text.ToString();
            car.Image1 = imgarray;
            car.Image2 = imgarray2;
            car.Image3 = imgarray3;
            car.SellarName = txtsname.Text.ToString();
            car.SellarAddress = txtsaddress.Text.ToString();
            car.SellarContact = txtsmno.Text.ToString();

            // car.Image1 = imgByte.ToString();
            client.addCar(car);

            ClearControls();
        }

        public void loaddata()
        {
           


            productservice.Car car = client.GetoneCar(Convert.ToInt32(Request.QueryString["Id"]));
            txtname.Text = car.Name;
            txtpdesc.Text = car.Description;
            txtprice.Text = car.Price.ToString();
            txtbrand.Text = car.Brand.ToString();
            txtfuel.Text = car.Brand;
            
            txtsaddress.Text = car.SellarAddress;
            txtsmno.Text = car.SellarContact;
            txtsname.Text = car.SellarName;
            dpyear.SelectedValue = car.Year.ToString();
            
        }

        protected void btn_Update(object sender, EventArgs e)
        {
            int imagefilelenth = uploadimg1.PostedFile.ContentLength;
            byte[] imgarray = new byte[imagefilelenth];
            HttpPostedFile image = uploadimg1.PostedFile;
            image.InputStream.Read(imgarray, 0, imagefilelenth);

            productservice.Car car = new productservice.Car();

            car.Image1 = imgarray;
            car.Name = txtname.Text.ToString();
            car.Brand = txtbrand.Text.ToString();
            car.Price = Convert.ToInt32(txtprice.Text);
            car.Year = Convert.ToInt32(dpyear.SelectedValue);
            car.SellarAddress = txtsaddress.Text.ToString();
            car.SellarContact = txtsmno.Text.ToString();
            car.SellarName = txtsname.Text.ToString();
            car.Description = txtpdesc.Text.ToString();
            car.Fuel = txtfuel.Text.ToString();
            client.UpdateCar(car);
            ClearControls();


        }
    }
}