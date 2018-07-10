
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Your_Talent.aspx.cs" Inherits="Your_Talent" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta http-equiv="x-ua-compatible" content="ie=edge">
    <!--[if IE]>
<meta http-equiv="X-UA-Compatible" content="IE=edge">
<![endif]-->
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="">
    <meta name="author" content="">

    <!-- Favicons Icon -->
    <link rel="icon" href="img/favicon.ico" type="img/x-icon" />
    <link rel="shortcut icon" href="img/favicon.ico" type="img/x-icon" />
    <title>Crocus premium HTML5 &amp; CSS3 template</title>

    <!-- Mobile Specific -->
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">

    <!-- CSS Style -->
    <link rel="stylesheet" type="text/css" href="style-css/bootstrap.min.css">
    <link rel="stylesheet" type="text/css" href="style-css/font-awesome.css" media="all">
    <link rel="stylesheet" type="text/css" href="style-css/simple-line-icons.css" media="all">
    <link rel="stylesheet" type="text/css" href="style-css/owl.carousel.css">
    <link rel="stylesheet" type="text/css" href="style-css/owl.theme.css">
    <link rel="stylesheet" type="text/css" href="style-css/jquery.bxslider.css">
    <link rel="stylesheet" type="text/css" href="style-css/jquery.mobile-menu.css">
    <link rel="stylesheet" type="text/css" href="style-css/revslider.css">
    <link rel="stylesheet" type="text/css" href="style-css/style.css" media="all">
    <link rel="stylesheet" type="text/css" href="engine1/style.css" />
    <link href="style-css/style.css" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="style-css/header.css" />

  
     <style>
        .imgrotate {

    width: 300px;
    height: 100px;

    /*border: 1px solid black;*/
    transition-duration:0.5s;
}

.imgrotate:hover {

    -webkit-transform: rotateX(150deg); /* Safari */
    transform: rotateY(150deg); /* Standard syntax */
}

table, tr, td {
            padding-left:12px;
        }

.img1 {
    margin: 5px;
    border: 1px solid #ccc;
    float: left;
    width: 180px;
  
}

.img1:hover {
    border: 1px solid #777;
transform:scale(1.1,1.1);
transition-duration:1s;

-webkit-transform:scale(1.1,1.1);
-webkit-transition-duration:1s;

-moz-transform:scale(1.1,1.1);
-moz-transition-duration:1s;
}

.img1 img {
    width: 100%;
    height: auto;
}

desc {
    padding: 15px;
    text-align: center;
}



    </style>
    <script type="text/javascript" src="engine1/jquery.js"></script>
    <!-- Google Fonts -->
    <link href='http://fonts.googleapis.com/css?family=Open+Sans:700,600,800,400|Raleway:400,300,600,500,700,800' rel='stylesheet' type='text/css'>
</head>

