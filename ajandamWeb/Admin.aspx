<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>Ajandam Admin Paneli</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="./assets/bootstrap/css/bootstrap.min.css" />
    <link rel="stylesheet" href="./css/panel.css" />
    <link rel="stylesheet" href="assets/font-awesome/css/font-awesome.min.css" />

    <link href="./assets/datatables-plugins/dataTables.bootstrap.css" rel="stylesheet">
    <script type="text/javascript" src="./assets/jquery/jquery.js"></script>


    <link href="./assets/datatables-responsive/dataTables.responsive.css" rel="stylesheet">

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    
</head>
<body>
    		<nav class="navbar navbar-default navbar-static-top" role="navigation" style="margin-bottom: 0">
			
				<div class="navbar-header" style="padding-right: 10px;">
        <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                
					        <a class="navbar-brand" href="Admin.aspx" style="padding: 1px 8px;"><img
                    src="img/kou_logo.png" alt="KOÜ" width="50" height="50"/></img> <a href="Admin.aspx" 
                    class="navbar-brand">Ajandam Akademisyen Paneli
                  </a>
       
				</div>

				
          <ul class="nav navbar-top-links navbar-right">
                <li class="dropdown nav-item"><a>Sayın,<b> </b> Hoşgeldiniz!</a></li>
                <li class="dropdown nav-item"><a id="logout" runat="server" onserverclick="logout_ServerClick"><i class="fa fa-power-off"></i>  Çıkış</a></li>
            </ul>
				
			<div class="navbar-default sidebar" role="navigation">
                <div class="sidebar-nav navbar-collapse">
                    <ul class="nav" id="side-menu">
                      
                        <li>
                            <a href="#" onclick="duyuruGoster()"><i class="fa fa-bullhorn"></i> Duyurular</a>
                        </li>
                       
                        <li id="nav_users">
                            <a href="#" onclick="kullaniciGoster()"><i class="fa fa-users"></i> Kullanıcılar</a>
                        </li>
                        <li><a href="#" onclick="profilGoster()"><i class="fa fa-user-secret"></i> Profilim</a>
                                             
                    </ul>
                </div>
                <!-- /.sidebar-collapse -->
            </div>
		</nav>
    
    <form id="form1" runat="server">
        <div id="json" runat="server">
        </div>
    </form>
</body>
</html>
