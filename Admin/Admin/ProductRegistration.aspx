<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductRegistration.aspx.cs" Inherits="Admin.ProductRegistration" %>

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
<div class="wrapper">

  <header class="main-header">
    <!-- Logo -->
    <a href="index.html" class="logo">
      <!-- mini logo for sidebar mini 50x50 pixels -->
      <span class="logo-mini"><b>Aayansh</b></span>
      <!-- logo for regular state and mobile devices -->
      <span class="logo-lg"><b>Aayansh</b></a><b><br />
      </b>
    <a href="index.html" class="logo">
      Germinate</a></span><a href="Index.aspx" class="logo">
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
                  <a href="Logout.aspx" class="btn btn-default btn-flat">Sign out</a>
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
          <p>Alexander Pierce</p>
          <a href="#"><i class="fa fa-circle text-success"></i> Online</a>
        </div>
      </div>
      <!-- search form -->
      <form 
          action="#" method="get" class="sidebar-form">
        <div class="input-group">
          <input type="text" name="q" class="form-control" placeholder="Search...">
              <span class="input-group-btn">
                <button type="submit" name="search" id="search-btn" class="btn btn-flat"><i class="fa fa-search"></i>
                </button>
              </span>
        </div>
      </form>
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
      <h1><center>
       Product Registration Form</center>
        <small></small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Home</a></li>
        <li><a href="ProductRegistration.aspx">Product Registration</a></li>
        <li class="active">Details</li>
      </ol>
    </section>

    <!-- Main content -->
    <section class="content">
      <div class="row">
        <div class="col-xs-12">
          
        

          <div class="box">
            <div class="box-header">
            <center>  <h3 class="box-title">Please Fill Registration Details</center></h3>
            </div>
            <!-- /.box-header -->
            <div class="box-body">
              <form id="Form1" method="post" enctype="multipart/form-data" runat="server"    class="form-horizontal"> 
          <div class="box-body">

              <%--<div class="form-group">
                <div class="col-md-4">
                  <label for="category">ProductRegistration Id</label>
                 </div>
                 <div class="col-md-8">
                     <asp:TextBox ID="txtproductid" runat="server" class="form-control" placeholder="Product Id " TabIndex="1" ></asp:TextBox>
                </div>
                </div>  --%>
              <div class="form-group">
                <div class="col-md-4">
                  <label for="city">City</label>
                 </div>
                 <div class="col-md-8">
           			<%--<input class="form-control" type="text" name="owner_name" placeholder="Enter Owner Name">--%>
                     <%--<asp:TextBox ID="TextBox6" runat="server" class="form-control" placeholder="Enter Password" TextMode="Password"></asp:TextBox>--%>
                     <asp:DropDownList ID="DropDownList6" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="DropDownList6_SelectedIndexChanged"></asp:DropDownList>
              </div></div>
                <div class="form-group">
                <div class="col-md-4">
                  <label for="category">Mall Name</label>
                 </div>
                 <div class="col-md-8">
                     <asp:DropDownList ID="DropDownList1" runat="server" class="form-control" TabIndex="1" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
                </div>
                </div>
              <div class="form-group">
                <div class="col-md-4">
                  <label for="category">Shop Name</label>
                 </div>
                 <div class="col-md-8">
                     <asp:DropDownList ID="DropDownList2" runat="server" class="form-control" TabIndex="2"></asp:DropDownList>
                </div>
                </div>  
               <div class="form-group">
                <div class="col-md-4">
                  <label for="category">Product Name</label>
                 </div>
                 <div class="col-md-8">
                     <asp:DropDownList ID="DropDownList3" runat="server" class="form-control" AutoPostBack="True" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged" TabIndex="3"></asp:DropDownList>
                     
                </div>
               </div>

              

                <div class="form-group">
                <div class="col-md-4">
                  <label for="category">Product Category Name</label>
                 </div>
                 <div class="col-md-8">
                     <asp:DropDownList ID="DropDownList5" runat="server" class="form-control" TabIndex="5" AutoPostBack="True" OnSelectedIndexChanged="DropDownList5_SelectedIndexChanged"></asp:DropDownList>
                </div>
                </div>   

               <div class="form-group">
                <div class="col-md-4">
                  <label for="category">Product Brand Name</label>
                 </div>
                 <div class="col-md-8">
                    <asp:DropDownList ID="DropDownList4" runat="server" class="form-control" TabIndex="3" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged"></asp:DropDownList>
                </div>
                </div>


               


               
               <div class="form-group">
                <div class="col-md-4">
              <label for="category">Product Type</label>
                 </div>
                 <div class="col-md-8">
           			<%--<input class="form-control" type="text" name="owner_name" placeholder="Enter Owner Name">--%>
                     <asp:TextBox ID="txtproducttype" runat="server" class="form-control" placeholder="Ex.Electronics-Sony-Mobile-Modelno/type" TabIndex="6" ></asp:TextBox>
                </div>
                </div>  
             <div class="form-group">
                <div class="col-md-4">
               <label for="category">Product Price</label>
                 </div>
                 <div class="col-md-8">
           			<%--<input class="form-control" type="text" name="owner_name" placeholder="Enter Owner Name">--%>
                     <asp:TextBox ID="txtproductprice" runat="server" class="form-control" placeholder="Enter Product Price" TabIndex="7" ></asp:TextBox>
                </div>
                </div>  

                <div class="form-group">
                <div class="col-md-4">
                  <label for="category">Product Offer Price</label>
                 </div>
                 <div class="col-md-8">
           			<%--<input class="form-control" type="text" name="owner_name" placeholder="Enter Owner Name">--%>
                     <%--<asp:TextBox ID="TextBox6" runat="server" class="form-control" placeholder="Enter Password" TextMode="Password"></asp:TextBox>--%>
                      <asp:TextBox ID="txtproductofferprice" runat="server" class="form-control" placeholder="Enter Offer Price"  TabIndex="8" ></asp:TextBox>
                </div>
                </div>   

                     
                </div>
                </div>
                <div class="form-group">
                <div class="col-md-4">
                  <label for="category">Product Description</label>
                 </div>
                 <div class="col-md-8">
           			<%--<input class="form-control" type="text" name="owner_name" placeholder="Enter Owner Name">--%>
                     <%--<asp:TextBox ID="TextBox6" runat="server" class="form-control" placeholder="Enter Password" TextMode="Password"></asp:TextBox>--%>
                     <asp:TextBox ID="txtDescription" runat="server" CssClass="form-control" placeholder="Enter Description"></asp:TextBox>
                </div>
                </div>   



        
                <div class="form-group">
                <div class="col-md-4">
                  <label for="product_image">Product Image</label>
                  </div>
                  <div class="col-md-8">
                  <%--<input type="file" class="form-control" id="product_image" name="product_image" placeholder="Upload Image">--%>
<%--                <asp:DropDownList ID="DropDownList3" runat="server" CssClass="form-control" TabIndex="10"></asp:DropDownList>--%>
                      <asp:FileUpload ID="FileUpload1" runat="server" class="form-control"  placeholder="Select Image"  /><asp:Image ID="Image1" runat="server" Height="95px" Width="87px" />
                       
                       </div>
                </div>

              
              
              <!-- /.box-body -->

              <div class="box-footer">
                  <center>
                      <asp:Button ID="Button3" runat="server" Text="Submit" Width="75px" Height="40px"  CssClass="btn-primary" TabIndex="13" OnClick="Button3_Click"/>
                  <asp:Button ID="Button2" runat="server" Text="Reset" Width="75px" Height="40px"  CssClass="btn-primary" TabIndex="14"/>
               </center>
               <%-- <button type="submit" name="add" class="btn btn-primary">Add</button>
               
                <button type="submit" name="cancel" class="btn btn-primary">Cancel</button>--%>



              </div>
         </form>
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
  <!-- /.content-wrapper -->
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
</body>
</html>

