using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin : System.Web.UI.Page
{
    List<string> lessonName = new List<string>();
    List<string> lessonClock = new List<string>();
    List<string> lessonDay = new List<string>();
    List<string> lessonLocation = new List<string>();
    string lessonsDiv = @"<table class='table'><thead class='blue-grey lighten-4'>
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
            getData();

        }
    }

    public void getData()
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
                lessonName.Add((string)lessons["name"]);
                lessonClock.Add((string)lessons["clock"]);
                lessonDay.Add((string)lessons["day"]);
                lessonLocation.Add((string)lessons["location"]);
            }

            for (int i = 0; i < lessonName.Count; i++)
            {
                lessonsDiv += $"<tr><td>{lessonName[i]}</td><td>{lessonDay[i]}</td><td>{lessonClock[i]}</td><td>{lessonLocation[i]}</td></tr>";
            }
            lessonsDiv += "</tbody></table>";
            username.InnerHtml = rssName + " " + rssSurname;
            lessons.InnerHtml = lessonsDiv;
        }

    }

    protected void logout_ServerClick(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Login.aspx");
    }


}
