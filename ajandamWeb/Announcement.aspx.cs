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


    List<string> lessonId = new List<string>();
    List<string> lessonName = new List<string>();
    List<string> lessonClock = new List<string>();
    List<string> lessonDay = new List<string>();
    List<string> lessonLocation = new List<string>();

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
        lessonName.Clear();
        lessonClock.Clear();
        lessonDay.Clear();
        lessonLocation.Clear();
        MyAnnouncementLesson.Items.Clear();

        object user = Session["username"];


        if (user == null)
        {
            Response.Redirect("Login.aspx");
        }
        else
        {
            myName.InnerHtml = "<img src='../assets/images/users/1.jpg' alt='user' class='profile-pic m-r-10' />" + Session["name"].ToString() + " " + Session["surname"].ToString();
            getLesson();
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
                lessonsDiv += $"<tr><td><a href='#' onclick='getText(this.id)' id='{AnnouncementId[i]}'>{AnnouncementTitle[i]}</a></td><td><p id='a{AnnouncementId[i]}'>{AnnouncementContent[i]}</p></td><td><p id='d{AnnouncementId[i]}'>{AnnouncementDate[i]}<p></td><td>{AnnouncementLesson[i]}</td></tr>";
                
                
            }
            lessonsDiv += "</tbody></table>";
            myAnnouncement.InnerHtml = lessonsDiv;

        }
    }

    protected void btnInsertAnnouncement_ServerClick(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(MyAnnouncementTitle.Text) || String.IsNullOrEmpty(MyAnnouncementBody.Text))
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "ErrorPageAnnouncement", "swal(\"Ayağım takıldı!\", \"Duyuru başlığı veya Duyuru içeriği boş olamaz!\", \"error\");", true);
        }

        else
        {
            string insertAnnouncementjson = $"{{\"title\":\"{MyAnnouncementTitle.Text}\",\"content\":\"{MyAnnouncementBody.Text}\",";
            insertAnnouncementjson += "\"academician\":{\"id\":\"" + Session["ID"] + "\"},\"lesson\":{\"id\":\"" + MyAnnouncementLesson.SelectedValue + "\"}}";

            string Url = $"https://spring-kou-service.herokuapp.com/api/announcement";
            using (WebClient wc = new WebClient())
            {
                wc.Headers[HttpRequestHeader.ContentType] = "application/json";
                wc.Encoding = System.Text.Encoding.Unicode;
                wc.UploadString(Url, insertAnnouncementjson);
            }

            ScriptManager.RegisterStartupScript(this, this.GetType(), "SuccessPageAnnouncement", "swal(\"İşlem tamam!\", \"Duyurunuz başarı ile iletildi.\", \"success\");", true);

            formAnnouncement.Controls.Clear();
            Response.Redirect("Announcement.aspx");

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

            foreach (var lessons in rss["lessons"])
            {
                lessonId.Add((string)lessons["id"]);
                lessonName.Add((string)lessons["name"]);
                lessonClock.Add((string)lessons["clock"]);
                lessonDay.Add((string)lessons["day"]);
                lessonLocation.Add((string)lessons["location"]);
                ListItem myAnnouncementList = new ListItem();
                myAnnouncementList.Text = (string)lessons["name"];
                myAnnouncementList.Value = (string)lessons["id"];
                MyAnnouncementLesson.Items.Add(myAnnouncementList);
            }

        }
    }
}