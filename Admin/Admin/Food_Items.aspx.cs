using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
namespace Admin
{
    public partial class Food_Items : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(Connection.Conn);
        string filename, path;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                SqlCommand cmd = new SqlCommand("select * FROM Food_Regi", con);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DropDownList4.DataSource = ds;
                DropDownList4.DataTextField = "Food_Item";
                DropDownList4.DataValueField = "Food_Item";
                DropDownList4.DataBind();
                DropDownList4.Items.Insert(0, " Select Food Item");
                selectcity();
            }
        }
        // code for fetch data from database city name
        public void selectcity()
        {
            SqlDataAdapter city = new SqlDataAdapter("select Distinct(City) from FoodShopReg",con);
            DataTable dt = new DataTable();
            city.Fill(dt);
            DropDownList1.DataSource = dt;
            DropDownList1.DataTextField = "City";
            DropDownList1.DataValueField = "City";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0,"Select City");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            HttpPostedFile postfile = FileUpload1.PostedFile;
            string filename = Path.GetFileName(postfile.FileName);
            string fileExtension = Path.GetExtension(filename);
            int fileSize = postfile.ContentLength;


            if (fileExtension.ToLower() == ".jpg" || fileExtension.ToLower() == ".gif" || fileExtension.ToLower() == ".png" || fileExtension.ToLower() == ".bmp")
            {


                Stream stream = postfile.InputStream;
                BinaryReader binaryReader = new BinaryReader(stream);
                Byte[] bytes = binaryReader.ReadBytes((int)stream.Length);


                SqlCommand cmd1 = new SqlCommand("SP_foodItem", con);
                cmd1.CommandType = CommandType.StoredProcedure;
                SqlParameter para = new SqlParameter()
                {
                    ParameterName = @"M_Id",
                    Value = txtmid.Text

                };

                cmd1.Parameters.Add(para);

                SqlParameter para1 = new SqlParameter()
                {
                    ParameterName = @"FoodId",
                    Value = txtfoodid.Text

                };

                cmd1.Parameters.Add(para1);

                SqlParameter para2 = new SqlParameter()
                {
                    ParameterName = @"Food_Item",
                    Value = DropDownList4.SelectedValue.ToString()

                };

                cmd1.Parameters.Add(para2);

                SqlParameter para3 = new SqlParameter()
                {
                    ParameterName = @"Food_Type",
                    Value = txtfoodtype.Text

                };

                cmd1.Parameters.Add(para3);

                SqlParameter para4 = new SqlParameter()
                {
                    ParameterName = @"Food_Name",
                    Value = txtfoodnm.Text

                };

                cmd1.Parameters.Add(para4);

                SqlParameter para5 = new SqlParameter()
                {
                    ParameterName = @"ShopName",
                    Value = DropDownList3.SelectedValue.ToString()

                };

                cmd1.Parameters.Add(para5);

                SqlParameter para6 = new SqlParameter()
                {
                    ParameterName = @"Price",
                    Value = txtprice.Text

                };

                cmd1.Parameters.Add(para6);

                SqlParameter para7 = new SqlParameter()
                {
                    ParameterName = @"Mall_name",
                    Value = DropDownList2.SelectedValue.ToString()


                };
                cmd1.Parameters.Add(para7);
                    
                SqlParameter para8 = new SqlParameter()
                {
                    ParameterName = @"City",
                    Value = DropDownList1.SelectedValue.ToString()


                };

                cmd1.Parameters.Add(para8);

                SqlParameter paradata = new SqlParameter()
                {
                    ParameterName = @"Images",
                    Value = bytes

                };

                cmd1.Parameters.Add(paradata);
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();



            }

            //SqlCommand cmd = new SqlCommand("Insert into Food_Items values('" + txtmid.Text + "','" + txtfoodid.Text + "','" + DropDownList4.SelectedItem.ToString() + "','" + DropDownList5.SelectedItem.ToString() + "','" + txtfoodnm.Text + "','" +txtshopnm.Text + "','"+txtprice.Text+"')", con);
            //con.Open();
            //cmd.ExecuteNonQuery();
            //con.Close();

        }

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SqlCommand cmd1 = new SqlCommand("Select * from Food_Item_Type where Food_Item='" + DropDownList4.SelectedItem + "'", con);
            //SqlDataAdapter adp1 = new SqlDataAdapter();
            //adp1.SelectCommand = cmd1;
            //DataSet ds1 = new DataSet();
            //adp1.Fill(ds1);
            //DropDownList5.DataSource = ds1;
            //DropDownList5.DataTextField = "Food_Type";
            //DropDownList5.DataValueField = "Food_Type";
            //DropDownList5.DataBind();
            //DropDownList5.Items.Insert(0, " Select Food Type");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter city = new SqlDataAdapter("select Distinct(MallName),city from FoodShopReg where City='"+DropDownList1.SelectedValue.ToString()+"'", con);
            DataTable dt = new DataTable();
            city.Fill(dt);
            DropDownList2.DataSource = dt;
            DropDownList2.DataTextField = "MallName";
            DropDownList2.DataValueField = "MallName";
            DropDownList2.DataBind();

            DropDownList2.Items.Insert(0, "Select MallName");
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter city = new SqlDataAdapter("select Distinct(MallName),city,ShopName from FoodShopReg where MallName='" + DropDownList2.SelectedValue.ToString() + "'", con);
            DataTable dt = new DataTable();
            city.Fill(dt);
            DropDownList3.DataSource = dt;
            DropDownList3.DataTextField = "ShopName";
            DropDownList3.DataValueField = "ShopName";
            DropDownList3.DataBind();

            DropDownList3.Items.Insert(0, "Select ShopName");
        }

       
    }
}