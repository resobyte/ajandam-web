using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin : System.Web.UI.Page
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
            getData();
        }
    }

    public void getData()
     {
        string username = Session["username"].ToString();
        string Url = $"http://spring-kou-service.herokuapp.com/lessons/{username}/academicianUsername";
        

        using (WebClient wc = new WebClient())
        {
            wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
            string HtmlResult = wc.DownloadString(Url);
            var JSON = JsonConvert.DeserializeObject(HtmlResult);
            json.InnerHtml = JSON.ToString();
        }
    }
}