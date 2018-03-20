using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Lessons : System.Web.UI.Page
{
    List<string> lessonId = new List<string>();
    List<string> lessonName = new List<string>();
    List<string> lessonClock = new List<string>();
    List<string> lessonDay = new List<string>();
    List<string> lessonLocation = new List<string>();

    string lessonsDiv = @"<table class='table'><thead>
        <tr>
            <th>Ders Adı:</th>
            <th>Ders Günü:</th>
            <th>Ders Saati:</th>
            <th>Ders Yeri:</th>
        </tr>
    </thead><tbody>";

    string lessonstodayDiv = @"<table class='table'><thead>
        <tr>
            <th>Ders Adı:</th>
            <th>Ders Günü:</th>
            <th>Ders Saati:</th>
            <th>Ders Yeri:</th>
        </tr>
    </thead><tbody>";


    protected void Page_Load(object sender, EventArgs e)
    {
        lessonName.Clear();
        lessonClock.Clear();
        lessonDay.Clear();
        lessonLocation.Clear();

        object user = Session["username"];


        if (user == null)
        {
            Response.Redirect("Login.aspx");
        }
        else
        {
            myName.InnerHtml = "<img src='../assets/images/users/1.jpg' alt='user' class='profile-pic m-r-10' />" + Session["name"].ToString() + " " + Session["surname"].ToString();
            getLesson();
        }
    }

    public void getLesson()
    {
        string Url = "http://spring-kou-service.herokuapp.com/api/login";

        string myParameters = $@"username={Session["username"]}&password={Session["password"]}";

        using (WebClient wc = new WebClient())
        {
            wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
            wc.Encoding = System.Text.Encoding.UTF8;
            string HtmlResult = wc.UploadString(Url, myParameters);
            JObject rss = JObject.Parse(HtmlResult);
            string rssName = (string)rss["data"][0]["name"];
            string rssSurname = (string)rss["data"][0]["surname"];
            string[] days = { "Pazar", "Pazartesi", "Salı", "Çarşamba", "Perşembe","Cuma", "Cumartesi" };
            DateTime toDay = DateTime.Today;
            int day = Convert.ToInt32(toDay.DayOfWeek);

            foreach (var lessons in rss["lessons"])
            {
                lessonId.Add((string)lessons["id"]);
                lessonName.Add((string)lessons["name"]);
                lessonClock.Add((string)lessons["clock"]);
                lessonDay.Add((string)lessons["day"]);
                lessonLocation.Add((string)lessons["location"]);
            }

            for (int i = 0; i < lessonName.Count; i++)
            {
                lessonsDiv += $"<tr><td><a href='' id='{lessonId[i]}'>{lessonName[i]}</a></td><td>{lessonDay[i]}</td><td>{lessonClock[i]}</td><td>{lessonLocation[i]}</td></tr>";
            }
            lessonsDiv += "</tbody></table>";
            myLessons.InnerHtml = lessonsDiv;

            lessonName.Clear();
            lessonClock.Clear();
            lessonDay.Clear();
            lessonLocation.Clear();

            foreach (var lessons in rss["lessons"]) 
            {
                string toDays=(string)lessons["day"];
                if ( toDays == Convert.ToString(days[day]))
                {
                    lessonName.Add((string)lessons["name"]);
                    lessonClock.Add((string)lessons["clock"]);
                    lessonDay.Add((string)lessons["day"]);
                    lessonLocation.Add((string)lessons["location"]);
                }
            }

            if (lessonName.Count!=0)
            {
                for (int i = 0; i < lessonName.Count; i++)
                {
                    lessonstodayDiv += $"<tr><td><a href='' id='{lessonId[i]}'>{lessonName[i]}</a></td><td>{lessonDay[i]}</td><td>{lessonClock[i]}</td><td>{lessonLocation[i]}</td></tr>";
                }
                lessonstodayDiv += "</tbody></table>";
                todaymyLessons.InnerHtml = lessonstodayDiv;
            }

            else
            {
                todaymyLessons.InnerHtml = "<p> Bugün dersiniz yok! ";
            }
        }

    }
}