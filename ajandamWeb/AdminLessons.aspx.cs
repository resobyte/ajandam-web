using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Lessons : System.Web.UI.Page
{
    List<string> AdminlessonId = new List<string>();
    List<string> AdminlessonName = new List<string>();
    List<string> AdminlessonClock = new List<string>();
    List<string> AdminlessonDay = new List<string>();
    List<string> AdminlessonLocation = new List<string>();
    List<string> AdminlessonAcademicianId = new List<string>();
    List<string> AdminlessonAcademicianName = new List<string>();
    List<string> AdminlessonAcademicianSurname = new List<string>();

    string lessonsDiv = @"<table class='table'><thead>
        <tr>
            <th>Ders Adı:</th>
            <th>Ders Günü:</th>
            <th>Ders Saati:</th>
            <th>Ders Yeri:</th>
            <th>Ders Akademisyeni:</th>
        </tr>
    </thead><tbody>";

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
            getLesson();
        }
    }

    public void getLesson()
    {

        string Url = "http://spring-kou-service.herokuapp.com/api/lesson/getAll";

        
        using (WebClient wc = new WebClient())
        {
            wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
            wc.Encoding = System.Text.Encoding.UTF8;
            string HtmlResult = wc.DownloadString(Url);
            JObject rss = JObject.Parse(HtmlResult);

            foreach (var lessons in rss["dersler"])
            {
                AdminlessonId.Add((string)lessons["id"]);
                AdminlessonName.Add((string)lessons["name"]);
                AdminlessonClock.Add((string)lessons["clock"]);
                AdminlessonDay.Add((string)lessons["day"]);
                AdminlessonLocation.Add((string)lessons["location"]);
                AdminlessonAcademicianId.Add((string)lessons["academician"]["id"]);
                AdminlessonAcademicianName.Add((string)lessons["academician"]["name"]);
                AdminlessonAcademicianSurname.Add((string)lessons["academician"]["surname"]);
            }

            for (int i = 0; i < AdminlessonId.Count; i++)
            {
                lessonsDiv += $"<tr><td><a href='#' onclick='goPost(this.id)' id='{AdminlessonId[i]}'>{AdminlessonName[i]}</a></td><td>{AdminlessonDay[i]}</td><td>{AdminlessonClock[i]}</td><td>{AdminlessonLocation[i]}</td><td>{AdminlessonAcademicianName[i] + " "+AdminlessonAcademicianSurname[i]}</td></tr>";
                ListItem myLessonList = new ListItem();
                
            }
            lessonsDiv += "</tbody></table>";
            myAdminLessons.InnerHtml = lessonsDiv;

            

        }
    }

}