using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminLayout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        object user = Session["username"];


        if (user == null)
        {
            Response.Redirect("Login.aspx");
        }
        else
        {
            myName.InnerHtml = "<img src='../assets/images/users/1.jpg' alt='user' class='profile-pic m-r-10' />" + Session["name"].ToString()+" "+ Session["surname"].ToString();
        }




    }
}