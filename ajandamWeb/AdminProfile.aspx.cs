using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminLayout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {   
        
        object userName = Session["username"];

        if (userName == null)
        {

            Response.Redirect("Login.aspx");

        }
        else
        {
            HiddenFieldSessionID.Value = Session["ID"].ToString();
            object user = Session["name"];
            if (user.ToString() != "Sistem")
            {
                Response.Redirect("Login.aspx");
            }
            myName.InnerHtml = "<img src='../assets/images/users/1.jpg' alt='user' class='profile-pic m-r-10' />" + Session["name"].ToString() + " " + Session["surname"].ToString();
        }
       
    }

    protected void updateProfile_ServerClick(object sender, EventArgs e)
    {
        string Url = "https://spring-kou-service.herokuapp.com/api/academician/changeProfile";


        using (WebClient wc = new WebClient())
        {
            string updateProfilejsn = "{\"name\":\""+ profileName.Value + "\",\"surname\":\""+profileSurName.Value+"\",\"username\":\""+ profileUsername.Value + "\"}";
            
          
        }
    }

    protected void updatePassword_ServerClick(object sender, EventArgs e)
    {
        

        if (!String.IsNullOrEmpty(newPassword.Value) || !String.IsNullOrEmpty(oldPassword.Value))
        {   
            if ((newPasswordAgain.Value == newPassword.Value))
            {
                try
                {
                    string Url = "https://spring-kou-service.herokuapp.com/api/login/changePassword";
                    string myParameters = $"username={Session["username"]}&password={oldPassword.Value}&newPassword={newPassword.Value}";
                    using (WebClient wc = new WebClient())
                    {
                        wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                        wc.Encoding = System.Text.Encoding.UTF8;
                        wc.UploadString(Url, myParameters);
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "SuccessUpdatePasword", "swal(\"Good job!\", \"Şifre değiştirme başarıyla gerçekleşti.\", \"success\");", true);
                    }
                }
                catch
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "ErrorAddAcademicianNull", "swal(\"Ayağım takıldı!\", \"Eski şifreniz uyuşmuyor.\", \"error\");", true);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ErrorUpdatePassword", "swal(\"Ayağım takıldı!\", \"Şifreler uyuşmuyor.\", \"error\");", true);
            }
        }
        else
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "ErrorUpdatePasswordNull", "swal(\"Ayağım takıldı!\", \"Boş geçilemez\", \"error\");", true);
        }
    }
}