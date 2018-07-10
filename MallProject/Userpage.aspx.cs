using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class Userpage : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(Connection.connection);
    SqlCommand cmd = new SqlCommand();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // methode name
            Punename();

            SqlCommand cmd = new SqlCommand("select * from ProductRegi", con);
            con.Open();
            //SqlDataReader dr = cmd.ExecuteReader();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataList1.DataSource = ds;
            DataList1.DataBind();

            //select Last 10 Record
            SqlDataAdapter top = new SqlDataAdapter("select TOP 10 * from ProductRegi order by PR_Id desc", con);
            DataTable ds1 = new DataTable();
            top.Fill(ds1);
            DataList2.DataSource = ds1;
            DataList2.DataBind();
            con.Close();

        }
    }
    // fecth data mallname 
    public void Punename()
    {
        SqlDataAdapter adp = new SqlDataAdapter("select DISTINCT (M_State) from Mall_Regi", con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        DropDownList1.DataSource = dt;
        DropDownList1.DataTextField = "M_State";
        DropDownList1.DataValueField = "M_State";
        DropDownList1.DataBind();
        DropDownList1.Items.Insert(0, "Select State");
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
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string c = DropDownList1.SelectedValue.ToString();
        SqlDataAdapter adp = new SqlDataAdapter("select DISTINCT (M_City),M_State from Mall_Regi where M_State='" + DropDownList1.SelectedValue.ToString() + "'", con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        DropDownList2.DataSource = dt;
        DropDownList2.DataTextField = "M_City";
        DropDownList2.DataValueField = "M_City";
        DropDownList2.DataBind();
        DropDownList2.Items.Insert(0, "Select City");
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        string c = DropDownList2.SelectedValue.ToString();
        SqlDataAdapter adp = new SqlDataAdapter("select * from Mall_Regi where M_City='" + DropDownList2.SelectedValue.ToString() + "'", con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        DropDownList3.DataSource = dt;
        DropDownList3.DataTextField = "M_Name";
        DropDownList3.DataValueField = "M_Name";
        DropDownList3.DataBind();
        DropDownList3.Items.Insert(0, "Select Mall Name");

    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        string c = DropDownList3.SelectedValue.ToString();
        SqlDataAdapter adp = new SqlDataAdapter("select * from ProductRegi where M_Name='" + DropDownList3.SelectedValue.ToString() + "'", con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            DataList1.DataSource = dt;
            DataList1.DataBind();
            Session["mall"] = DropDownList3.SelectedValue.ToString();
            Session["city"] = DropDownList2.SelectedValue.ToString();
            Response.Redirect("~/Mallview.aspx");
            
        }
        else
        {

        }
        //if (DropDownList3.SelectedValue.ToString() == "Phonix")
        //{

        //    Response.Redirect("https://www.phoenixmarketcity.com/pune/brands");
        
        
        //}
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedValue.ToString() == "Select State" && DropDownList2.SelectedValue.ToString() == "" && DropDownList3.SelectedValue.ToString() == "")
        {
            SqlCommand cmd = new SqlCommand("select * from ProductRegi", con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataList1.DataSource = ds;
            DataList1.DataBind();
        }
        else
        {
            SqlCommand cmd = new SqlCommand("select * from ProductRegi where M_Name='" + DropDownList3.SelectedValue.ToString() + "' and M_City='" + DropDownList2.SelectedValue.ToString() + "'", con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataList1.DataSource = ds;
            DataList1.DataBind();
        }
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedValue.ToString() == "Select State" && DropDownList2.SelectedValue.ToString() == "" && DropDownList3.SelectedValue.ToString() == "")
        {
            SqlCommand cmd = new SqlCommand("select * from ProductRegi where PC_category_name='Electronic'", con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataList1.DataSource = ds;
            DataList1.DataBind();
        }
        else
        {
            SqlCommand cmd = new SqlCommand("select * from ProductRegi where PC_category_name='Electronic' and M_Name='" + DropDownList3.SelectedValue.ToString() + "'", con);
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataList1.DataSource = ds;
            DataList1.DataBind();
        }
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedValue.ToString() == "Select State" && DropDownList2.SelectedValue.ToString() == "" && DropDownList3.SelectedValue.ToString() == "")
        {
            SqlCommand cmd = new SqlCommand("select * from ProductRegi where PC_category_name='Clothing'", con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataList1.DataSource = ds;
            DataList1.DataBind();
        }
        else
        {
            SqlCommand cmd = new SqlCommand("select * from ProductRegi where PC_category_name='Clothing' and M_Name='" + DropDownList3.SelectedValue.ToString() + "' and M_City='" + DropDownList2.SelectedValue.ToString() + "'", con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataList1.DataSource = ds;
            DataList1.DataBind();
        }
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedValue.ToString() == "Select State" && DropDownList2.SelectedValue.ToString() == "" && DropDownList3.SelectedValue.ToString() == "")
        {
            SqlCommand cmd = new SqlCommand("select * from ProductRegi where PC_category_name='Food'", con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataList1.DataSource = ds;
            DataList1.DataBind();
        }
        else
        {
            SqlCommand cmd = new SqlCommand("select * from ProductRegi where PC_category_name='Food' and M_Name='" + DropDownList3.SelectedValue.ToString() + "' and M_City='" + DropDownList2.SelectedValue.ToString() + "'", con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);

            DataList1.DataSource = ds;
            DataList1.DataBind();
        }
    }
    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedValue.ToString() == "Select State" && DropDownList2.SelectedValue.ToString() == "select city" && DropDownList3.SelectedValue.ToString() == "select shop")
        {
            SqlCommand cmd = new SqlCommand("select * from ProductRegi where PC_category_name='Accessories'", con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataList1.DataSource = ds;
            DataList1.DataBind();
        }
        else
        {
            SqlCommand cmd = new SqlCommand("select * from ProductRegi where PC_category_name='Accessories' and M_Name='" + DropDownList3.SelectedValue.ToString() + "' and M_City='" + DropDownList2.SelectedValue.ToString() + "'", con);
            con.Open();
            //SqlDataReader dr = cmd.ExecuteReader();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataList1.DataSource = ds;
            DataList1.DataBind();
        }
    }
    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedValue.ToString() == "Select State" && DropDownList2.SelectedValue.ToString() == "Select City" && DropDownList3.SelectedValue.ToString() == "Select Shop")
        {
            LinkButton b = (LinkButton)sender;
            int i = Convert.ToInt32(b.CommandName);
            Session["id"] = i;
            Response.Redirect("~/ViewInfo.aspx");
        }
        else
        {
            Session["Mall"] = DropDownList3.SelectedValue.ToString();
            Session["city"] = DropDownList2.SelectedValue.ToString();
            LinkButton b = (LinkButton)sender;
            int i = Convert.ToInt32(b.CommandName);
            Session["id"] = i;
            Response.Redirect("~/ViewInfo.aspx");
        }
    }
    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedValue.ToString() == "Select State" && DropDownList2.SelectedValue.ToString() == "Select City" && DropDownList3.SelectedValue.ToString() == "Select Shop")
        {
            LinkButton b = (LinkButton)sender;
            int i = Convert.ToInt32(b.CommandName);
            Session["id"] = i;
            Response.Redirect("~/ViewInfo.aspx");
        }
        else
        {
            Session["Mall"] = DropDownList3.SelectedValue.ToString();
            Session["city"] = DropDownList2.SelectedValue.ToString();
            LinkButton b = (LinkButton)sender;
            int i = Convert.ToInt32(b.CommandName);
            Session["id"] = i;
            Response.Redirect("~/ViewInfo.aspx");
        }
    }
}