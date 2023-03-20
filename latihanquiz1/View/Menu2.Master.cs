using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace latihanquiz1.View
{
    public partial class Menu2 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Application["user_count"] = (int)Application["user_count"] - 1;
            Session.Clear();
            Response.Redirect("Home.aspx");
            
        }

        protected void btnProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("Product.aspx");
        }

        protected void btnInsertProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertProduct.aspx");
        }

        protected void btnUpdateDeleteProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("ModifyProduct.aspx");
        }
    }
}