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
    public partial class Mall_Registration : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(Connection.Conn);
        DAL da = new DAL();
        BAL ba = new BAL();
        protected void Page_Load(object sender, EventArgs e)
        {

            
            //TextBox1.Text = Session["Mall"].ToString();
            //TextBox10.Text = Session["state"].ToString();
            //TextBox11.Text = Session["city"].ToString();
            //TextBox12.Text = Session["country"].ToString();

            if (!IsPostBack)
            {
                selectCountry();
            }

            
        }

        public void selectCountry()
        {
            SqlCommand cmd = new SqlCommand("Select * from Country", con);
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DropDownList4.DataSource = ds;
            DropDownList4.DataValueField = "C_Id";
            DropDownList4.DataTextField = "C_Name";
            DropDownList4.DataBind();
            DropDownList4.Items.Insert(0, " Select Country");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ba.M_Name = TextBox1.Text;
            ba.M_OwnerName = TextBox2.Text;
            ba.M_MbNo =Convert.ToDecimal(TextBox3.Text);
            ba.M_EmailId = TextBox4.Text;
            ba.M_UserName = TextBox5.Text;
            ba.M_Password = TextBox6.Text;
            ba.M_NoOfFloors =Convert.ToInt32(TextBox7.Text);
            ba.M_NoOfShops = Convert.ToInt32(TextBox8.Text);
            ba.M_Country = DropDownList4.SelectedItem.ToString();
            ba.M_State = DropDownList1.SelectedItem.ToString();
            ba.M_City = DropDownList2.SelectedItem.ToString();
            ba.M_Status = " ";
            ba.M_Area = TextBox9.Text;
            da.MallInsert(ba);
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
           
        }

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {
           


            SqlCommand cmd = new SqlCommand("Select * from State where C_Id='" + Convert.ToInt32(DropDownList4.SelectedItem.Value) + "'", con);
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DropDownList1.DataSource = ds;
            DropDownList1.DataValueField = "S_Id";
            DropDownList1.DataTextField = "S_Name";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, " Select State Name");


        }

        protected void DropDownList2_SelectedIndexChanged1(object sender, EventArgs e)
        {
            
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from City where S_Id='" + Convert.ToInt32(DropDownList1.SelectedItem.Value) + "'", con);
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DropDownList2.DataSource = ds;
            DropDownList2.DataValueField = "CT_Id";
            DropDownList2.DataTextField = "CT_Name";
            DropDownList2.DataBind();
            DropDownList2.Items.Insert(0, " Select City Name");
        }
        }

        
    }
