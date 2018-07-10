using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace Admin
{
    public partial class Mall_Regis : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(Connection.Conn);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlCommand cmd = new SqlCommand("select * from Country", con);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DropDownList3.DataSource = ds;
                DropDownList3.DataTextField = "C_Name";
                DropDownList3.DataValueField = "C_Id";
                DropDownList3.DataBind();
                DropDownList3.Items.Insert(0, " Select Country");
               
                
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from City where S_Id='" +Convert.ToInt32( DropDownList1.SelectedItem.Value) + "'", con);
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DropDownList2.DataSource = ds;
            DropDownList2.DataValueField = "CT_Id";
            DropDownList2.DataTextField = "CT_Name";
            DropDownList2.DataBind();
            DropDownList2.Items.Insert(0, " Select City");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert Into Mall_Names values('" + DropDownList3.SelectedItem.ToString() + "','" + DropDownList1.SelectedItem.ToString() + "','" + DropDownList2.SelectedItem.ToString() + "','" + TextBox1.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();

            Session["State"] = DropDownList1.SelectedItem.ToString();
            Session["City"] = DropDownList2.SelectedItem.ToString();
            Session["Mall"] = TextBox1.Text;
            Session["country"] = DropDownList3.SelectedItem.ToString();
            con.Close();
            Response.Redirect("~/Mall_Registration.aspx");
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from State where C_Id='" + Convert.ToInt32(DropDownList3.SelectedItem.Value) + "'", con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DropDownList1.DataSource = ds;
            DropDownList1.DataTextField = "S_Name";
            DropDownList1.DataValueField = "S_Id";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, " Select State");
        }
    }
}