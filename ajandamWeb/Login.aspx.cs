using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string email = String.Format("{0}", Request.Form["email"]);
        string password = String.Format("{0}", Request.Form["password"]);

        string Url = "http://spring-kou-service.herokuapp.com/api/login";

        string myParameters = $@"username={email}&password={password}";



        using (WebClient wc = new WebClient())
        {
            wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
            wc.Encoding = System.Text.Encoding.UTF8;
            string HtmlResult = wc.UploadString(Url, myParameters);
            JObject rss = JObject.Parse(HtmlResult);

            if (HtmlResult == "{}")
            {
                alertMessage.Style.Remove("display");
                string errorMessage = "<div style='text-align:center' class='alert alert-danger'><b>Kullanıcı Adı veya Şifre yanlış<b></div>";
                alertMessage.InnerHtml = errorMessage;
            }
            else
            {
                string ID = (string)rss["data"][0]["id"];
                string rssName = (string)rss["data"][0]["name"];
                string rssSurname = (string)rss["data"][0]["surname"];
                Session.Add("username", email);
                Session.Add("password", password);
                Session.Add("name", rssName);
                Session.Add("surname", rssSurname);
                Session.Add("ID", ID);
                double n;
                bool isNumeric = double.TryParse(email, out n);
                
                if(isNumeric == true)
                {
                    alertMessage.Style.Remove("display");
                    string errorMessage = "<div style='text-align:center' class='alert alert-danger'><b>Giriş yetkiniz yok!<b></div>";
                    alertMessage.InnerHtml = errorMessage;
                }

                else
                {
                    if (rssName == "Sistem")
                        Response.Redirect("AdminLessons.aspx");

                    else
                        Response.Redirect("Lessons.aspx");
                }



                
            }
        }


    }
}