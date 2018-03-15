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
        <div class="container">
            <div class="row vertical-offset-100">
                <div class="col-md-4 col-md-offset-4">
                    <div class="panel panel-default login">
                        <div class="panel-heading">
                            <div id="alertMessage" class="alert alert-danger" role="alert" style="display:none; text-align:center;">
                               
                            </div>
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
                            <form accept-charset="UTF-8" role="form" method="POST" action="Login.aspx">
                                <fieldset>
                                    <div class="form-group">
                                        <input class="form-control" required placeholder="&#xf007;  E-mail" id="email"
                                         type="text" style="font-family:Arial,FontAwesome" runat="server">
                                    </div>
                                    <div class="form-group">
                                        <input class="form-control" required placeholder="&#xf023;   Şifre" id="password"
                                         type="password" value="" style="font-family:Arial, FontAwesome" runat="server">
                                    </div>
                                    <input class="btn btn-lg btn-success btn-block" type="submit" value="Giriş" runat="server">
                                </fieldset>
                            </form>
                            <div style="text-align: center;">
                                <a href="/index.php">Ana Sayfaya dön.</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- JAVASCRIPT SOURCES -->
        <script src="assets/jquery/jquery.min.js"></script>
        <script src="assets/bootstrap/js/bootstrap.min.js"></script>
    </body>

    </html>

