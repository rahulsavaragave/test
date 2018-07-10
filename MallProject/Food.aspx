<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Food.aspx.cs" Inherits="Food" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
   <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
   
    <link href="style-css/bootstrap.min.css" rel="stylesheet" />
    <script src="js/bootstrap.min.js"></script>
 
    <script src="js/jquery.min.js"></script>
     
</head>
<body>
    <form id="form1" runat="server">

   


<div class="container">
    <div class="row">
        <div class="col-md-12">

            <img src="img/b1.jpg" width="100%" height="400" />
        </div>


    </div>

    <div class="row">
        <div class="row" style="height:50px; width:100%;" ></div>
        <div class="col-md-1"></div>

           <div class="col-md-8">
               <div 
                   
                   
                   
                   
                   
                   >
               <asp:DropDownList ID="DropDownList1" runat="server">
                   <asp:ListItem>----Select City-------</asp:ListItem>
                   <asp:ListItem>Pune</asp:ListItem>
                   <asp:ListItem>Mumbai</asp:ListItem>
               </asp:DropDownList>    
             </div>
               <asp:DropDownList ID="DropDownList2" runat="server">
                   <asp:ListItem>----Select Mall-------</asp:ListItem>
                   <asp:ListItem>Season</asp:ListItem>
                   <asp:ListItem>Central</asp:ListItem>
               </asp:DropDownList>    
             
               <asp:DropDownList ID="DropDownList3" runat="server">
                   <asp:ListItem>----Select Area-------</asp:ListItem>
                   <asp:ListItem>Pimpari</asp:ListItem>
                   <asp:ListItem>Shivaji Nagar</asp:ListItem>
                   <asp:ListItem>Deccan</asp:ListItem>
               </asp:DropDownList>    
             
               <asp:Button ID="Button1" runat="server" Height="30px" Text="Show Shops" Width="326px" />
             
           </div>

           <div class="col-md-1"></div>


    </div>
  
</div>
    </form>
</body>
</html>
