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
    public partial class ModifyProduct : System.Web.UI.Page
    {
        static Database1Entities db = DatabaseSingleton.GetInstance();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            productsGridView.DataSource = ProductRepository.GetAllProducts();
            productsGridView.DataBind();
        }

        protected void productsGridView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = productsGridView.Rows[e.NewEditIndex];
            int id = Int32.Parse(row.Cells[1].Text);

            Model.Product p = ProductRepository.FindProduct(id);

            idTextBox.Text = p.ProductId.ToString();
            nameTextBox.Enabled = true;
            nameTextBox.Text = p.ProductName.ToString();
            priceTextBox.Enabled = true;
            priceTextBox.Text = p.ProductPrice.ToString();
            imageTextBox.Enabled = true;
            imageTextBox.Text = p.ProductImage.ToString();
            ratingTextBox.Enabled = true;
            ratingTextBox.Text = p.ProductRating.ToString();
            updateBtn.Enabled = true;

        }

        protected void productsGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = productsGridView.Rows[e.RowIndex];
            int id = Int32.Parse(row.Cells[1].Text);

            db.Products.Remove(ProductRepository.FindProduct(id));
            db.SaveChanges();

            productsGridView.DataSource = ProductRepository.GetAllProducts();
            productsGridView.DataBind();

        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(idTextBox.Text);
            string name = nameTextBox.Text.ToString();
            int price = Int32.Parse(priceTextBox.Text);
            string image = imageTextBox.Text.ToString();
            float rating = float.Parse(ratingTextBox.Text);
            ProductFactory.UpdateProduct(id, name, price, rating, image);
            db.SaveChanges();
            productsGridView.DataSource = ProductRepository.GetAllProducts();
            productsGridView.DataBind();
            Response.Redirect("ModifyProduct.aspx");

        }
    }
}