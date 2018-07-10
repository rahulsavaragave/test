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
    public partial class Try : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(Connection.Conn);


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // code for select City
                SqlDataAdapter adp3 = new SqlDataAdapter("select DISTINCT (M_City) from Mall_Regi ", con);
                DataTable dt3 = new DataTable();
                adp3.Fill(dt3);
                ddlCity.DataSource = dt3;
                ddlCity.DataTextField = "M_City";
                ddlCity.DataValueField = "M_City";
                ddlCity.DataBind();
                ddlCity.Items.Insert(0, "Select City");

                SqlCommand cmd1 = new SqlCommand("Select Distinct(PC_category_name),P_Name  from Products ", con);
                SqlDataAdapter adp1 = new SqlDataAdapter();
                adp1.SelectCommand = cmd1;
                DataSet ds1 = new DataSet();
                adp1.Fill(ds1);
                ddlProdCat.DataSource = ds1;
                ddlProdCat.DataTextField = "PC_category_name";
                ddlProdCat.DataValueField = "PC_category_name";
                ddlProdCat.DataBind();
                ddlProdCat.Items.Insert(0, " Select Product Category Name");

            }


        }

        protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adp3 = new SqlDataAdapter("select DISTINCT (M_Name) from Mall_Regi where M_City='"+ddlCity.SelectedItem+"'", con);
            DataTable dt3 = new DataTable();
            adp3.Fill(dt3);
            ddlMall.DataSource = dt3;
            ddlMall.DataTextField = "M_Name";
            ddlMall.DataValueField = "M_Name";
            ddlMall.DataBind();
            ddlMall.Items.Insert(0, "Select Mall name");
        }

        protected void ddlShop_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void ddlMall_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adp3 = new SqlDataAdapter("select DISTINCT(S_Name) from Shop_Regi where M_Name='" + ddlMall.SelectedItem + "'", con);
            DataTable dt3 = new DataTable();
            adp3.Fill(dt3);
            ddlShop.DataSource = dt3;
            ddlShop.DataTextField = "S_Name";
            ddlShop.DataValueField = "S_Name";
            ddlShop.DataBind();
            ddlShop.Items.Insert(0, "Select Shop name");
        }

        protected void ddlProdCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SqlCommand cmd1 = new SqlCommand("Select *  from Products where P_Name='" + DropDownList3.SelectedItem + "'", con);
            //SqlDataAdapter adp1 = new SqlDataAdapter();
            //adp1.SelectCommand = cmd1;
            //DataSet ds1 = new DataSet();
            //adp1.Fill(ds1);
            //DropDownList5.DataSource = ds1;
            //DropDownList5.DataTextField = "PC_category_name";
            //DropDownList5.DataValueField = "P_Name";
            //DropDownList5.DataBind();
            //DropDownList5.Items.Insert(0, " Select Product Category Name");

        }
    }
}