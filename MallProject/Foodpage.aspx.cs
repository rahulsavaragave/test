using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Foodpage : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(Connection.connection);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            SqlDataAdapter adp = new SqlDataAdapter("select Top 10 * from Food_Regi", con);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataList1.DataSource = ds;
            DataList1.DataBind();

            DataList2.DataSource = ds;
            DataList2.DataBind();

            selectstate();



            SqlDataAdapter adp1 = new SqlDataAdapter("select * from Notifications", con);
            DataTable ds3 = new DataTable();
            adp1.Fill(ds3);

            DataList4.DataSource = ds3;
            DataList4.DataBind();
        }
    }
    //code for select State name
    public void selectstate()
    {
        SqlDataAdapter adp = new SqlDataAdapter("select * from State", con);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        DropDownList1.DataSource = ds;
        DropDownList1.DataValueField = "S_Id";
        DropDownList1.DataTextField = "S_Name";
        DropDownList1.DataBind();
        DropDownList1.Items.Insert(0, "select State");
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlDataAdapter adp = new SqlDataAdapter("select * from City where S_Id='" + DropDownList1.SelectedValue.ToString() + "'", con);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        DropDownList2.DataSource = ds;
        DropDownList2.DataValueField = "CT_Name";
        DropDownList2.DataTextField = "CT_Name";
        DropDownList2.DataBind();
        DropDownList2.Items.Insert(0, "select City");
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlDataAdapter adp = new SqlDataAdapter("select * from Food_Registions where City='" + DropDownList2.SelectedValue.ToString() + "'", con);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        DropDownList3.DataSource = ds;
        DropDownList3.DataValueField = "Mall_Name";
        DropDownList3.DataTextField = "Mall_Name";
        DropDownList3.DataBind();
        DropDownList3.Items.Insert(0, "select Mall_name");
    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlDataAdapter adp = new SqlDataAdapter("select * from Food_Registions where Mall_Name='" + DropDownList3.SelectedValue.ToString() + "'", con);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        DropDownList4.DataSource = ds;
        DropDownList4.DataValueField = "Shop_Name";
        DropDownList4.DataTextField = "Shop_Name";
        DropDownList4.DataBind();
        DropDownList4.Items.Insert(0, "select ShopName");
    }
    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedValue.ToString() == "select State" && DropDownList2.SelectedValue.ToString() == "" && DropDownList3.SelectedValue.ToString() == "" && DropDownList4.SelectedValue.ToString() == "")
        {
            LinkButton b = (LinkButton)sender;
            string name = b.CommandName;
            Session["name"] = name;
            Response.Redirect("~/Foodview.aspx");
        }
        else
        {
            Session["state"] = DropDownList1.SelectedValue.ToString();
            Session["city"] = DropDownList2.SelectedValue.ToString();
            Session["Mall"] = DropDownList3.SelectedValue.ToString();
            Session["shop"] = DropDownList4.SelectedValue.ToString();
            LinkButton b = (LinkButton)sender;
            string name = b.CommandName;
            Session["name"] = name;
            Response.Redirect("~/Foodview.aspx");
        }
    }
}