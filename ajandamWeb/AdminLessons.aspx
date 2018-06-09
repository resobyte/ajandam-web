<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminLessons.aspx.cs" Inherits="Lessons" %>

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
    <link href="../assets/plugins/bootstrap/css/bootstrap.min.css" rel="stylesheet">
    <!-- Custom CSS -->
    <link href="css/style.css" rel="stylesheet">
    <!-- You can change the theme colors from here -->
    <link href="css/colors/blue.css" id="theme" rel="stylesheet">
    <script src="https://unpkg.com/sweetalert2@7.8.2/dist/sweetalert2.all.js"></script>
    <script src="js/sweetalert.min.js"></script>

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
                    <a class="navbar-brand" href="AdminLessons.aspx">
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
                        <li><a class="waves-effect waves-dark" href="AdminLessons.aspx" aria-expanded="false"><i class="mdi  mdi-bookmark"></i><span class="hide-menu">Dersler</span></a>
                        <li><a class="waves-effect waves-dark" href="AddLessons.aspx" aria-expanded="false"><i class="mdi  mdi-bookmark-plus"></i><span class="hide-menu">Ders Ekle</span></a>
                        </li>
                        <li><a class="waves-effect waves-dark" href="AddAcademician.aspx" aria-expanded="false"><i class="mdi mdi-account-multiple-plus"></i><span class="hide-menu">Akademisyen Ekle</span></a>
                        </li>
                        <li><a class="waves-effect waves-dark" href="AdminProfile.aspx" aria-expanded="false"><i class="mdi mdi-account-check"></i><span class="hide-menu">Profilim</span></a>
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
                <a href="AdminProfile.aspx" class="link" data-toggle="tooltip" title="Settings"><i class="ti-settings"></i></a>
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
                        <h3 class="text-themecolor m-b-0 m-t-0">Dersler</h3>
                        <ol class="breadcrumb">
                            <li class="breadcrumb-item"><a href="javascript:void(0)">Home</a></li>
                            <li class="breadcrumb-item active">Dersler</li>
                        </ol>
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
                                <div class="table-responsive" id="myAdminLessons" runat="server">
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                    <div class="modal-dialog" role="document">
                        <div class="modal-content">
                            <div class="modal-header">
                                <h5 class="modal-title" id="exampleModalLabel">Ders Düzenle</h5>
                                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                    <span aria-hidden="true">&times;</span>
                                </button>
                            </div>
                            <div class="modal-body">
                                <form>
                                    <div class="form-group">
                                        <label for="recipient-name" class="col-form-label">Ders Adı</label>
                                        <input type="text" class="form-control" id="lesson-name" required>
                                    </div>
                                    <div class="form-group">
                                        <label for="lessonDay" class="col-form-label">Ders Günü</label>
                                        <select class="form-control form-control-sm" id="lessonDay" runat="server">
                                            <option>Pazartesi</option>
                                            <option>Salı</option>
                                            <option>Çarşamba</option>
                                            <option>Perşembe</option>
                                            <option>Cuma</option>
                                            <option>Cumartesi</option>
                                        </select>
                                    </div>
                                    <div class="form-group">
                                        <label for="lesson-clock" class="col-form-label">Ders Saati</label>
                                        <input type="text" class="form-control" id="lesson-clock" required>
                                    </div>
                                    <div class="form-group">
                                        <label for="lesson-location" class="col-form-label">Ders Yeri</label>
                                        <input type="text" class="form-control" id="lesson-location" required>
                                    </div>
                                    <div class="form-group">
                                        <label for="lesson-academician" class="col-form-label">Akademisyen</label>
                                        <select class="form-control form-control-sm" id="lessonAcademician" runat="server">
                                        </select>
                                    </div>
                                </form>
                            </div>
                            <div class="modal-footer" id="btnDiv">
                                <button type="button" class="btn btn-secondary" data-dismiss="modal">Kapat</button>

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
    var lessonId;

    function deleteLesson(id) {
        $.ajax({
            type: "POST",
            url: 'https://spring-kou-service.herokuapp.com/api/lesson/deleteLesson?lessonId=' + id + '',

            success: function (data) {

                if (data == false) {
                    swal("Error!", "Ters giden bir şeyler var!", "error");
                }
                else {
                    swal("Good job!", "Ders silme işlemi başarılı!", "success");
                    window.location.reload();
                }
                
            }
           
        });

    }
    function openModal(id) {

        $("#lessonAcademician").empty();
        var lessonAcademicianId;
        var lessonName;
        var lessonAcademicianId;
        var lessonAcademicianName;
        var lessonAcademicianSurname;
        var lessonClock;
        var lessonDay;
        var lessonLocation;
        var academicianId;
        var academicianName;
        var academicianSurname;

        $.ajax({
            type: "GET",
            url: 'https://spring-kou-service.herokuapp.com/api/lesson/getLesson?lessonId=' + id + '',

            success: function (data) {

                $("#btnUpdateLesson").remove();
                lessonId = data.ders.id;
                lessonName = data.ders.name;
                lessonAcademicianId = data.ders.academician.id;
                lessonAcademicianName = data.ders.academician.name;
                lessonAcademicianSurname = data.ders.academician.surname;
                lessonClock = data.ders.clock;
                lessonDay = data.ders.day;
                lessonLocation = data.ders.location;

                console.log(lessonClock);
                console.log(lessonDay);
                console.log(lessonLocation);


                document.getElementById("lesson-name").value = lessonName;
                document.getElementById("lessonDay").value = lessonDay;
                document.getElementById("lesson-clock").value = lessonClock;
                document.getElementById("lesson-location").value = lessonLocation;
                $("#btnDiv").append("<button type='button' class='btn btn-info' id='btnUpdateLesson' onclick='updateLesson(" + lessonId + ")'>Güncelle</button>");
                getAcademician(lessonAcademicianId);
            }

        });

    }
    function updateLesson(id) {

        if (lessonId == "" || $("#lesson-name").val() == "" || $("#lessonAcademician").val() == "" || $("#lesson-clock").val() == "" || $("#lesson-location").val() == "") {
            swal("Error!", "Doldurulması gereken alanlar var!", "error");
        }
        else {
            var updateLessonjson = "{\"id\":\"" + lessonId + "\",\"name\":\"" + $("#lesson-name").val() + "\",\"academician\":{\"id\":\"" + $("#lessonAcademician").val() + "\"},\"clock\":\"" + $("#lesson-clock").val() + "\",\"location\":\"" + $("#lesson-location").val() + "\",\"day\":\"" + $("#lessonDay").val() + "\"}";

            $.ajax({
                type: "POST",
                url: 'https://spring-kou-service.herokuapp.com/api/lesson/updateLesson',
                data: updateLessonjson,
                dataType: "json",
                contentType: "application/json; charset=utf-8",
                success: function (data) {
                    swal("Good job!", "Ders güncelleme işlemi başarılı!", "success");
                    window.location.reload();
                }

            });
        }
    }
    function getAcademician(lessonAcademicianId) {
        $.ajax({
            type: "GET",
            url: 'http://spring-kou-service.herokuapp.com/api/academician/getAcademicians',

            success: function (data) {

                for (i = 0; i < data.academician.length; i++) {

                    academicianId = data.academician[i].id;
                    academicianName = data.academician[i].name;
                    academicianSurname = data.academician[i].surname;
                  
                    if (academicianId == lessonAcademicianId) {
                        $("#lessonAcademician").append("<option value='" + academicianId + "'selected>" + academicianName + " " + academicianSurname + "</option>")
                    }
                    else {
                        $("#lessonAcademician").append("<option value='" + academicianId + "'>" + academicianName + " " + academicianSurname + "</option>")
                    }

                }

            }

        });
    }
</script>

</html>

