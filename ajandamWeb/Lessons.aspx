<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Lessons.aspx.cs" Inherits="Lessons" EnableEventValidation="false" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <!-- Tell the browser to be responsive to screen width -->
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">
    <!-- Favicon icon -->
    <link rel="icon" type="image/png" sizes="16x16" href="img/logo.png">
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
    <title>Ajandam Web</title>
    <!-- Bootstrap Core CSS -->
    <script src="js/sweetalert.min.js"></script>
    <link href="../assets/plugins/bootstrap/css/bootstrap.min.css" rel="stylesheet">
    <!-- Custom CSS -->
    <link href="css/style.css" rel="stylesheet">
    <!-- You can change the theme colors from here -->
    <link href="css/colors/blue.css" id="theme" rel="stylesheet">
    <script src="https://unpkg.com/sweetalert2@7.8.2/dist/sweetalert2.all.js"></script>
    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
    <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
    <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
<![endif]-->
</head>

<body class="fix-header fix-sidebar card-no-border">
    <!-- ============================================================== -->
    <!-- Preloader - style you can find in spinners.css -->
    <!-- ============================================================== -->
    <div class="preloader">
        <svg class="circular" viewBox="25 25 50 50">
            <circle class="path" cx="50" cy="50" r="20" fill="none" stroke-width="2" stroke-miterlimit="10" />
        </svg>
    </div>
    <!-- ============================================================== -->
    <!-- Main wrapper - style you can find in pages.scss -->
    <!-- ============================================================== -->
    <div id="main-wrapper">
        <!-- ============================================================== -->
        <!-- Topbar header - style you can find in pages.scss -->
        <!-- ============================================================== -->
        <header class="topbar">
            <nav class="navbar top-navbar navbar-toggleable-sm navbar-light">
                <!-- ============================================================== -->
                <!-- Logo -->
                <!-- ============================================================== -->
                <div class="navbar-header">
                    <a class="navbar-brand" href="Lessons.aspx">
                        <!-- Logo icon -->
                        <b>
                            <!--You can put here icon as well // <i class="wi wi-sunset"></i> //-->

                            <!-- Light Logo icon -->
                            <img src="../img/logo.png" alt="homepage" class="light-logo" width="50" height="50" />
                            <%-- Ajandam ICO--%>
                        </b>
                        <!--End Logo icon -->
                        <!-- Logo text -->
                        <span>

                            <!-- Light Logo text -->
                            <%--<img src="../assets/images/logo-light-text.png" class="light-logo" alt="homepage" /></span>--%> </a>
                </div>
                <!-- ============================================================== -->
                <!-- End Logo -->
                <!-- ============================================================== -->
                <div class="navbar-collapse">
                    <!-- ============================================================== -->
                    <!-- toggle and nav items -->
                    <!-- ============================================================== -->
                    <ul class="navbar-nav mr-auto mt-md-0">
                        <!-- This is  -->
                        <li class="nav-item"><a class="nav-link nav-toggler hidden-md-up text-muted waves-effect waves-dark" href="javascript:void(0)"><i class="mdi mdi-menu"></i></a></li>
                        <!-- ============================================================== -->
                        <!-- Search -->
                        <!-- ============================================================== -->
                        <li class="nav-item hidden-sm-down search-box"><a class="nav-link hidden-sm-down text-muted waves-effect waves-dark" href="javascript:void(0)"><i class="ti-search"></i></a>
                            <form class="app-search">
                                <input type="text" class="form-control" placeholder="Search & enter">
                                <a class="srh-btn"><i class="ti-close"></i></a>
                            </form>
                        </li>
                    </ul>
                    <!-- ============================================================== -->
                    <!-- User profile and search -->
                    <!-- ============================================================== -->
                    <ul class="navbar-nav my-lg-0">
                        <!-- ============================================================== -->
                        <!-- Profile -->
                        <!-- ============================================================== -->
                        <li class="nav-item dropdown">
                            <a class="nav-link dropdown-toggle text-muted waves-effect waves-dark" runat="server" id="myName" href="Profile.aspx" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></a>
                        </li>
                    </ul>
                </div>
            </nav>
        </header>
        <!-- ============================================================== -->
        <!-- End Topbar header -->
        <!-- ============================================================== -->
        <!-- ============================================================== -->
        <!-- Left Sidebar - style you can find in sidebar.scss  -->
        <!-- ============================================================== -->
        <aside class="left-sidebar">
            <!-- Sidebar scroll-->
            <div class="scroll-sidebar">
                <!-- Sidebar navigation-->
                <nav class="sidebar-nav">
                    <ul id="sidebarnav">
                        <li><a class="waves-effect waves-dark" href="Lessons.aspx" aria-expanded="false"><i class="mdi mdi-book"></i><span class="hide-menu">Derslerim</span></a>
                        </li>
                        <li><a class="waves-effect waves-dark" href="Announcement.aspx" aria-expanded="false"><i class="mdi mdi-bullhorn"></i><span class="hide-menu">Duyurular</span></a>
                        </li>
                        <li><a class="waves-effect waves-dark" href="Profile.aspx" aria-expanded="false"><i class="mdi mdi-account-check"></i><span class="hide-menu">Profilim</span></a>
                        </li>
                        <%--<li><a class="waves-effect waves-dark" href="map-google.html" aria-expanded="false"><i class="mdi mdi-earth"></i><span class="hide-menu">Google Map</span></a>
                        </li>
                        <li><a class="waves-effect waves-dark" href="pages-blank.html" aria-expanded="false"><i class="mdi mdi-book-open-variant"></i><span class="hide-menu">Blank Page</span></a>
                        </li>
                        <li><a class="waves-effect waves-dark" href="pages-error-404.html" aria-expanded="false"><i class="mdi mdi-help-circle"></i><span class="hide-menu">Error 404</span></a>
                        </li>--%>
                    </ul>
                </nav>
                <!-- End Sidebar navigation -->
            </div>
            <!-- End Sidebar scroll-->
            <!-- Bottom points-->
            <div class="sidebar-footer">
                <!-- item-->
                <a href="Profile.aspx" class="link" data-toggle="tooltip" title="Settings"><i class="ti-settings"></i></a>
                <!-- item-->
                <a href="Session.aspx" class="link" data-toggle="tooltip" title="Logout"><i class="mdi mdi-power"></i></a>
            </div>
            <!-- End Bottom points-->
        </aside>
        <!-- ============================================================== -->
        <!-- End Left Sidebar - style you can find in sidebar.scss  -->
        <!-- ============================================================== -->
        <!-- ============================================================== -->
        <!-- Page wrapper  -->
        <!-- ============================================================== -->
        <div class="page-wrapper">
            <!-- ============================================================== -->
            <!-- Container fluid  -->
            <!-- ============================================================== -->
            <div class="container-fluid">
                <!-- ============================================================== -->
                <!-- Bread crumb and right sidebar toggle -->
                <!-- ============================================================== -->
                <div class="row page-titles">
                    <div class="col-md-5 col-8 align-self-center">
                        <h3 class="text-themecolor m-b-0 m-t-0">Derslerim</h3>
                        <ol class="breadcrumb">
                            <li class="breadcrumb-item"><a href="javascript:void(0)">Home</a></li>
                            <li class="breadcrumb-item active">Derslerim</li>
                        </ol>
                    </div>
                </div>

                <a href="#addLesson" class="link" data-toggle="modal" title="Derse Öğrenci Ekle"><i class="ti-plus"></i></a>
                <br />
                <div class="modal fade" id="addLesson" role="dialog">
                    <div class="modal-dialog">

                        <!-- Modal content-->
                        <div class="modal-content">
                            <div class="row">
                                <!-- column -->
                                <div class="col-lg-12">
                                    <div class="card">
                                        <div class="card-block">
                                            <div class="modal-header">
                                                <button type="button" class="close" data-dismiss="modal">&times;</button>
                                                <h4 class="modal-title">Derse Öğrenci Ekle</h4>
                                            </div>
                                            <div class="modal-body">
                                                <form runat="server">
                                                    <div class="form-group">
                                                        <label for="exampleInputLessonAcademician">Ders Adı</label>
                                                        <select id="MyLesson" class="form-control form-control-sm" runat="server">
                                                        </select>
                                                    </div>
                                                    <div class="form-group">
                                                        <label for="exampleInputLessonPlace">Dosya Seçiniz</label><br />
                                                        <asp:FileUpload ID="MyLessonFileUpload" runat="server" />
                                                    </div>


                                                </form>
                                            </div>
                                            <div class="modal-footer">
                                                <button id="Button1" type="button" class="btn btn-info" data-dismiss="modal" runat="server" onserverclick="btnInsertStudentLesson_ServerClick">Öğrenci Ekle</button>
                                                <button type="button" class="btn btn-danger" data-dismiss="modal">Kapat</button>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="modal fade" id="detailLesson" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                    <div class="modal-dialog" role="document">
                        <div class="modal-content">
                            <div class="modal-header">
                                <h5 class="modal-title" id="detailLessonModalLabel"></h5>
                                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                    <span aria-hidden="true">&times;</span>
                                </button>
                            </div>
                            <div class="modal-body">
                                <div class="container">

                                    <table class="table">
                                        <thead id="head">
                                            <tr>
                                                <th>Numarası</th>
                                                <th>Adı</th>
                                                <th>Soyadı</th>
                                                <th>Devam Bilgisi</th>
                                                <th>Devamsızlık Bilgisi</th>

                                            </tr>
                                        </thead>
                                        <tbody id="tBody">
                                        </tbody>
                                    </table>
                                </div>


                            </div>
                            <div class="modal-footer" id="btndetailDiv">
                                <button type="button" class="btn btn-secondary" data-dismiss="modal">Kapat</button>

                            </div>
                        </div>
                    </div>
                </div>
                <!-- ============================================================== -->
                <!-- End Bread crumb and right sidebar toggle -->
                <!-- ============================================================== -->
                <!-- ============================================================== -->
                <!-- Start Page Content -->
                <!-- ============================================================== -->
                <div class="row">
                    <!-- column -->
                    <div class="col-lg-12">
                        <div class="card">
                            <div class="card-block">
                                <h4 class="card-title">Bugünki Derslerim</h4>

                                <div class="table-responsive" id="todaymyLessons" runat="server">
                                </div>
                            </div>
                        </div>
                    </div>
                </div>



                <div class="row">
                    <!-- column -->
                    <div class="col-lg-12">
                        <div class="card">
                            <div class="card-block">
                                <h4 class="card-title">Derslerim</h4>

                                <div class="table-responsive" id="myLessons" runat="server">
                                </div>
                            </div>
                        </div>
                    </div>
                </div>


                <div>
                </div>
                <!-- ============================================================== -->
                <!-- End PAge Content -->
                <!-- ============================================================== -->
            </div>
            <!-- ============================================================== -->
            <!-- End Container fluid  -->
            <!-- ============================================================== -->
            <!-- ============================================================== -->
            <!-- footer -->
            <!-- ============================================================== -->
            <footer class="footer">
                © 2018 Ajandam Web
            </footer>
            <!-- ============================================================== -->
            <!-- End footer -->
            <!-- ============================================================== -->
        </div>
        <!-- ============================================================== -->
        <!-- End Page wrapper  -->
        <!-- ============================================================== -->
    </div>
    <!-- ============================================================== -->
    <!-- End Wrapper -->
    <!-- ============================================================== -->
    <!-- ============================================================== -->
    <!-- All Jquery -->
    <!-- ============================================================== -->
    <script src="../assets/plugins/jquery/jquery.min.js"></script>
    <!-- Bootstrap tether Core JavaScript -->
    <script src="../assets/plugins/bootstrap/js/tether.min.js"></script>
    <script src="../assets/plugins/bootstrap/js/bootstrap.min.js"></script>
    <!-- slimscrollbar scrollbar JavaScript -->
    <script src="js/jquery.slimscroll.js"></script>
    <!--Wave Effects -->
    <script src="js/waves.js"></script>
    <!--Menu sidebar -->
    <script src="js/sidebarmenu.js"></script>
    <!--stickey kit -->
    <script src="../assets/plugins/sticky-kit-master/dist/sticky-kit.min.js"></script>
    <!--Custom JavaScript -->
    <script src="js/custom.min.js"></script>
