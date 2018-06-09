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
        string email = Session["username"].ToString();
        double n;
        bool isNumeric = double.TryParse(email, out n);

        if (userName == null || isNumeric == true)
        {

            Response.Redirect("Login.aspx");

        }
        else
        {
            HiddenFieldSessionID.Value = Session["ID"].ToString();
            myName.InnerHtml = "<img src='../assets/images/users/1.jpg' alt='user' class='profile-pic m-r-10' />" + Session["name"].ToString() + " " + Session["surname"].ToString();
        }

    }

    protected void updateProfile_ServerClick(object sender, EventArgs e)
    {
        string Url = "https://spring-kou-service.herokuapp.com/api/academician/changeProfile";

        if ((profileName.Value) == "" || (profileSurName.Value) == "" || (profileUsername.Value) == "")
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "UpdateProfileErrorNull", "swal(\"Ayağım takıldı!\", \"Değerler boş geçilemez.!\", \"error\");", true);
        }
        else
        {
            try
            {
                using (WebClient wc = new WebClient())
                {

                    string updateProfilejsn = "{\"id\":\"" + Session["ID"] + "\",\"name\":\"" + profileName.Value + "\",\"surname\":\"" + profileSurName.Value + "\",\"username\":\"" + profileUsername.Value + "\"}";
                    wc.Headers[HttpRequestHeader.ContentType] = "application/json";
                    wc.Encoding = System.Text.Encoding.Unicode;
                    wc.UploadString(Url, updateProfilejsn);
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "UpdateProfile", "swal(\"Good job!\", \"Profil güncelleme  işlemi başarılı!\", \"success\");", true);
                }
            }
            catch
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "UpdateProfileError", "swal(\"Ayağım takıldı!\", \"Profil güncelleme  işlemi başarısız!\", \"error\");", true);
            }
        }

    }

    protected void updatePassword_ServerClick(object sender, EventArgs e)
    {

        if ((newPassword.Value) == "" || (oldPassword.Value) == "" || (newPasswordAgain.Value) == "")
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "ErrorUpdatePasswordNull", "swal(\"Ayağım takıldı!\", \"Boş geçilemez\", \"error\");", true);
        }
        else
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
                        var text = wc.UploadString(Url, myParameters);
                        if(text != "false")
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "SuccessUpdatePasword", "swal(\"Good job!\", \"Şifre değiştirme başarıyla gerçekleşti.\", \"success\");", true);
                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "ErrorUpdatePasword", "swal(\"Good job!\", \"Eski girdiğiniz şifre yanlış.\", \"errpor\");", true);
                        }
                        
                    }
                }
                catch
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "ErrorAddAcademicianNull", "swal(\"Ayağım takıldı!\", \"Bir sorun var.\", \"error\");", true);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ErrorUpdatePassword", "swal(\"Ayağım takıldı!\", \"Şifreler uyuşmuyor.\", \"error\");", true);
            }
        }
    }
}