<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Yourimage.aspx.cs" Inherits="Yourimage" %>

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
    <link rel="stylesheet" type="text/css" href="style-css/header.css" />
    <script type="text/javascript" src="engine1/jquery.js"></script>
    <!-- Google Fonts -->
    <link href='http://fonts.googleapis.com/css?family=Open+Sans:700,600,800,400|Raleway:400,300,600,500,700,800' rel='stylesheet' type='text/css'>

</head>

<body class="cms-index-index cms-home-page" style="background-image:url(img/IMAGEMODEL.png)">
    <%--<body class="cms-index-index cms-home-page">--%>
    <div id="page">
  
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
     
    <a href="#" id="toTop" style="display: none"><span id="toTopHover" style="opacity: 0;"></span></a>


   <%-- <div class="modal fade" id="myModal88" tabindex="-1" role="dialog" aria-labelledby="myModal88"
        aria-hidden="true">--%>
        <div class="modal-dialog modal-lg">
            <div class="modal-content">
                <div class="modal-header">
                      <form id="Form1" action="#" method="post" runat="server">

                <p style="text-align:right">  <asp:Button ID="Button3" runat="server" Text="Close" OnClick="Button3_Click"/>
                      
                    <h4 class="modal-title" id="myModalLabel">Your's Talent</h4>
                </div>
                <div class="modal-body modal-body-sub">
                    <div class="row">
                        <div class="col-md-8 modal_body_left modal_body_left1" style="border-right: 1px dotted #C2C2C2; padding-right: 3em;">
                            <div class="sap_tabs">
                                <div id="horizontalTab" style="display: block; width: 100%; margin: 0px;">
                                    <ul>
                                        <li class="resp-tab-item" aria-controls="tab_item-0"><span>Images Talent's</span></li>
                                        <li class="resp-tab-item" aria-controls="tab_item-1"><span>Video Talent's</span></li>
                                    </ul>
                                    <div class="tab-1 resp-tab-content" aria-labelledby="tab_item-0">
                                        <div class="facts">
                                            <div class="register">
                                             

                                                 <asp:TextBox ID="txtiname" runat="server" placeholder="Enter Name"></asp:TextBox>
                                               
                                                    <asp:TextBox ID="txtimgname" runat="server" placeholder="Enter image name" ></asp:TextBox>

                                                    <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control" />
                                               

													<%--<input name="Email" placeholder="Email Address" type="text" required>
                                                    <input name="Password" placeholder="Password" type="password" required>--%>
                                                    <div class="sign-up">
                                                      <%--  <input type="submit" value="Sign in" />--%>
                                                        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click"/>
                                                    </div>
                                                    <%--</form>--%>
                                                                                                
                                            </div>
                                        </div>
                                       
                                    </div>

                                    <div class="tab-2 resp-tab-content" aria-labelledby="tab_item-1">
                                        <div class="facts">
                                            <div class="register">
                                                <%--<form action="#" method="post" runat="server">--%>
                                                <asp:TextBox ID="txtname" runat="server"  placeholder="User Name"></asp:TextBox>
                                                  
                                                <asp:TextBox ID="txtvideoname" runat="server"  placeholder="Video Name"></asp:TextBox>

                                                <asp:FileUpload ID="FileUpload2" runat="server" CssClass="form-control" />
                                                   <div class="sign-up">
                                                   <asp:Button ID="Button2" runat="server" Text="Submit" OnClick="Button2_Click" />   
                                                    </div>
                                            
                                            </div>
                                            </form>
                                        </div>
                                    </div>
                                </div>
                                
                            </div>
                                
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
                           <%-- <div id="OR" class="hidden-xs">
                                OR
                            </div>--%>
                        </div>
                   
                    </div>
                </div>

            </div>
        </div>
    </div>
    <script>
        $('#myModal88').modal('show');
    </script>
               

</body>
</html>
