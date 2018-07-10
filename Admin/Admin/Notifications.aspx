<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Notifications.aspx.cs" Inherits="Admin.Notifications" %>

<!DOCTYPE html>
<html>
<head>
  <meta charset="utf-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <title>Admin | Dashboard</title>
  <!-- Tell the browser to be responsive to screen width -->
  <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
  <!-- Bootstrap 3.3.6 -->
  <link rel="stylesheet" href="bootstrap/css/bootstrap.min.css">
  <!-- Font Awesome -->
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.5.0/css/font-awesome.min.css">
  <!-- Ionicons -->
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/ionicons/2.0.1/css/ionicons.min.css">
  <!-- Theme style -->
  <link rel="stylesheet" href="css/AdminLTE.min.css">
  <!-- AdminLTE Skins. Choose a skin from the css/skins
       folder instead of downloading all of them to reduce the load. -->
  <link rel="stylesheet" href="css/_all-skins.min.css">
  <!-- iCheck -->
  <link rel="stylesheet" href="plugins/iCheck/flat/blue.css">
  <!-- Morris chart -->
  <link rel="stylesheet" href="plugins/morris/morris.css">
  <!-- jvectormap -->
  <link rel="stylesheet" href="plugins/jvectormap/jquery-jvectormap-1.2.2.css">
  <!-- Date Picker -->
  <link rel="stylesheet" href="plugins/datepicker/datepicker3.css">
  <!-- Daterange picker -->
  <link rel="stylesheet" href="plugins/daterangepicker/daterangepicker.css">
  <!-- bootstrap wysihtml5 - text editor -->
  <link rel="stylesheet" href="plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css">

  <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
  <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
  <!--[if lt IE 9]>
  <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
  <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
  <![endif]-->
</head>
<body class="hold-transition skin-blue sidebar-mini">
    <form id="form1" runat="server">
