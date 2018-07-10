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
    public partial class Mall_Detail1 : System.Web.UI.Page
    {
       public SqlConnection con = new SqlConnection(Connection.Conn);
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select M_Id as ID,M_Name as NAME,M_OwnerName as OWNER,M_MBNo as MOBILE,M_EmailId as EMAIL,M_UserName as USERNAME,M_NoOfFloors as FLOORS,M_NoOfShops as SHOPS,M_Country as COUNTRY,M_State as STATE,M_City as CITY,M_Status as STATUS,M_Area as AREA from Mall_Regi  ", con);
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adp.Fill(ds);
           
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("select * from Mall_Regi where M_EmailId='"+TextBox1.Text+"'", con);
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            else
            {
                Response.Write("<script>alert('Please Enter the Email Id')</script>");
            }
        }
    }
}