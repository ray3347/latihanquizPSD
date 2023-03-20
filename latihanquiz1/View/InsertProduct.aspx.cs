using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using latihanquiz1.Model;
using latihanquiz1.Repository;
using latihanquiz1.Factory;

namespace latihanquiz1.View
{
    public partial class InsertProduct : System.Web.UI.Page
    {
        Database1Entities db = DatabaseSingleton.GetInstance();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void insertButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.ToString();
            int price = Int32.Parse(priceTextBox.Text);
            float rating = float.Parse(ratingTextBox.Text);
            string image = imageTextBox.Text.ToString();
            Model.Product p = ProductFactory.AddProduct(name, price, rating, image);
            db.Products.Add(p);
            DataBind();
            db.SaveChanges();
            nameTextBox.Text = "";
            priceTextBox.Text = "";
            ratingTextBox.Text = "";
            imageTextBox.Text = "";
;        }
    }
}