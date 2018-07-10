﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Security;
namespace Admin
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
             //LogOut Code

        Session.Clear();
        Session.Abandon();
        Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(0));
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Cache.SetNoStore();

        try
        {
            Session.Abandon();
            FormsAuthentication.SignOut();
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Buffer = true;
            Response.ExpiresAbsolute = DateTime.Now.AddDays(-1d);
            // Response.Expires = -100;
            Response.CacheControl = "no-cache";
            //Response.Redirect("login.aspx", true);
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
        Response.Redirect("~/Login.aspx");
    }

        }
        }
    
