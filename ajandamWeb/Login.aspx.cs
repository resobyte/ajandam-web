using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

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
            string HtmlResult = wc.UploadString(Url, myParameters);
            var JSON = JsonConvert.DeserializeObject(HtmlResult);

            if (HtmlResult == "{}")
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                Response.Redirect("Admin.aspx");
            }
        }
        
       
    }
}