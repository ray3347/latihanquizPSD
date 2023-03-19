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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["user_cookie"];
            if (cookie != null)
            {
                emailTextBox.Text = cookie.Values["email"];
                passwordTextBox.Text = cookie.Values["password"];
            }
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            Database1Entities db = DatabaseSingleton.GetInstance();
            string email = emailTextBox.Text.ToString();
            string password = passwordTextBox.Text.ToString();
            User u = UserRepository.UserLogin(email, password);


            if ( u == null)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Email or password is wrong!";
            }
            else
            {
                if (cookieTextBox.Checked)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Values["email"] = email;
                    cookie.Values["password"] = password;
                    cookie.Expires.AddMinutes(2);
                    Response.Cookies.Add(cookie);
                }

                if (Application["user_count"] == null)
                {
                    Application["user_count"] = 1;
                }
                else
                {
                    Application["user_count"] = (int)Application["user_count"]+1;
                }

                Session["user"] = u;
                Response.Redirect("Home.aspx");

            }
            
        }
    }
}