<div class="wrapper">

  <header class="main-header">
    <!-- Logo -->
    <a href="index.html" class="logo">
      <!-- mini logo for sidebar mini 50x50 pixels -->
      <span class="logo-mini"><b>Aayansh</b></span>
      <!-- logo for regular state and mobile devices -->
      <span class="logo-lg"><b>Aayansh</b>Germinate</span>
    </a>
    <!-- Header Navbar: style can be found in header.less -->
    <nav class="navbar navbar-static-top">
      <!-- Sidebar toggle button-->
      <a href="#" class="sidebar-toggle" data-toggle="offcanvas" role="button">
        <span class="sr-only">Toggle navigation</span>
      </a>

      <div class="navbar-custom-menu">
        <ul class="nav navbar-nav">
         
          <!-- User Account: style can be found in dropdown.less -->
          <li class="dropdown user user-menu">
            <a href="#" class="dropdown-toggle" data-toggle="dropdown">
              <img src="img/user.jpg" class="user-image" alt="User Image">
              <span class="hidden-xs">Admin</span>
            </a>
            <ul class="dropdown-menu">
              <!-- User image -->
              <li class="user-header">
                <img src="img/user.jpg" class="img-circle" alt="User Image">

                <p>
                  Alexander Pierce - Web Developer
                  <small>Member since Nov. 2012</small>
                </p>
              </li>
              
              <!-- Menu Footer-->
              <li class="user-footer">
                <div class="pull-left">
                  <a href="#" class="btn btn-default btn-flat">Profile</a>
                </div>
                <div class="pull-right">
                  <a href="#" class="btn btn-default btn-flat">Sign out</a>
                </div>
              </li>
            </ul>
          </li>
         
        </ul>
      </div>
    </nav>
  </header>
  <!-- Left side column. contains the logo and sidebar -->
  <aside class="main-sidebar">
    <!-- sidebar: style can be found in sidebar.less -->
    <section class="sidebar">
      <!-- Sidebar user panel -->
      <div class="user-panel">
        <div class="pull-left image">
          <img src="img/user.jpg" class="img-circle" alt="User Image">
        </div>
        <div class="pull-left info">
          <p>Admin</p>
          <a href="#"><i class="fa fa-circle text-success"></i> Online</a>
        </div>
      </div>
      <!-- search form -->
        <div class="input-group">
          <input type="text" name="q" class="form-control" placeholder="Search...">
              <span class="input-group-btn">
                <button type="submit" name="search" id="search-btn" class="btn btn-flat"><i class="fa fa-search"></i>
                </button>
              </span>
        </div>
      <!-- /.search form -->
      <!-- sidebar menu: : style can be found in sidebar.less -->
      <ul class="sidebar-menu">
        <li class="header">MAIN NAVIGATION</li>
        <li>
          <a href="Home.aspx">
            <i class="fa fa-dashboard"></i> <span>Dashboard</span>
            <span class="pull-right-container">
              <i class="fa fa-angle-left pull-right"></i>
            </span>
          </a>
          
        </li>
        
        <li class="active treeview">
          <a href="#">
            <i class="fa fa-files-o"></i>
            <span>Mall</span>
            <span class="pull-right-container">
              <i class="fa fa-angle-left pull-right"></i>
            </span>
          </a>
          <ul class="treeview-menu">
           <li><a href="Mall_Detail1.aspx"><i class="fa fa-circle-o"></i> Mall Details</a></li>
            <li class="active"><a href="Mall_Registration.aspx"><i class="fa fa-circle-o"></i> Mall Registration</a></li>
             <li class="active"><a href="Shop_Registration.aspx"><i class="fa fa-circle-o"></i> Shop Registration</a></li>
              <li class="active"><a href="ProductRegistration.aspx"><i class="fa fa-circle-o"></i> Product Registration</a></li>
              <li class="active"><a href="Products.aspx"><i class="fa fa-circle-o"></i> Product Entry</a></li>
              <li class="active"><a href="FoodReg.aspx"><i class="fa fa-circle-o"></i> Food shop Registrations</a></li>
              <li class="active"><a href="Food_Items.aspx"><i class="fa fa-circle-o"></i> Food Entry</a></li>
               <li class="active"><a href="Food_Reg1.aspx"><i class="fa fa-circle-o"></i> Food Item Entry</a></li>

          </ul>
        </li>
       <li><a href="Logout.aspx"><i class="fa fa-files-o"></i><span>Logout</span></a></li>
        
        
      </ul>
    </section>
    <!-- /.sidebar -->
  </aside>

  <!-- Content Wrapper. Contains page content -->
  <div class="content-wrapper">
    <!-- Content Header (Page header) -->
    <section class="content-header">
      <h1>Add Notifications
        <small></small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="Home.aspx"><i class="fa fa-dashboard"></i> Home</a></li>
        <li><a href="Mall_Registration.aspx">Mall Registration</a></li>
        <li class="active">Details</li>
      </ol>
    </section>

    <!-- Main content -->
    <section class="content">
      <div class="row">
        <div class="col-xs-12">
          
        

          <div class="box">
            <div class="box-header">
            <%--  <h3 class="box-title">Data Table With Full Features</h3>--%>
              <span class="pull-right"> <a href="Notifications.aspx" class="btn bg-olive">Add Notifications</a></span>
                <%--<asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>--%>

                <div class="col-md-2">
                  <label for="category">Title</label>
                 </div>

                <div class="col-md-10">
           			<%--<input class="form-control" type="text" name="owner_name" placeholder="Enter Owner Name">--%>
                     <asp:TextBox ID="txtname" class="form-control"  runat="server" CssClass="form-control"></asp:TextBox>
             
                <br />
                <br />
                <br />
                
                 <div class="col-md-2">
                  <label for="category">Descriptions</label>
                 </div>
                <br />
                    <br />
                    <br />

                <div class="col-md-10">
           			<%--<input class="form-control" type="text" name="owner_name" placeholder="Enter Owner Name">--%>
                     <asp:TextBox ID="txtdes" TextMode="MultiLine" class="form-control"  runat="server"></asp:TextBox>
                </div>
                     <br />
                    <br />
                 <div class="col-md-4">
                  <label for="category">Image</label>
                 </div>

                <div class="col-md-8">
           			<%--<input class="form-control" type="text" name="owner_name" placeholder="Enter Owner Name">--%>
                    <asp:FileUpload ID="FileUpload1" runat="server" Height="35px" Width="342px" />
                    <asp:Image ID="Image1" runat="server" Height="60px" Width="99px" />
                </div>
                     <br />
                    <br />
                     <br />
                    <br />

                 <div class="col-md-2">
                  <label for="category">Price</label>
                 </div>

                <div class="col-md-10">
           			<%--<input class="form-control" type="text" name="owner_name" placeholder="Enter Owner Name">--%>
                     <asp:TextBox ID="txtprice" class="form-control"  runat="server"></asp:TextBox>
                </div>
                     <br />
                    <br />
                     <br />
                    <br />
                    
                 <div class="col-md-2">
                  <label for="category">Price_Offers</label>
                 </div>

                <div class="col-md-10">
           			<%--<input class="form-control" type="text" name="owner_name" placeholder="Enter Owner Name">--%>
                     <asp:TextBox ID="txtpriceoffer" class="form-control"  runat="server"></asp:TextBox>
                </div>

                <%--<asp:Button ID="Button1" runat="server" Text="Add  Notification" />--%>
                <br />
                <br />
             
            </div>
                </div>
              <asp:Button ID="Button1" runat="server" Text="Add Notification" CssClass="btn btn-primary" OnClick="Button1_Click"></asp:Button>
            <!-- /.box-header -->
            <div class="box-body">
              
            </div>
            <!-- /.box-body -->
          </div>
          <!-- /.box -->
        </div>
        <!-- /.col -->
      </div>
      <!-- /.row -->
    </section>
    <!-- /.content -->
  </div>
