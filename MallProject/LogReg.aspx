<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LogReg.aspx.cs" Inherits="LogReg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
     <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
 
    <!-- Favicons Icon -->
    <link rel="icon" href="img/favicon.ico" type="img/x-icon" />
    <link rel="shortcut icon" href="img/favicon.ico" type="img/x-icon" />
  

    <!-- Mobile Specific -->
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1"/>

    <!-- CSS Style -->
    <link rel="stylesheet" type="text/css" href="style-css/bootstrap.min.css"/>
    <link rel="stylesheet" type="text/css" href="style-css/font-awesome.css" media="all"/>
    <link rel="stylesheet" type="text/css" href="style-css/simple-line-icons.css" media="all"/>
    <link rel="stylesheet" type="text/css" href="style-css/owl.carousel.css"/>
    <link rel="stylesheet" type="text/css" href="style-css/owl.theme.css"/>
    <link rel="stylesheet" type="text/css" href="style-css/jquery.bxslider.css"/>
    <link rel="stylesheet" type="text/css" href="style-css/jquery.mobile-menu.css"/>
    <link rel="stylesheet" type="text/css" href="style-css/revslider.css"/>
    <link rel="stylesheet" type="text/css" href="style-css/style.css" media="all"/>
    <link rel="stylesheet" type="text/css" href="engine1/style.css" />
    <link rel="stylesheet" type="text/css" href="style-css/header.css" />
    <script type="text/javascript" src="engine1/jquery.js"></script>
    <!-- Google Fonts -->
    <link href='http://fonts.googleapis.com/css?family=Open+Sans:700,600,800,400|Raleway:400,300,600,500,700,800' rel='stylesheet' type='text/css'/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   
    
    <div class="modal fade" id="myModal88" tabindex="-1" role="dialog" aria-labelledby="myModal88"
        aria-hidden="true">
        <div class="modal-dialog modal-lg">
            <div class="modal-content">
                <div class="modal-header">
                    <asp:Button ID="Button2" runat="server" Text="x" class="close" data-dismiss="modal"  aria-hidden="true" PostBackUrl="~/Home.aspx"/>
                     
                    <h4 class="modal-title" id="myModalLabel">Don't Wait, Login now!</h4>
                </div>
                <div class="modal-body modal-body-sub">
                    <div class="row">
                        <div class="col-md-8 modal_body_left modal_body_left1" style="border-right: 1px dotted #C2C2C2; padding-right: 3em;">
                            <div class="sap_tabs">
                                <div id="horizontalTab" style="display: block; width: 100%; margin: 0px;">
                                    <ul>
                                        <li class="resp-tab-item" aria-controls="tab_item-0"><span>Sign in</span></li>
                                        <li class="resp-tab-item" aria-controls="tab_item-1"><span>Sign up</span></li>
                                    </ul>
                                    <div class="tab-1 resp-tab-content" aria-labelledby="tab_item-0">
                                        <div class="facts">
                                            <div class="register">
                                            <%--    <form action="#" method="post" runat="server">--%>

                                                    <asp:TextBox ID="txtemail" runat="server" placeholder="Email Address"></asp:TextBox>
                                                    <asp:TextBox ID="txtpass" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>

													<%--<input name="Email" placeholder="Email Address" type="text" required>
                                                    <input name="Password" placeholder="Password" type="password" required>--%>
                                                    <div class="sign-up">
                                                      <%--  <input type="submit" value="Sign in" />--%>
                                                        <asp:Button ID="txtsignin" runat="server" Text="Sign in"  CssClass="btn btn-primary"   UseSubmitBehavior="false"/>
                                                    </div>
                                                    <%--</form>--%>
                                            </div>
                                        </div>
                                    </div></div></div></div></div></div>
                                   
                                    <div class="tab-2 resp-tab-content" aria-labelledby="tab_item-1">
                                        <div class="facts">
                                            <div class="register">
                                         
                                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                                <asp:TextBox ID="txtemailId" runat="server"  placeholder="Email Address"></asp:TextBox>
                                                <asp:TextBox ID="txtpassword" runat="server"  placeholder="Password" TextMode="Password"></asp:TextBox>
                                                <asp:TextBox ID="txtconfirm" runat="server"  placeholder="Confirm Password" TextMode="Password"></asp:TextBox>
                                               Gender &nbsp;&nbsp; <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow" >
                                                    <asp:ListItem>Male &nbsp;&nbsp;&nbsp;&nbsp; </asp:ListItem>
                                                    <asp:ListItem>Female</asp:ListItem>
                                                </asp:RadioButtonList>
                                                <asp:TextBox ID="txtphone" runat="server"  placeholder="Enter Phone Number"></asp:TextBox>
                                                <asp:TextBox ID="txtaddress" runat="server"  placeholder="Enter Address" TextMode="MultiLine"></asp:TextBox>
                                                <asp:TextBox ID="txtcity" runat="server"  placeholder="Enter City"></asp:TextBox>
                                                    
                                                    <div class="sign-up">
                                                        <%--<input type="submit" value="Create Account" />--%>
                                                        <asp:Button ID="Button1" runat="server" Text="Button"  UseSubmitBehavior="false" />
                                                    </div>
                                               

                                            </div>
                                        </div>
    </div>
    </form>
</body>
</html>
