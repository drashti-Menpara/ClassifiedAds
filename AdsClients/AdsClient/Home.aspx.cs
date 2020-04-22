using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlClient;

namespace AdsClient
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            productservice.Service1Client c1 = new productservice.Service1Client();
            List<productservice.Car> car = c1.getcar().ToList();
            List<productservice.Electronic> laptop = c1.GetElectronics().ToList();
           
            //car.ForEach(item => laptop.Add(item));

          
            Repeater1.DataSource = car;
            Repeater1.DataBind();
         //   int i1 = car.Count();
          
         
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            productservice.Service1Client c1 = new productservice.Service1Client();
            string selectvalue = selectcategory.SelectedItem.Value;
            if (selectvalue == "Laptop")
            {

                List<productservice.Electronic> laptop = c1.GetLaptop().ToList();
                Repeater1.DataSource = laptop;
                Repeater1.DataBind();
             
               
            }
            if (selectvalue == "Mobile")
            {

               // productservice.Service1Client c1 = new productservice.Service1Client();
                List<productservice.Electronic> mobile = c1.GetMobile().ToList();
                Repeater1.DataSource = mobile;
                Repeater1.DataBind();


            }
            if (selectvalue == "Book")
            {

                // productservice.Service1Client c1 = new productservice.Service1Client();
                List<productservice.Book> book = c1.GetBooks().ToList();
                Repeater1.DataSource = book;
                Repeater1.DataBind();


            }
        }
    }
}