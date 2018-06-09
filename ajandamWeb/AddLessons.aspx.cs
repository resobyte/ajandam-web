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
    List<string> AcademicianId = new List<string>();
    List<string> AcademicianName = new List<string>();
    List<string> AcademicianSurname = new List<string>();
    string addLessonJsonBody = "";
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

        AcademicianId.Clear();
        AcademicianName.Clear();
        AcademicianSurname.Clear();
        getAcademician();
    }

    protected void btnAddLessons_ServerClick(object sender, EventArgs e)
    {
        if ((exampleInputLessonName.Value) == "" || (exampleInputLessonDay.Value) == "" || (exampleInputLessonClock.Value) == "" || (exampleInputLessonPlace.Value) == "")
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "ErrorAddLesson", "swal(\"Ayağım takıldı!\", \"Ders Adı, Ders Günü, Ders Saati veya Ders Yeri boş olamaz!\", \"error\");", true);
        }
        else 
        {
            if (exampleInputLessonClock.Value.Contains(":"))
            {

                string LessonName = exampleInputLessonName.Value;
                string LessonDay = exampleInputLessonDay.Value;
                string LessonClock = exampleInputLessonClock.Value;
                string LessonLocation = exampleInputLessonPlace.Value;

                addLessonJsonBody = $"{{\"name\":\"{LessonName}\",";
                addLessonJsonBody += "\"academician\":{\"id\":\"" + ddlAcademician.Value + "\"},\"clock\":\"" + LessonClock + "\",\"location\":\"" + LessonLocation + "\",\"day\":\"" + LessonDay + "\"}";

                try
                {
                    string Url = "https://spring-kou-service.herokuapp.com/api/lesson/saveLesson";
                    using (WebClient wc = new WebClient())
                    {
                        wc.Headers[HttpRequestHeader.ContentType] = "application/json";
                        wc.Encoding = System.Text.Encoding.Unicode;
                        wc.UploadString(Url, addLessonJsonBody);
                    }
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "SuccessAddLessons", "swal(\"Good job!\", \"Ders ekleme işlemi başarılı!\", \"success\");", true);
                    exampleInputLessonName.Value = null;
                    exampleInputLessonDay.Value = null;
                    exampleInputLessonClock.Value = null;
                    exampleInputLessonPlace.Value = null;
                }
                catch
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "ErrorAddLessons", "swal(\"Ayağım takıldı!\", \"İşlem başarısız.Bağlantı sorunum olabilir!\", \"error\");", true);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ErrorAddClock", "swal(\"Ayağım takıldı!\", \"Ders Saati ':' içermelidir.\", \"error\");", true);
            }
        }



    }

    public void getAcademician()
    {
        string Url = $@"http://spring-kou-service.herokuapp.com/api/academician/getAcademicians";

        using (WebClient wc = new WebClient())
        {
            wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
            wc.Encoding = System.Text.Encoding.UTF8;
            string HtmlResult = wc.DownloadString(Url);
            JObject rss = JObject.Parse(HtmlResult);


            foreach (var academician in rss["academician"])
            {
                if (!(academician["id"].ToString().Equals("12")))
                {
                    AcademicianId.Add((string)academician["id"]);
                    AcademicianName.Add((string)academician["name"]);
                    AcademicianSurname.Add((string)academician["surname"]);
                }

            }

            for (int i = 0; i < AcademicianId.Count; i++)
            {
                ListItem ddlAcademicianList = new ListItem();

                ddlAcademician.DataBind();
                ddlAcademicianList.Text = AcademicianName[i] + " " + AcademicianSurname[i];
                ddlAcademicianList.Value = AcademicianId[i];
                ddlAcademician.Items.Add(ddlAcademicianList);
            }

        }
    }
}