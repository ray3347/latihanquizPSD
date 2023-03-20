﻿using System;
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
    public partial class Product : System.Web.UI.Page
    {
        public List<Model.Product> products = new List<Model.Product>();
        protected void Page_Load(object sender, EventArgs e)
        {
            products = ProductRepository.GetAllProducts();
        }
            

    }
}
