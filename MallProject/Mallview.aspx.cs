using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class Mallview : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(Connection.connection);
    string c;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["mall"] == null)
        {
        }
        else
        {
         
            SqlDataAdapter adp = new SqlDataAdapter("select * from ProductRegi where M_Name='" + Session["mall"].ToString()+ "'", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DataList1.DataSource = dt;
                DataList1.DataBind();
                UpdatePanel2.Visible = false;

            }
            else
            {

            }

            //SqlDataAdapter drp = new SqlDataAdapter("select * from ProductRegi where M_Name='" + Session["mall"].ToString() + "' and M_City='"+Session["city"].ToString()+"'", con);
            //DataTable rp = new DataTable();
            //drp.Fill(rp);
            //DropDownList1.DataSource = rp;
            //DropDownList1.DataTextField = "P_Name";
            //DropDownList1.DataValueField = "P_Name";
            //DropDownList1.DataBind();
        }
    }
    protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        c = CheckBoxList1.SelectedValue.ToString();
        SqlDataAdapter adp = new SqlDataAdapter("select * from Shop_Regi", con);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        UpdatePanel1.Visible = false;
        UpdatePanel2.Visible = true;
        DataList2.DataSource = ds;
        DataList2.DataBind();
    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string r = RadioButtonList1.SelectedValue.ToString();
        SqlDataAdapter adp = new SqlDataAdapter("select * from Shop_Regi where Floor='" + r + "'", con);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        UpdatePanel1.Visible = false;
        UpdatePanel2.Visible = true;
        DataList2.DataSource = ds;
        DataList2.DataBind();
    }

    protected void RadioButtonList1_TextChanged(object sender, EventArgs e)
    {
       
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("select * From ProductRegi where P_Name LIKE '%" + txtsearch.Text + "%' or PB_Brand_Name LIKE '%" + txtsearch.Text + "%'   ", con);

        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataSet dt = new DataSet();
        adp.Fill(dt);

        if (dt.Tables[0].Rows.Count > 0)
        {
            DataList1.DataSource = dt;
            DataList1.DataBind();
        }
        else
        {
            //Response.Write("Not Available");
        }
    }
}
