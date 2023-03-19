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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (dobCalendar.SelectedDate != null)
            {
                DateTime dob = dobCalendar.SelectedDate;
                dobTextBox.Text = dob.ToString();
            }
            
        }

        protected void regBtn_Click(object sender, EventArgs e)
        {
            Database1Entities db = DatabaseSingleton.GetInstance();
            string email = CheckEmail(emailTextBox.Text.ToString());
            string name = nameTextBox.Text.ToString();
            string password = passTextBox.Text.ToString();
            string gender = CheckGender();
            
            DateTime dob = dobCalendar.SelectedDate;
            string profilepict = proFile.ToString();
            if (email == null)
            {
                errorLabel.Visible = true;
            }
            else if (tocCheckBox.Checked == true)
            {
                User u = UserFactory.AddUser(email, name, password, gender, dob, profilepict);
                db.Users.Add(u);
                DataBind();
                db.SaveChanges();
                Response.Redirect("Login.aspx");
            }
            else
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Please check the Terms and Conditions Box!";
            }

        }

        protected string CheckGender()
        {
            string gender = null;
            if (maleRadio.Text.Equals("Male"))
            {
                gender = maleRadio.Text;
            }
            else if (femaleRadio.Text.Equals("Female"))
            {
                gender = femaleRadio.Text;
            }
            return gender;
        }

        protected string CheckEmail(string email)
        {
            if (!email.Contains("@") && !email.Contains("."))
            {
                errorLabel.Text = "Please use the correct email format!";
                return null;
            }
            else if(email[0].Equals("@")|| email[0].Equals("."))
            {
                errorLabel.Text = "Please use the correct email format!";
                return null;
            }
            else if(email[email.Length-1].Equals("@")|| email[email.Length - 1].Equals("."))
            {
                errorLabel.Text = "Please use the correct email format!";
                return null;
            }
            return email;
        }

        
    }
}