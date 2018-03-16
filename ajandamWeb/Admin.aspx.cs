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
        string Url = "http://spring-kou-service.herokuapp.com/api/login";

        string myParameters = $@"username={Session["username"]}&password={Session["password"]}";

        using (WebClient wc = new WebClient())
        {
            wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
            string HtmlResult = wc.UploadString(Url, myParameters);
            var JSON = JsonConvert.DeserializeObject(HtmlResult);
           
        }

    }
}