</body>
<script>
    function hideDiv() {
        $("#detailLesson").modal('hide');
    }
    function goPost(id) {

        var nullReference = document.getElementById("nullReference");
        var tbody = document.getElementById("tBody tr");
        var head = document.getElementById("head");
        
        $.ajax({
            type: "GET",
            url: 'https://spring-kou-service.herokuapp.com/api/lesson/rollcall?lessonId=' + id,
            success: function (data) {

                if (undefined !== data.ogrenci_devam_bilgileri) {
                    $("#detailLessonModalLabel").text(data.ogrenci_devam_bilgileri[0].devamsizlik.dersAdi);
                    tbody.remove();
                    nullReference.remove();
                    for (i = 0; i < data.ogrenci_devam_bilgileri.length; i++) {

                        $("#tBody").append('<tr><th>' + data.ogrenci_devam_bilgileri[i].ogrenci.number + '</th><th>' + data.ogrenci_devam_bilgileri[i].ogrenci.name + '</th><th>' + data.ogrenci_devam_bilgileri[i].ogrenci.surname + '</th><th>' + data.ogrenci_devam_bilgileri[i].devamsizlik.devamBilgisi + '</th><th>' + data.ogrenci_devam_bilgileri[i].devamsizlik.devamsizlikBilgisi + '</th></tr>')

                    }
                }
                else {
                    tbody.remove();
                    head.remove();
                    nullReference.remove();

                    $("#tBody").append('<div id="nullReference"><b>Bu derse kayıtlı öğrenci bulunmamaktadır. Derse öğrenci eklemek için <a href="#addLesson" onclick="hideDiv()" class="link" data-toggle="modal">tıklayınız.</a></b></div>');
                }
            }
        });


    }

</script>

</html>

