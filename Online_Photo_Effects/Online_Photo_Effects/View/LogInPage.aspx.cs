using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Online_Photo_Effects.Model;
using Online_Photo_Effects.Code;

namespace Online_Photo_Effects.View
{
    public partial class LogInPage : System.Web.UI.Page
    {
        userAccountsEntities users = new userAccountsEntities();
        Helper helper = new Helper();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            if (helper.checkUsername(username))
            {
                if (helper.checkPassword(password))
                {
                    var user = users.user_accounts.FirstOrDefault(u => u.userName == username);
                    if (user != null)
                    {
                        if (user.password == password)
                        {
                            if (user.premium == 0)
                            {
                                Server.Transfer("Editor.aspx");
                            }
                        }
                        else
                        {
                            lblPass.Text = "Incorrect login credentials";
                        }

                    }
                }
                else
                {
                    lblPass.Text = "Check the password lenght";
                }
                
            }
            else
            {
                lblUsername.Text = "Check the username lenght";
            }
            


        }
    }
}