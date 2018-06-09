using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin : System.Web.UI.Page
{
    string addAcademicianJsonBody = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        object userName = Session["username"];

        if (userName == null)
        {

            Response.Redirect("Login.aspx");

        }
        else
        {
            object user = Session["name"];
            if (user.ToString() != "Sistem")
            {
                Response.Redirect("Login.aspx");
            }
            myName.InnerHtml = "<img src='../assets/images/users/1.jpg' alt='user' class='profile-pic m-r-10' />" + Session["name"].ToString() + " " + Session["surname"].ToString();
        }

    }
    

    protected void btnAddAcademician_ServerClick(object sender, EventArgs e)
    {
        if ((exampleInputAcademicianName.Value) == "" ||(exampleInputAcademicianSurname.Value) == "" || (exampleInputAcademicianUsername.Value) == "")
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "ErrorAddAcademicianNull", "swal(\"Ayağım takıldı!\", \"Ünvan, Akademisyen Adı Soyadı veya Kullanıcı adı boş olamaz!\", \"error\");", true);
        }
        else
        {
            string academicianTitle = exampleInputAcademicianTitle.Value;
            string academicianName = exampleInputAcademicianName.Value;
            string academicianSurname = exampleInputAcademicianSurname.Value;
            string academicianuserName = exampleInputAcademicianUsername.Value;
            addAcademicianJsonBody = $"{{\"name\":\"{academicianTitle + " " + academicianName}\",\"surname\":\"{academicianSurname}\",\"username\":\"{academicianuserName}\"}}";

            try
            {
                string Url = "https://spring-kou-service.herokuapp.com/api/academician/saveAcademician";
                using (WebClient wc = new WebClient())
                {
                    wc.Headers[HttpRequestHeader.ContentType] = "application/json";
                    wc.Encoding = System.Text.Encoding.Unicode;
                    wc.UploadString(Url, addAcademicianJsonBody);
                }
                ScriptManager.RegisterStartupScript(this, this.GetType(), "SuccessAddAcademician", "swal(\"Good job!\", \"Akademisyen ekleme işlemi başarılı!\", \"success\");", true);
                exampleInputAcademicianName.Value = null;
                exampleInputAcademicianSurname.Value = null;
                exampleInputAcademicianUsername.Value = null;


            }
            catch
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ErrorAddAcademician", "swal(\"Ayağım takıldı!\", \"İşlem başarısız.Bağlantı sorunum olabilir!\", \"error\");", true);
            }
        }

        
    }

}