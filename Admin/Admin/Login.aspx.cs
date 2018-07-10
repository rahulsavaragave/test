using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Admin
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(Connection.Conn);
        BAL ba = new BAL();
        DAL da = new DAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            ba.L_Email = txtEid.Text;
            ba.L_pass = txtpass.Text;
           DataSet ds= da.LoginForm(ba);

            if (ds.Tables[0].Rows.Count > 0)
            {
                Response.Redirect("~/Home.aspx");
            }
            else
            {
                Response.Write("<script>alert('Please enter correct EmailId and Password')</script>");
            }
        }
    }
}