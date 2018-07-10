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
    public partial class FoodReg : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(Connection.Conn);
        BAL ba = new BAL();
        DAL da = new DAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //code for select sate
                SqlCommand cmd = new SqlCommand("select DISTINCT (M_State) from Mall_Regi ", con);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DropDownList2.DataSource = ds;
                DropDownList2.DataTextField = "M_State";
                DropDownList2.DataValueField = "M_State";
                DropDownList2.DataBind();
                DropDownList2.Items.Insert(0, " Select State");

            }
        }

       

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select DISTINCT (M_City)  from Mall_Regi where M_State='" + DropDownList2.SelectedItem.Value + "'", con);
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DropDownList3.DataSource = ds;
            DropDownList3.DataValueField = "M_City";
            DropDownList3.DataTextField = "M_City";
            DropDownList3.DataBind();
            DropDownList3.Items.Insert(0, " Select City");
         
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ba.M_State = DropDownList2.SelectedValue.ToString();
            ba.M_City = DropDownList3.SelectedValue.ToString();
            ba.M_Name = DropDownList1.SelectedValue.ToString();
            ba.M_Area = DropDownList4.SelectedValue.ToString();
            ba.S_OwnerName = txtshpownernm.Text;
            ba.S_Name = txtshopnm.Text;
            ba.S_Email = txtemailid.Text;
            ba.S_UserName = txtuser.Text;
            ba.S_Password = txtpass.Text;
            ba.S_Contactno = txtcontactno.Text;
            da.FoodShopRegi(ba);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           
            


        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Mall_regi where M_City='" + DropDownList3.SelectedItem.Value + "'", con);
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DropDownList1.DataSource = ds;
            DropDownList1.DataValueField = "M_Name";
            DropDownList1.DataTextField = "M_Name";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, " Select Mall Name");
        }

        protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Mall_regi where M_Name='" + DropDownList1.SelectedItem.Value + "'", con);
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DropDownList4.DataSource = ds;
            DropDownList4.DataValueField = "M_Area";
            DropDownList4.DataTextField = "M_Area";
            DropDownList4.DataBind();
            DropDownList4.Items.Insert(0, " Select Area");
        }

        
    }
}