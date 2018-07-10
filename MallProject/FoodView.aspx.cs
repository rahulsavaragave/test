using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class FoodView : System.Web.UI.Page
{
    public SqlConnection con = new SqlConnection(Connection.connection);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["shop"] == null)
            {
                SqlDataAdapter adp = new SqlDataAdapter("select * from Food_Registions where Food_Item='" + Session["name"] + "'", con);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                DataList2.DataSource = dt;
                DataList2.DataBind();
                UpdatePanel1.Visible = false;
                UpdatePanel2.Visible = true;
            }
            else
            {
                SqlDataAdapter adp = new SqlDataAdapter("select * from Food_Registions where Food_Item='" + Session["name"] + "' and Shop_Name='" + Session["shop"] + "' and City='" + Session["city"] + "' and Mall_Name='" + Session["Mall"] + "'", con);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                DataList2.DataSource = dt;
                DataList2.DataBind();
               UpdatePanel1.Visible = false;
               UpdatePanel2.Visible = true;
            }

            bind();
            selectstate();
        }
    }
    //code for select State name
    public void selectstate()
    {
        SqlDataAdapter adp = new SqlDataAdapter("select * from State", con);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        DropDownList3.DataSource = ds;
        DropDownList3.DataValueField = "S_Id";
        DropDownList3.DataTextField = "S_Name";
        DropDownList3.DataBind();
        DropDownList3.Items.Insert(0, "select State");
    }

    public void bind()
    {
        SqlDataAdapter adp = new SqlDataAdapter("select * from Food_Registions where Food_Item='" + Session["name"] + "'", con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        DropDownList1.DataSource = dt;
        DropDownList1.DataValueField = "Food_Type";
        DropDownList1.DataTextField = "Food_Type";
        DropDownList1.DataBind();
    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlDataAdapter adp = new SqlDataAdapter("select * from City where S_Id='" + DropDownList3.SelectedValue.ToString() + "'", con);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        DropDownList4.DataSource = ds;
        DropDownList4.DataValueField = "CT_Name";
        DropDownList4.DataTextField = "CT_Name";
        DropDownList4.DataBind();
        DropDownList4.Items.Insert(0, "select City");
    }
    protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlDataAdapter adp = new SqlDataAdapter("select * from Food_Registions where City='" + DropDownList4.SelectedValue.ToString() + "'", con);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        DropDownList5.DataSource = ds;
        DropDownList5.DataValueField = "Mall_Name";
        DropDownList5.DataTextField = "Mall_Name";
        DropDownList5.DataBind();
        DropDownList5.Items.Insert(0, "select Mall_name");
    }
    protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlDataAdapter adp = new SqlDataAdapter("select * from Food_Registions where Mall_Name='" + DropDownList5.SelectedValue.ToString() + "'", con);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        DropDownList6.DataSource = ds;
        DropDownList6.DataValueField = "Shop_Name";
        DropDownList6.DataTextField = "Shop_Name";
        DropDownList6.DataBind();
        DropDownList6.Items.Insert(0, "select ShopName");
    }
    protected void DropDownList6_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlDataAdapter adp = new SqlDataAdapter("select * from Food_Registions where Mall_Name='" + DropDownList5.SelectedValue.ToString() + "' and Shop_Name='" + DropDownList6.SelectedValue.ToString() + "'and City='" + DropDownList4.SelectedValue.ToString() + "' and Food_Item='" + Session["name"] + "'", con);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {

            DataList2.DataSource = ds;
            DataList2.DataBind();
        }
        else
        {

        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlDataAdapter adp = new SqlDataAdapter("select * from Food_Registions where Food_Item='" + Session["name"] + "' and Food_Type='" + DropDownList1.SelectedValue.ToString() + "'", con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            DataList2.DataSource = dt;
            DataList2.DataBind();

        }
        else
        {

        }
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        LinkButton b = (LinkButton)sender;
        string name = b.CommandName;
        Session["name"] = name.ToString();
        //SqlDataAdapter adp = new SqlDataAdapter("select * from Food_Registions where FoodId='"+Session["name"].ToString()+"'", con);
        //DataSet ds = new DataSet();
        //adp.Fill(ds);
        //Label1.Text = ds.Tables[0].Rows[0]["Food_Name"].ToString();
        //Label2.Text = ds.Tables[0].Rows[0]["Food_Type"].ToString();
        //Label3.Text = ds.Tables[0].Rows[0]["Price"].ToString();
        //Label4.Text = ds.Tables[0].Rows[0]["Shop_Name"].ToString();
        //DataList1.DataSource = ds;
        //DataList1.DataBind();
        //UpdatePanel2.Visible = true;
        //UpdatePanel1.Visible = false;
        Response.Redirect("~/viewfood.aspx");
    }
}