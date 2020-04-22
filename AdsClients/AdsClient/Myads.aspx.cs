using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdsClient
{
    public partial class Myads : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!Page.IsPostBack)
            {
                
                Displaydata();
               
               // List<productservice.Electronic> laptop = c1.GetElectronics().ToList();

                //car.ForEach(item => laptop.Add(item));


               
            }

           
        }
        public void Displaydata()
        {
            productservice.Service1Client c1 = new productservice.Service1Client();
            List<productservice.Car> car = c1.getcar().ToList();
            repmyads.DataSource = car;
            repmyads.DataBind();
        }

        protected void repmyads_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if(e.CommandName== "DeleteRecord" && e.CommandArgument!= null)
            {
                int value = Convert.ToInt32(e.CommandArgument);
                Label1.Text = value.ToString();
                DeleteCar(Convert.ToInt32(e.CommandArgument));
            }
            if(e.CommandName=="UpdateRecord" && e.CommandArgument !=null)
            {
                int value = Convert.ToInt32(e.CommandArgument);
                Label1.Text = value.ToString();
                string target = String.Format("product.aspx?Id={0}", Label1.Text);
                Response.Redirect(target);
            }
        }
        public void DeleteCar(Int32 Id)
        {
            try
            {
                productservice.Service1Client c1 = new productservice.Service1Client();
                string car = c1.deletcar(Id);
                Displaydata();
            }
            catch(Exception)
            {
                Label1.Text = "data nnot  deleted";
            }

        }
       
        
    }
}