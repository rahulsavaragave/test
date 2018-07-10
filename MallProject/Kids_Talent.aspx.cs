using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class Kids_Talent : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(Connection.connection);
    protected void Page_Load(object sender, EventArgs e)
    {
        
        SqlCommand cmd = new SqlCommand("select * from kidimage", con);
        con.Open();

        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        DataSet ds = new DataSet();
        da.Fill(ds);



        DataList1.DataSource = ds;
        DataList1.DataBind();
        con.Close();


        SqlDataAdapter da1 = new SqlDataAdapter("Select Top 3 * from kidimage order by id desc", con);
        DataSet ds1 = new DataSet();
        da1.Fill(ds1);
        DataList3.DataSource = ds1;
        DataList3.DataBind();
        con.Close();

        SqlDataAdapter adp = new SqlDataAdapter("select * from Notifications", con);
        DataTable ds3 = new DataTable();
        adp.Fill(ds3);

        DataList4.DataSource = ds3;
        DataList4.DataBind();
        con.Close();

        //fetch data form database malls name in pune
        SqlDataAdapter pune = new SqlDataAdapter("select Distinct(M_Name) from Mall_Regi where M_city='Pune' ", con);
        DataTable dp = new DataTable();
        pune.Fill(dp);
        DropDownList1.DataSource = dp;
        DropDownList1.DataTextField = "M_Name";
        DropDownList1.DataValueField = "M_Name";

        DropDownList1.DataBind();
        DropDownList1.Items.Insert(0, "Select Pune Malls");

        //fetch data form database malls name in Mumbai
        SqlDataAdapter mumbai = new SqlDataAdapter("select Distinct(M_Name) from Mall_Regi where M_city='Mumbai' ", con);
        DataTable dm = new DataTable();
        mumbai.Fill(dm);
        DropDownList2.DataSource = dm;
        DropDownList2.DataTextField = "M_Name";
        DropDownList2.DataValueField = "M_Name";

        DropDownList2.DataBind();
        DropDownList2.Items.Insert(0, "Select Mumbai Malls");


        //fetch data form database malls name in Ahmedabad
        SqlDataAdapter Ahmedabad = new SqlDataAdapter("select Distinct(M_Name) from Mall_Regi where M_city='Ahmedabad' ", con);
        DataTable dah = new DataTable();
        Ahmedabad.Fill(dah);
        DropDownList3.DataSource = dah;
        DropDownList3.DataTextField = "M_Name";
        DropDownList3.DataValueField = "M_Name";

        DropDownList3.DataBind();
        DropDownList3.Items.Insert(0, "Select Ahmedabad Malls");



        //fetch data form database malls name in Baroda
        SqlDataAdapter Baroda = new SqlDataAdapter("select Distinct(M_Name) from Mall_Regi where M_city='Baroda' ", con);
        DataTable db = new DataTable();
        Baroda.Fill(db);
        DropDownList4.DataSource = db;
        DropDownList4.DataTextField = "M_Name";
        DropDownList4.DataValueField = "M_Name";

        DropDownList4.DataBind();
        DropDownList4.Items.Insert(0, "Select Baroda Malls");

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("select * from kidimage", con);


        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        DataSet ds = new DataSet();
        da.Fill(ds);
        DataList1.DataSource = ds;
        DataList1.DataBind();
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        //SqlCommand cmd = new SqlCommand("select * from Kids_Video", con);


        //SqlDataAdapter da = new SqlDataAdapter();
        //da.SelectCommand = cmd;
        //DataSet ds = new DataSet();
        //da.Fill(ds);
        //DataList1.DataSource = ds;
        //DataList1.DataBind();

        using (SqlCommand cmd = new SqlCommand())
        {
            cmd.CommandText = "select Id, Name from Kids_Video";
            cmd.Connection = con;
            con.Open();
            DataList1.DataSource = cmd.ExecuteReader();
            DataList1.DataBind();
            con.Close();
        }
    }

//    private void BindGrid()
//{    
//        using (SqlCommand cmd = new SqlCommand())
//        {
//            cmd.CommandText = "select Id, Name from Kids_Video";
//            cmd.Connection = con;
//            con.Open();
//            DataList1.DataSource = cmd.ExecuteReader();
//            DataList1.DataBind();
//            con.Close();
//        }
//    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlDataAdapter adp = new SqlDataAdapter("select * from ProductRegi where M_Name='" + DropDownList1.SelectedItem.ToString() + "'", con);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            DataList2.DataSource = ds;
            DataList2.DataBind();
        }
        else
        {

            // Response.Write("<script>alert('Data is Not Available')</script>");
           // DataList1.Visible = false;
        }
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlDataAdapter adp = new SqlDataAdapter("select * from ProductRegi where M_Name='" + DropDownList2.SelectedItem.ToString() + "'", con);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        DataList1.DataSource = ds;
        DataList1.DataBind();
    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlDataAdapter adp = new SqlDataAdapter("select * from ProductRegi where M_Name='" + DropDownList3.SelectedItem.ToString() + "'", con);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        DataList1.DataSource = ds;
        DataList1.DataBind();
    }
    protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlDataAdapter adp = new SqlDataAdapter("select * from ProductRegi where M_Name='" + DropDownList4.SelectedItem.ToString() + "'", con);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        DataList1.DataSource = ds;
        DataList1.DataBind();
    }
}
