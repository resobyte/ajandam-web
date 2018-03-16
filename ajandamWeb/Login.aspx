<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>


<!DOCTYPE HTML5>
<html>

<head>
    <title>Ajandam - Akademisyen Girişi</title>
    <link rel="stylesheet" type="text/css" href="assets/bootstrap/css/bootstrap.min.css">
    <link rel="stylesheet" href="assets/font-awesome/css/font-awesome.min.css" />
    <link rel="stylesheet" type="text/css" href="css/giris.css">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
</head>

<body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="row vertical-offset-100">
            <div class="col-md-4 col-md-offset-4">
                <div class="panel panel-default login">
                    <div class="panel-heading">
                       
                        <br>
                        <div class="row-fluid user-row">
                            <img width="100" height="100" src="./img/koub.png" />
                        </div>
                        <br>
                        <h3 class="panel-title user-row">Ajandam</h3>
                        <hr>
                        <label>Akademisyen Girişi</label>
                    </div>
                    <div class="panel-body">
                        <span></span>
                         <div id="alertMessage" runat="server" role="alert" syle="display: none; text-align: center;">
                        </div>  
                        <fieldset>
                            <div class="form-group">
                                <input class="form-control" required placeholder="&#xf007;  Kullanıcı Adı" id="email"
                                    type="text" style="font-family: Arial,FontAwesome" runat="server">
                            </div>
                            <div class="form-group">
                                <input class="form-control" required placeholder="&#xf023;   Şifre" id="password"
                                    type="password" style="font-family: Arial, FontAwesome" runat="server">
                            </div>
                            
                            <asp:Button Class="btn btn-lg btn-success btn-block" ID="btnLogin" runat="server" Text="Giriş" OnClick="btnLogin_Click" />
                        </fieldset>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- JAVASCRIPT SOURCES -->
    <script src="assets/jquery/jquery.min.js"></script>
    <script src="assets/bootstrap/js/bootstrap.min.js"></script>
    </form>
</body>

</html>

