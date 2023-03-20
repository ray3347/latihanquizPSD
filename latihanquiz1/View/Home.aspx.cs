using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using latihanquiz1.Model;
using latihanquiz1.Factory;
using latihanquiz1.Repository;

namespace latihanquiz1.View
{
    public partial class Home : System.Web.UI.Page
    {
        public List<Model.Product> products = new List<Model.Product>();
        protected void Page_PreInit(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                this.MasterPageFile = "Menu2.Master";
                
            }
            else
            {
                this.MasterPageFile = "Menu1.Master";
               
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                registerBtn.Visible = false;
            }

            products = ProductRepository.GetTopProducts();

        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}