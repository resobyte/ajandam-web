using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Lessons : System.Web.UI.Page
{
    List<string> AnnouncementId = new List<string>();
    List<string> AnnouncementTitle = new List<string>();
    List<string> AnnouncementContent = new List<string>();
    List<string> AnnouncementDate = new List<string>();
    List<string> AnnouncementLesson = new List<string>();

    string lessonsDiv = @"<table class='table'><thead>
        <tr>
            <th>Duyuru Başlığı</th>
            <th>Duyuru İçeriği</th>
            <th>Duyuru Tarihi</th>
            <th>Duyuru Dersi</th>
        </tr>
    </thead><tbody>";



    protected void Page_Load(object sender, EventArgs e)
    {
        object user = Session["username"];


        if (user == null)
        {
            Response.Redirect("Login.aspx");
        }
        else
        {
            myName.InnerHtml = "<img src='../assets/images/users/1.jpg' alt='user' class='profile-pic m-r-10' />" + Session["name"].ToString() + " " + Session["surname"].ToString();
            getAnnouncements();
        }
    }

    public void getAnnouncements()
    {
        string Url = $@"https://spring-kou-service.herokuapp.com/api/announcement/academician?academicianId={Session["ID"]}";

        using (WebClient wc = new WebClient())
        {
            wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
            wc.Encoding = System.Text.Encoding.UTF8;
            string HtmlResult = wc.DownloadString(Url);
            JObject rss = JObject.Parse(HtmlResult);


            foreach (var announcement in rss["duyurular"])
            {
                AnnouncementId.Add((string)announcement["id"]);
                AnnouncementTitle.Add((string)announcement["title"]);
                AnnouncementContent.Add((string)announcement["content"]);
                AnnouncementDate.Add((string)announcement["date"]);
                AnnouncementLesson.Add((string)announcement["lesson"]["name"]);
            }



            for (int i = 0; i < AnnouncementTitle.Count; i++)
            {
                lessonsDiv += $"<tr><td><a href='' id='{AnnouncementId[i]}'>{AnnouncementTitle[i]}</a></td><td>{AnnouncementContent[i]}</td><td>{AnnouncementDate[i]}</td><td>{AnnouncementLesson[i]}</td></tr>";
            }
            lessonsDiv += "</tbody></table>";
            myAnnouncement.InnerHtml = lessonsDiv;



            //foreach (var lessons in rss["lessons"])
            //{
            //    string toDays = (string)lessons["day"];
            //    if (toDays == Convert.ToString(days[day]))
            //    {
            //        lessonName.Add((string)lessons["name"]);
            //        lessonClock.Add((string)lessons["clock"]);
            //        lessonDay.Add((string)lessons["day"]);
            //        lessonLocation.Add((string)lessons["location"]);
            //    }
            //}

            //if (lessonName.Count != 0)
            //{
            //    for (int i = 0; i < lessonName.Count; i++)
            //    {
            //        lessonstodayDiv += $"<tr><td><a href='' id='{lessonId[i]}'>{lessonName[i]}</a></td><td>{lessonDay[i]}</td><td>{lessonClock[i]}</td><td>{lessonLocation[i]}</td></tr>";
            //    }
            //    lessonstodayDiv += "</tbody></table>";
            //    todaymyLessons.InnerHtml = lessonstodayDiv;
            //}

            //else
            //{
            //    todaymyLessons.InnerHtml = "<p> Bugün dersiniz yok! ";
            //}
        }
    }
    }