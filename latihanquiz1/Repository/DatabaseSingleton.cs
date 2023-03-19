using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using latihanquiz1.Model;

namespace latihanquiz1.Repository
{
    public class DatabaseSingleton
    {
        static Database1Entities db = null;
        public static Database1Entities GetInstance()
        {
            if (db == null)
            {
                db = new Database1Entities();
            }
            return db;
        }
    }
}