<body class="cms-index-index cms-home-page">
     <form id="Form1" runat="server">
    <div id="page">
        <!-- Header -->
        <div class="header">
            <div class="header-container">
                <div class="header-top">
                    <div class="container">
                        <div class="row">
                            <!-- Header Language -->
                            <div class="col-xs-12 col-sm-6">

                                <div class="welcome-msg" style="font-weight: bold;">Welcome Mall-Info </div>
                            </div>
                            <div class="col-xs-6 hidden-xs">
                                <!-- Header Top Links -->
                                <div class="toplinks">
                                    <div class="links">
                                    </div>
                                </div>
                                <!-- End Header Top Links -->
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="container">
                <div class="row" style="margin-top: 10px;">
                    <div class="col-sm-3">
                        <div class="w3l_logo">
                            <h1><a title="Magento Commerce" href="#">
                                <img alt="Magento Commerce" src="img/logo1.png">
                            </a></h1>
                        </div>
                    </div>

                    <div class="col-sm-2 box">
                        <div class="top-cart-contain pull-right">
                            <div class="tag_shop">
                                <div class="talent"><a href="Your Talent.aspx"><span class="head">Your Talent</span> </a></div>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-2 box">
                        <div class="top-cart-contain pull-right">
                            <div class="tag_shop">
                                <div class="child"><a href="Kids_Talent.aspx"><span class="head">Kid's Talent</span> </a></div>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-2 box">
                        <div class="top-cart-contain pull-right">
                            <div class="tag_shop">
                                <div class="food"><a href="Foodpage.aspx"><span class="head">Book Food</span> </a></div>
                            </div>
                        </div>
                    </div>
                  <%--  <div class="col-sm-2 box">
                        <div class="top-cart-contain pull-right">
                            <div class="tag_shop">
                                <div class="park"><a href="#"><span class="head">Book Parking</span> </a></div>
                                <div>
                                </div>
                            </div>
                        </div>
                    </div>--%>
                    
                </div>





                <div class="clearfix"></div>
            </div>
        </div>
        <nav>
            <div class="navigation">
                <div class="container">
                    <nav class="navbar navbar-default">
                        <!-- Brand and toggle get grouped for better mobile display -->
                        <div class="navbar-header nav_2">
                            <button type="button" class="navbar-toggle collapsed navbar-toggle1" data-toggle="collapse" data-target="#bs-megadropdown-tabs">
                                <span class="sr-only">Toggle navigation</span>
                                <span class="icon-bar"></span>
                                <span class="icon-bar"></span>
                                <span class="icon-bar"></span>
                            </button>
                        </div>
                        <div class="collapse navbar-collapse" id="bs-megadropdown-tabs">
                            <ul class="nav navbar-nav">
                                <li class="active"><a href="Home.aspx" class="act">Home</a></li>
                                <!-- Mega Menu -->
                                <li class="dropdown">
                                    <a href="#" class="dropdown-toggle" data-toggle="dropdown">Entertainment <b class="caret"></b></a>
                                    <ul class="dropdown-menu multi-column-dropdown">
                                        <li><a href="#">Movies</a></li>
                                        <li><a href="#">Events</a></li>
                                        <li><a href="#">Games</a></li>
                                        <li><a href="#">Live Performance</a></li>
                                        <li><a href="#">Concert</a></li>

                                    </ul>
                                </li>
                                <li><a href="#">Offers</a></li>
                                <li class="dropdown">
                                    <a href="#" class="dropdown-toggle" data-toggle="dropdown">Services <b class="caret"></b></a>
                                    <ul class="dropdown-menu multi-column-dropdown">
                                        <li><a href="#">Free WIFI</a></li>
                                        <li><a href="#">Show Your Talent</a></li>
                                        <li><a href="#">Kids Talent</a></li>
                                        <li><a href="#">Book Parking</a></li>
                                        <li><a href="#">Book Your Food</a></li>
                                        <li><a href="#">Book Table In Hotel</a></li>

                                    </ul>
                                </li>
                                
						
						<li><a href="#">Malls</a></li>
                                <li><a href="#">Contact Us</a></li>
                            </ul>
                        </div>
                    </nav>
                </div>
            </div>
        </nav>
        <!-- //header -->
        <!-- Newsletter and social widget -->
        <div class="subscribe-area hidden-xs">
            <div class="container">
                <div class="subscribe-container">  
                    <div class="row">
                        <div class="search-box" style="height:60px;" >
                                
                                  <p style=" margin-left:7px; margin-top:10px;"><asp:TextBox  runat="server" placeholder="Search brands,products,events,movies by malls" MaxLength="100" name="search" CssClass="form-control"  Width="420px"  ID="txtsearch"></asp:TextBox></p>
                                    <%--    <button type="button" class="search-btn-bg">Search<span class="fa-search"></span>&nbsp;</button>--%>
                                   
                                    <p style="margin-left:450px; margin-top:-40px" ><i  class="fa fa-search"><asp:Button ID="Button2" runat="server"  Text="Search"  CssClass=" btn btn-default " BackColor="Transparent" BorderWidth="0" Height="25px" /></i></p>
                                                                                                    
                            </div>
                          </div>  

                        </div>
                        </div>
                        <div class="col-md-6">
                            <div class="subscribe-text-link ">
                                <div class="subscribe-link">
                                    <ul class="social-link">
                                        <li><a href="#"><i class="fa fa-facebook"></i></a></li>
                                        <li><a href="#"><i class="fa fa-rss"></i></a></li>
                                        <li><a href="#"><i class="fa fa-twitter"></i></a></li>
                                        <li><a href="#"><i class="fa fa-pinterest"></i></a></li>
                                        <li><a href="#"><i class="fa fa-google-plus"></i></a></li>
                                    </ul>

                                    <p class="discount-text"><strong>WINTER SALE!</strong> 20% off on selected items</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Newsletter and social widget end-->

        <!-- Slider -->
        <div id="thmsoft-slideshow" class="thmsoft-slideshow">
            <div class="container">
                <div class="row">
                    <div class=" col-lg-12 col-md-3 col-sm-5 col-xs-12 col-mid">
                        <!--<div class="col-inner ">
            <div class="img-block"> <a href="#" class="ves-btnlink img-animation" title="Image"> <img src="images/mid-banner1.jpg"  alt="Image"></a> </div>
            <div class="img-block1"> <a href="#" title="Image"> <img src="images/mid-banner2.jpg"  alt="Image"></a> </div>
          </div>-->
                        <div class="our-features-box">
                            <div class="row">
                                <div class="col-lg-3 space">
                                    <div class="feature-box first">
                                        <span class="fa fa-building"></span>
                                        <div class="content">
                                            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" ></asp:DropDownList>
                                           <%-- <select name="mall" class="form-control">
                                                <option>Malls In Pune</option>
                                                <option value="phoenix mall">Phoenix Marketcity</option>
                                                <option value="seasons mall">Seasons Mall</option>
                                                <option value="sgs mall">SGS Mall</option>
                                                <option value="lifestyle mall">Lifestyle Mall</option>
                                                <option value="abhiruchi mall">Abhiruchi Mall</option>
                                            </select>--%>


                                        </div>
                                    </div>
                                </div>
                                <div class="col-lg-3 space">
                                    <div class="feature-box">
                                        <span class="fa fa-building"></span>
                                        <div class="content">
                                            <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" placeholder="select Mall Name">
                                                <asp:ListItem>Select Mall Name</asp:ListItem>
                                            </asp:DropDownList>
                                           <%-- <select name="mall" class="form-control">
                                                <option>Malls In Ahmedabad</option>
                                                <option value="phoenix mall">Phoenix Marketcity</option>
                                                <option value="seasons mall">Seasons Mall</option>
                                                <option value="sgs mall">SGS Mall</option>
                                                <option value="lifestyle mall">Lifestyle Mall</option>
                                                <option value="abhiruchi mall">Abhiruchi Mall</option>
                                            </select>--%>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-lg-3 space">
                                    <div class="feature-box">
                                        <span class="fa fa-building"></span>
                                        <div class="content">
                                            <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" placeholder="Select Shop Name" >
                                                <asp:ListItem>Select Shop Name</asp:ListItem>
                                            </asp:DropDownList>
                                            <%--<select name="mall" class="form-control">
                                                <option>Malls In Mumbai</option>
                                                <option value="phoenix mall">Phoenix Marketcity</option>
                                                <option value="seasons mall">Seasons Mall</option>
                                                <option value="sgs mall">SGS Mall</option>
                                                <option value="lifestyle mall">Lifestyle Mall</option>
                                                <option value="abhiruchi mall">Abhiruchi Mall</option>
                                            </select>--%>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-lg-3 space">
                                    <div class="feature-box last">
                                        <span class="fa fa-building"></span>
                                        <div class="content">
                                            <asp:DropDownList ID="DropDownList4" runat="server"></asp:DropDownList>
                                            <%--<select name="mall" class="form-control">
                                                <option>Malls In Baroda</option>
                                                <option value="phoenix mall">Phoenix Marketcity</option>
                                                <option value="seasons mall">Seasons Mall</option>
                                                <option value="sgs mall">SGS Mall</option>
                                                <option value="lifestyle mall">Lifestyle Mall</option>
                                                <option value="abhiruchi mall">Abhiruchi Mall</option>
                                            </select>--%>
                                        </div>
                                    </div>
                                </div>

                            </div>

                        </div>

                    </div>
                </div>
                <br>
                <br>
            </div>
        </div>

    <script type="text/javascript" src="engine1/wowslider.js"></script>
    <script type="text/javascript" src="engine1/script.js"></script>

    <!-- end Slider -->

    <div class="content-page">
        <div class="container">
            <div class="row">

                <!-- featured category fashion -->
                <div class="col-md-9" style="margin-top: 20px;">

            
                    <!-- bestsell Slider -->
                    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>  
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <div class="category-product">
                       

                        <div class="navbar nav-menu">
                            <div class="navbar-collapse">
                                <ul class="nav navbar-nav">
                                    <li>
                                        <div class="new_title">
                                            <h2>Which Talent's</h2>
                                        </div>
                                    </li>
                                    <li class="active">
                                        <asp:LinkButton ID="LinkButton3" runat="server" >ALL</asp:LinkButton>
                                    </li>
                                    <li>
                                        <asp:LinkButton ID="LinkButton1" runat="server"  OnClick="LinkButton1_Click" >Images</asp:LinkButton>
                                    </li>
                                     <li>
                                        <asp:LinkButton ID="LinkButton2" runat="server"  OnClick="LinkButton2_Click">Video</asp:LinkButton>
                                    </li>
                                    <li>
                                         <asp:LinkButton ID="LinkButton4" runat="server" PostBackUrl="~/Yourimage.aspx">Upload</asp:LinkButton>
                                        <%--<div class="child"><a href="Kidimage.aspx"><span class="head">Kid's Talent</span> </a></div>--%>
                                    </li>
                                </ul>
                            </div>
                            <!-- /.navbar-collapse -->

                        </div>        
             
              <asp:DataList ID="DataList1" runat="server" RepeatDirection="Horizontal" RepeatColumns="4" >
              <ItemTemplate>
                <table border="0">
                   <%-- <tr ><td class="abc">offer_price Rs.<asp:Label ID="Label1" runat="server"  Text='<%#Eval("PR_OfferPrice") %>'></asp:Label></td></tr>--%>
                   <tr> <td>
                        <asp:Image  ID="Image1"  runat="server" CssClass="img1" ImageUrl='<%#"data:Image/png;base64," + Convert.ToBase64String((byte[])Eval("Data")) %>' Height="150" Width="150"/></td>
                       </tr>
                </table>


            </ItemTemplate>

        </asp:DataList>
        </div>

        <div>
              <
        </div>
        </ContentTemplate>
        </asp:UpdatePanel>
                   
                    <!--END bestsell Slider -->









                    <!-- Start Featured Slider -->
                    <div class="featured-pro">
                        <div class="slider-items-products">
                            
                        </div>
                    </div>

                    <!-- End Featured Slider -->

                    <!-- Latest Blog -->
                    <div class="blog">
                        <div class="row">
                            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                                <div class="blog-outer-container">
                                    <div class="blog-inner">
                                        <div class="row">
                                            <div class="col-lg-4 col-md-4 col-sm-4 blog-preview_item">
                                                <div class="blog-post">
                                                    <div class="entry-thumb image-hover2"><a href="blog_single_post.html">
                                                        <img alt="Blog" src="img/1419087534.jpg" height="190px">
                                                    </a></div>
                                                    <div class="blog-preview_info">
                                                        <ul class="post-meta">
                                                            <li><i class="fa fa-comments"></i><a href="#">37 comments</a> </li>
                                                            <li><i class="fa fa-calendar"></i>2016-01-15</li>
                                                        </ul>
                                                        <h4 class="blog-preview_title"><a href="blog_single_post.html">Gulmohar Park, Ahmedabad </a></h4>
                                                        <div class="blog-preview_desc">Fusce ac pharetra urna. Duis non lacus sit amet lacus interdum facilisis sed non est. Ut mi metus</div>
                                                        <a class="blog-preview_btn" href="blog_single_post.html">READ MORE</a>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-lg-4 col-md-4 col-sm-4 blog-preview_item">
                                                <div class="blog-post">
                                                    <div class="entry-thumb image-hover2"><a href="blog_single_post.html">
                                                        <img alt="Blog" src="img/phoenix-marketcity-mumbai.jpg" height="190px">
                                                    </a></div>
                                                    <div class="blog-preview_info">
                                                        <ul class="post-meta">
                                                            <li><i class="fa fa-comments"></i><a href="#">9 comments</a> </li>
                                                            <li><i class="fa fa-calendar"></i>2016-01-05</li>
                                                        </ul>
                                                        <h4 class="blog-preview_title"><a href="blog_single_post.html">Phoenix Marketcity, Mumbai</a></h4>
                                                        <div class="blog-preview_desc">Fusce ac pharetra urna. Duis non lacus sit amet lacus interdum facilisis sed non est. Ut mi metus</div>
                                                        <a class="blog-preview_btn" href="blog_single_post.html">READ MORE</a>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-lg-4 col-md-4 col-sm-4 blog-preview_item">
                                                <div class="blog-post">
                                                    <div class="entry-thumb image-hover2"><a href="blog_single_post.html">
                                                        <img alt="Blog" src="img/amanora.jpg" height="190px">
                                                    </a></div>
                                                    <div class="blog-preview_info">
                                                        <ul class="post-meta">
                                                            <li><i class="fa fa-comments"></i><a href="#">24 comments</a> </li>
                                                            <li><i class="fa fa-calendar"></i>2016-01-05</li>
                                                        </ul>
                                                        <h4 class="blog-preview_title"><a href="blog_single_post.html">Amanora Mall, Pune</a></h4>
                                                        <div class="blog-preview_desc">Fusce ac pharetra urna. Duis non lacus sit amet lacus interdum facilisis sed non est. Ut mi metus</div>
                                                        <a class="blog-preview_btn" href="blog_single_post.html">READ MORE</a>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                    <!-- End Latest Blog -->

                </div>
                <div class="col-md-3">
                    <div class="hot-deal">
                        <div class="title">Hot Deal</div>
                        <ul class="products-grid">
                            <li class="right-space two-height item">
                                <div class="item-inner">
                                    <div class="item-img">
                                        <div class="item-img-info">
                                            <a href="#" title="ThinkPad X1 Ultrabook" class="product-image">
                                                <img src="img/product1.jpg" alt="ThinkPad X1 Ultrabook">
                                            </a>
                                            <div class="new-label new-top-right">New</div>
                                            <div class="box-hover">
                                                <ul class="add-to-links">
                                                    <li><a class="link-quickview" href="quick_view.html"></a></li>
                                                    <li><a class="link-wishlist" href="#"></a></li>
                                                    <li><a class="link-compare" href="#"></a></li>
                                                </ul>
                                            </div>
                                            <div class="box-timer">
                                                <div class="countbox_1 timer-grid">
                                                    <div class="day box-time-date"><span class="time-num time-day">961</span>Days</div>
                                                    <div class="hour box-time-date"><span class="time-num">20</span>Hrs</div>
                                                    <div class="min box-time-date"><span class="time-num">53</span>Mins</div>
                                                    <div class="sec box-time-date"><span class="time-num">18</span>Secs</div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="item-info">
                                        <div class="info-inner">
                                            <div class="item-title"><a href="product_detail.html" title="Retis lapen casen">ThinkPad X1 Ultrabook </a></div>
                                            <div class="item-content">
                                                <div class="rating">
                                                    <div class="ratings">
                                                        <div class="rating-box">
                                                            <div class="rating" style="width: 80%"></div>
                                                        </div>
                                                        <p class="rating-links"><a href="#">1 Review(s)</a> <span class="separator">|</span> <a href="#">Add Review</a> </p>
                                                    </div>
                                                </div>
                                                <div class="item-price">
                                                    <div class="price-box"><span class="regular-price"><span class="price">$125.00</span> </span></div>
                                                </div>
                                                <div class="action">
                                                    <button data-original-title="View More" title="" type="button" class="button btn-cart"><span>View More</span> </button>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </li>
                        </ul>
                    </div>

                    <!-- Testimonials -->
                    <div class="testimonials std">
                        <div class="slider-items-products">
                            <div id="testimonials" class="product-flexslider hidden-buttons">
                                <div class="slider-items slider-width-col1 owl-carousel owl-theme">

                                    <!-- Item -->
                                    <div class="item">
                                        <div class="inner-block">
                                            <div class="auther-img">
                                                <img alt="" src="img/photo.jpg"></div>
                                            <div class="testimonials-text">"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam fringilla augue..." </div>
                                            <div class="auther-name">John Doe <span>Founder - Xyz company</span> </div>
                                        </div>
                                        <div class="inner-block">
                                            <div class="auther-img">
                                                <img alt="" src="img/photo1.jpg"></div>
                                            <div class="testimonials-text">"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam fringilla augue..." </div>
                                            <div class="auther-name">Saraha Smith <span>CEO - Falvours Food</span> </div>
                                        </div>
                                    </div>
                                    <!-- End Item -->

                                    <!-- Item -->
                                    <div class="item">
                                        <div class="inner-block">
                                            <div class="auther-img">
                                                <img alt="" src="img/photo.jpg"></div>
                                            <div class="testimonials-text">"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam fringilla augue..." </div>
                                            <div class="auther-name">John Doe <span>Founder - Xyz company</span> </div>
                                        </div>
                                        <div class="inner-block">
                                            <div class="auther-img">
                                                <img alt="" src="img/photo1.jpg"></div>
                                            <div class="testimonials-text">"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam fringilla augue..." </div>
                                            <div class="auther-name">Saraha Smith <span>CEO - Falvours Food</span> </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>


                    <!-- home side banner -->
                    <div class="home-side-banner">
                        <img alt="banner" src="img/home-banner.jpg">
                    </div>

                    <div class="side-banner-img"><a href="#" title="Image">
                        <img src="img/mid-banner2.jpg" alt="Image"></a> </div>
                </div>


            </div>
        </div>
    </div>

    <!-- Footer -->
    <footer>
        <div class="footer-add"><a href="#">
            <img src="img/footer-banner.jpg" alt="download">
        </a></div>
        <div class="footer-inner">
            <div class="container">

                <div class="row">
                    <div class="col-xs-12 col-lg-12">
                        <div class=" pull-left col-xs-3 col-lg-3 ">
                            <h4>QUICK LINKS</h4>
                            <ul class="links">
                                <li class="first"><a href="http://htmldemo.themessoft.com/blog/" title="How to buy">Blog</a></li>
                                <li><a href="#" title="FAQs">FAQs</a></li>
                                <li><a href="#" title="Payment">Payment</a></li>
                                <li><a href="#" title="Shipment">Shipment</a></li>
                                <li><a href="#" title="Where is my order?">Where is my order?</a></li>
                                <li class="last"><a href="#" title="Return policy">Return policy</a></li>
                            </ul>
                        </div>
                   
                        <div class=" pull-left col-xs-3 col-lg-3">
                            <h4>Style Advisor</h4>
                            <ul class="links">
                                <li class="first"><a href="#" title="Your Account">Your Account</a></li>
                                <li><a href="#" title="Information">Information</a></li>
                                <li><a href="#" title="Addresses">Addresses</a></li>
                                <li><a href="#" title="Addresses">Discount</a></li>
                                <li><a href="#" title="Orders History">Orders History</a></li>
                                <li class="last"><a href="#" title=" Additional Information">Additional Information</a></li>
                            </ul>
                        </div>
                        <div class=" pull-left col-xs-3 col-lg-3">
                            <h4>Information</h4>
                            <ul class="links">
                                <li class="first"><a href="#" title="Site Map">Site Map</a></li>
                                <li><a href="#" title="Search Terms">Search Terms</a></li>
                                <li><a href="#" title="Advanced Search">Advanced Search</a></li>
                                <li><a href="#" title="History">About Us</a></li>
                                <li><a href="#" title="History">Contact Us</a></li>
                                <li><a href="#" title="Suppliers">Suppliers</a></li>
                            </ul>
                     
                        </div>


              
                        <div class=" pull-left col-xs-3 col-lg-3">
                            <div class="newsletter-wrap">
                                <h4>Download the App</h4>
                                <div class="app-img">
                                    <img src="img/android-app.png" alt="android"></div>
                                <div class="app-img">
                                    <img src="img/ios-app.png" alt="android"></div>
                                <div class="app-img">
                                    <img src="img/windows-btn.png" alt="android"></div>
                            </div>
                         
                                <div style="display:inline">
                                    <img src="img/payment-1.png" alt="payment1">
                                    <img src="img/payment-2.png" alt="payment2">
                                    <img src="img/payment-3.png" alt="payment3">
                                    <img src="img/payment-4.png" alt="payment4">
                                </div>
                                
                        </div>
                    </div>
               
            </div>
        </div>
        </div>
        <!-- Brand Logo -->

        <div class="brand-logo">
            <div class="container">
                <div class="slider-items-products">
                    <div id="brand-logo-slider" class="product-flexslider hidden-buttons">
                        <div class="slider-items slider-width-col6">

                            <!-- Item -->
                            <div class="item"><a href="#">
                                <img src="img/b-logo3.png" alt="Image">
                            </a></div>
                            <!-- End Item -->

                            <!-- Item -->
                            <div class="item"><a href="#">
                                <img src="img/b-logo1.png" alt="Image">
                            </a></div>
                            <!-- End Item -->

                            <!-- Item -->
                            <div class="item"><a href="#">
                                <img src="img/b-logo2.png" alt="Image">
                            </a></div>
                            <!-- End Item -->

                            <!-- Item -->
                            <div class="item"><a href="#">
                                <img src="img/b-logo4.png" alt="Image">
                            </a></div>
                            <!-- End Item -->

                            <!-- Item -->
                            <div class="item"><a href="#">
                                <img src="img/b-logo5.png" alt="Image">
                            </a></div>
                            <!-- End Item -->

                            <!-- Item -->
                            <div class="item"><a href="#">
                                <img src="img/b-logo6.png" alt="Image">
                            </a></div>
                            <!-- End Item -->

                            <!-- Item -->
                            <div class="item"><a href="#">
                                <img src="img/b-logo2.png" alt="Image">
                            </a></div>
                            <!-- End Item -->

                            <!-- Item -->
                            <div class="item"><a href="#">
                                <img src="img/b-logo4.png" alt="Image">
                            </a></div>
                            <!-- End Item -->

                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class="footer-bottom">
            <div class="container">
                <div class="row">
                    <address>
                         <span><i class="fa fa-map-marker"></i>Aayansh Germinate Pvt. Ltd. </span><span><i class="fa fa-mobile"></i>09090909900</span> <span><i class="fa fa-envelope"></i>support@Aayanshgerminate.com.com</span>
                    </address>
                </div>
            </div>
        </div>
    </footer>

    <!-- End Footer -->

    <!-- mobile menu -->
    <div id="mobile-menu">
        <ul>
            <li>
                <div class="mm-search">
                    <%-- <tr ><td class="abc">offer_price Rs.<asp:Label ID="Label1" runat="server"  Text='<%#Eval("PR_OfferPrice") %>'></asp:Label></td></tr>--%>
                        <div class="input-group">
                            <div class="input-group-btn">
                                <button class="btn btn-default" type="submit"><i class="fa fa-search"></i></button>
                            </div>
                            <input type="text" class="form-control simple" placeholder="Search ..." name="srch-term" id="srch-term">
                        </div>
                    <%--<asp:LinkButton ID="LinkButton1" runat="server" Text='<%#Eval("product_name") %>' %>'  >LinkButton</asp:LinkButton>--%>
                </div>
            </li>
            <li><a href="Home.aspx">Home</a></li>
            <li><a href="#">Entertainment</a>
                <ul>
                    <li><a href="#">Movies</a> </li>
                    <li><a href="#">Events</a> </li>
                    <li><a href="#">Games</a> </li>
                    <li><a href="#">Live Performance</a> </li>
                    <li><a href="#">Concert</a> </li>
                </ul>
            </li>
            <li><a href="#">Offers</a></li>
            <li><a href="#">Services</a>
                <ul>
                    <li><a href="#" class="">Free WIFI</a></li>
                    <li><a href="#">Show Your Talent</a></li>
                    <li><a href="#">Kids Talent</a></li>
                    <li><a href="#">Book Parking</a></li>
                    <li><a href="#">Book Your Food</a></li>
                    <li><a href="#">Book Table In Hotel</a></li>
                </ul>
            </li>
            <li><a href="grid.html">Malls</a></li>

        </ul>
        <div class="top-links">
            <ul class="links">
                <li><a title="Blog" href="#">Sign UP</a> </li>
                <li class="last"><a title="Login" href="#">Sign In</a> </li>
            </ul>
        </div>
    </div>




    <!-- JavaScript -->
    <script type="text/javascript" src="js/jquery.min.js"></script>
    <script type="text/javascript" src="js/bootstrap.min.js"></script>
    <script type="text/javascript" src="js/revslider.js"></script>
    <script type="text/javascript" src="js/common.js"></script>
    <script type="text/javascript" src="js/owl.carousel.min.js"></script>
    <script type="text/javascript" src="js/jquery.mobile-menu.min.js"></script>
    <script type="text/javascript" src="js/countdown.js"></script>

    <script type='text/javascript'>
        jQuery(document).ready(function () {
            jQuery('#rev_slider_4').show().revolution({
                dottedOverlay: 'none',
                delay: 5000,
                startwidth: 600,
                startheight: 461,
                hideThumbs: 200,
                thumbWidth: 200,
                thumbHeight: 50,
                thumbAmount: 2,
                navigationType: 'thumb',
                navigationArrows: 'solo',
                navigationStyle: 'round',
                touchenabled: 'on',
                onHoverStop: 'on',
                swipe_velocity: 0.7,
                swipe_min_touches: 1,
                swipe_max_touches: 1,
                drag_block_vertical: false,
                spinner: 'spinner0',
                keyboardNavigation: 'off',
                navigationHAlign: 'center',
                navigationVAlign: 'bottom',
                navigationHOffset: 0,
                navigationVOffset: 20,
                soloArrowLeftHalign: 'left',
                soloArrowLeftValign: 'center',
                soloArrowLeftHOffset: 20,
                soloArrowLeftVOffset: 0,
                soloArrowRightHalign: 'right',
                soloArrowRightValign: 'center',
                soloArrowRightHOffset: 20,
                soloArrowRightVOffset: 0,
                shadow: 0,
                fullWidth: 'on',
                fullScreen: 'off',
                stopLoop: 'off',
                stopAfterLoops: -1,
                stopAtSlide: -1,
                shuffle: 'off',
                autoHeight: 'off',
                forceFullWidth: 'on',
                fullScreenAlignForce: 'off',
                minFullScreenHeight: 0,
                hideNavDelayOnMobile: 1500,
                hideThumbsOnMobile: 'off',
                hideBulletsOnMobile: 'off',
                hideArrowsOnMobile: 'off',
                hideThumbsUnderResolution: 0,
                hideSliderAtLimit: 0,
                hideCaptionAtLimit: 0,
                hideAllCaptionAtLilmit: 0,
                startWithSlide: 0,
                fullScreenOffsetContainer: ''
            });
        });
    </script>
    <!-- Hot Deals Timer 1-->
    <script type="text/javascript">
        var dthen1 = new Date("12/25/17 11:59:00 PM");
        start = "05/09/15 03:02:11 AM";
        start_date = Date.parse(start);
        var dnow1 = new Date(start_date);
        if (CountStepper > 0)
            ddiff = new Date((dnow1) - (dthen1));
        else
            ddiff = new Date((dthen1) - (dnow1));
        gsecs1 = Math.floor(ddiff.valueOf() / 1000);

        var iid1 = "countbox_1";
        CountBack_slider(gsecs1, "countbox_1", 1);
    </script>

 
                     
          
              </form>
                            <script src="js/easyResponsiveTabs.js" type="text/javascript"></script>
                            <script type="text/javascript">
                                $(document).ready(function () {
                                    $('#horizontalTab').easyResponsiveTabs({
                                        type: 'default', //Types: default, vertical, accordion           
                                        width: 'auto', //auto or any width like 600px
                                        fit: true   // 100% fit in a container
                                    });
                                });
                            </script>
    <script>
        $('#myModal88').modal('show');
    </script>

</body>
</html>
