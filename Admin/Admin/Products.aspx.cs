using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Admin
{
    public partial class Products : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(Connection.Conn);
        DAL da = new DAL();
        BAL ba = new BAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlDataAdapter adp = new SqlDataAdapter("select * from Product_Brands ", con);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DropDownList1.DataSource = ds;
                DropDownList1.DataValueField = "PB_id";
                DropDownList1.DataTextField = "PB_Brand_Name";
                DropDownList1.DataBind();

                //fetch data product_category
                SqlDataAdapter adp1 = new SqlDataAdapter("select * from ProductCategoryTb", con);
                DataSet ds1 = new DataSet();
                adp1.Fill(ds1);
                DropDownList2.DataSource = ds1;
                DropDownList2.DataValueField = "PC_id";
                DropDownList2.DataTextField = "PC_category_name";
                DropDownList2.DataBind();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ba.P_Name = txtpname.Text;
            ba.PB_Brand_Name = DropDownList1.SelectedItem.ToString();
            ba.PC_category_name = DropDownList2.SelectedItem.ToString();
            da.ProductsInsert(ba);
        }      
    }
}