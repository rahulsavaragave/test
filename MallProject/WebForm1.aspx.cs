using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;
public partial class WebForm1 : System.Web.UI.Page
{
    BAL ba = new BAL();
    DAL da = new DAL();
    SqlConnection con = new SqlConnection(Connection.connection);
    //SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["conn"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (txtemail.Text == "" || txtpass.Text == "")
        {
            Response.Write("<script>alert('Please Enter Username and Password')</script>");
        }
        else
        {
            ba.Email = txtemail.Text;
            ba.Pass = txtpass.Text;

            DataTable dt = da.userlogin(ba);
            if (dt.Rows.Count > 0)
            {
                //SqlCommand cmd = new SqlCommand("delete from User_Regi  where EmailId='" + txtemail.Text + "' and Pass='" + txtpass.Text + "'", con);
                //con.Open();
                //cmd.ExecuteNonQuery();
                //con.Close();

                Response.Redirect("~/Userpage.aspx");
            }
            else
            {
                Response.Write("<script>alert('Please Enter Correct UserName and Password.......')</script>");
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        ba.Name = txtname.Text;
        ba.Email = txtemailId.Text;
        ba.Pass = txtpassword.Text;
        ba.Confirm_pass = txtconfirm.Text;
        ba.Gender = RadioButtonList1.SelectedValue.ToString();
        ba.Contact_No = txtphone.Text;
        ba.Address = txtaddress.Text;
        ba.City = txtcity.Text;
        da.UserRegis(ba);
    }
}