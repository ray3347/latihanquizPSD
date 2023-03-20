using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using latihanquiz1.Model;
using latihanquiz1.Factory;

namespace latihanquiz1.Repository
{
    public class ProductRepository
    {
        static Database1Entities db = DatabaseSingleton.GetInstance();
        public static List<Product> GetAllProducts()
        {
            return db.Products.ToList();
        }

        public static List<Product> GetTopProducts()
        {
            return db.Products.OrderByDescending(x => x.ProductRating).Take(6).ToList();
        }

        public static Product FindProduct(int id)
        {
            Product p = db.Products.Find(id);
            return p;

        }
    }
}