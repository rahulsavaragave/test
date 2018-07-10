using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Text;
using System.Drawing;
using System.Data.SqlClient;

public partial class Nearmall : System.Web.UI.Page
{
    string url;
    SqlConnection con = new SqlConnection(Connection.connection);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SqlDataAdapter adp = new SqlDataAdapter("select Distinct(M_City) from Mall_Regi", con);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DropDownList1.DataSource = ds;
            DropDownList1.DataTextField = "M_City";
            DropDownList1.DataValueField = "M_City";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, "Select City");
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            string street = string.Empty;
            StringBuilder queryAddress = new StringBuilder();
            queryAddress.Append("http://maps.google.com/maps?q=");

            if (txtsearch.Text != string.Empty)
            {
                street = txtsearch.Text.Replace(' ', '+');
                queryAddress.Append(street + ',' + '+');
            }
            url = queryAddress.ToString();
            Response.Redirect(url, false);
        }
        catch (Exception ex)
        {
            //MessageBox.Show(ex.Message.ToString(), "Unable to Retrieve Map");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlDataAdapter adp = new SqlDataAdapter("select M_Name as MallName,M_City as City ,M_Area as Locations from Mall_Regi where  M_City='" + DropDownList1.SelectedValue.ToString() + "' and M_Area='" + DropDownList2.SelectedValue.ToString() + "' ", con);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlDataAdapter adp = new SqlDataAdapter("select Distinct(M_Area),M_City  from Mall_Regi where M_City='" + DropDownList1.SelectedValue.ToString() + "' ", con);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        DropDownList2.DataSource = ds;
        DropDownList2.DataTextField = "M_Area";
        DropDownList2.DataValueField = "M_Area";
        DropDownList2.DataBind();
        DropDownList2.Items.Insert(0, "Select Area");
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}