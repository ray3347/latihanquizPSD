using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using latihanquiz1.Model;
using latihanquiz1.Repository;

namespace latihanquiz1.Factory
{
    public class UserFactory
    {
        Database1Entities db = DatabaseSingleton.GetInstance();
        public static User AddUser(string email, string name, string password, string gender, DateTime dob, string profpict)
        {
            User u = new User();
            u.UserEmail = email;
            u.Username = name;
            u.UserPassword = password;
            u.UserGender = gender;
            u.UserDOB = dob;
            u.UserProfilePicture = profpict;
            return u;
        }
    }
}