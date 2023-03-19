using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using latihanquiz1.Factory;
using latihanquiz1.Model;

namespace latihanquiz1.Repository
{
    public class UserRepository
    {
        static Database1Entities db = DatabaseSingleton.GetInstance();
        public static User UserLogin(string email, string password)
        {
            User usr = (from u in db.Users
                      where u.UserEmail.Equals(email) && u.UserPassword.Equals(password)
                      select u).FirstOrDefault();
            return usr;
        }
    }
}