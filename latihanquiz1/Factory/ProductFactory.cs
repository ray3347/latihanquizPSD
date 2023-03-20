using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using latihanquiz1.Model;
using latihanquiz1.Repository;

namespace latihanquiz1.Factory
{
    public class ProductFactory
    {
        Database1Entities db = DatabaseSingleton.GetInstance();
        public static Product AddProduct(string name, int price, float rating, string image )
        {
            Product p = new Product();
            p.ProductName = name;
            p.ProductPrice = price;
            p.ProductRating = rating;
            p.ProductImage = image;
            return p;
        }

        public static void UpdateProduct(int id, string name, int price, float rating, string image)
        {
           Product p = ProductRepository.FindProduct(id);
           p.ProductName = name;
           p.ProductPrice = price;
           p.ProductRating = rating;
           p.ProductImage = image;
        }
    }
}