<footer class="main-footer">
    <div class="pull-right hidden-xs">
     
    </div>
   Copyright &copy;  <strong> <a href="#">Aayansh Germinate</a></strong>  All rights
    reserved.
  </footer>
 
</div>
<!-- ./wrapper -->

<!-- jQuery 2.2.3 -->
<script src="js/jquery-2.2.3.min.js"></script>
<!-- jQuery UI 1.11.4 -->
<script src="https://code.jquery.com/ui/1.11.4/jquery-ui.min.js"></script>
<!-- Resolve conflict in jQuery UI tooltip with Bootstrap tooltip -->
<script>
    $.widget.bridge('uibutton', $.ui.button);
</script>
<!-- Bootstrap 3.3.6 -->
<script src="bootstrap/js/bootstrap.min.js"></script>
<!-- Morris.js charts -->


<!-- Sparkline -->
<script src="plugins/sparkline/jquery.sparkline.min.js"></script>
<!-- jvectormap -->
<script src="plugins/jvectormap/jquery-jvectormap-1.2.2.min.js"></script>
<script src="plugins/jvectormap/jquery-jvectormap-world-mill-en.js"></script>
<!-- jQuery Knob Chart -->
<script src="plugins/knob/jquery.knob.js"></script>
<!-- daterangepicker -->
<script src="https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.11.2/moment.min.js"></script>
<script src="plugins/daterangepicker/daterangepicker.js"></script>
<!-- datepicker -->
<script src="plugins/datepicker/bootstrap-datepicker.js"></script>
<!-- Bootstrap WYSIHTML5 -->
<script src="plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js"></script>
<!-- Slimscroll -->
<script src="plugins/slimScroll/jquery.slimscroll.min.js"></script>
<!-- FastClick -->

<script src="js/jquery.dataTables.min.js"></script>
<script src="js/dataTables.bootstrap.min.js"></script>
<script src="plugins/fastclick/fastclick.js"></script>
<!-- AdminLTE App -->
<script src="js/app.min.js"></script>
<!-- AdminLTE dashboard demo (This is only for demo purposes) -->

<!-- AdminLTE for demo purposes -->


<!-- page script -->
<script>
    $(function () {
        $("#example1").DataTable();
        $('#example2').DataTable({
            "paging": true,
            "lengthChange": false,
            "searching": false,
            "ordering": true,
            "info": true,
            "autoWidth": false
        });
    });
</script>
    </form>
</body>
</html>
