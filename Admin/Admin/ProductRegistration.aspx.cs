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
    public partial class ProductRegistration : System.Web.UI.Page
    {
       
        SqlConnection con = new SqlConnection(Connection.Conn);
        DAL da = new DAL();
        BAL ba = new BAL();
        string filename, path;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // code for select products
                SqlCommand cmd = new SqlCommand("Select * from Products", con);
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = cmd;
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DropDownList3.DataSource = ds;
                DropDownList3.DataTextField = "P_Name";
                DropDownList3.DataValueField = "P_Id";
                DropDownList3.DataBind();
                DropDownList3.Items.Insert(0, " Select ProductsName");

                // code for select mallname
                //SqlCommand cmd1 = new SqlCommand("Select * from Shop_Regi", con);
                //SqlDataAdapter adp1 = new SqlDataAdapter();
                //adp1.SelectCommand = cmd1;
                //DataSet ds1 = new DataSet();
                //adp1.Fill(ds1);
                //DropDownList1.DataSource = ds1;
                //DropDownList1.DataTextField = "M_Name";
                //DropDownList1.DataValueField = "M_Name";
                //DropDownList1.DataBind();
                //DropDownList1.Items.Insert(0, " Select Mall Name");

                
                // code for select City
                SqlDataAdapter adp3 = new SqlDataAdapter("select DISTINCT (M_City) from Mall_Regi ", con);
                DataTable dt3 = new DataTable();
                adp3.Fill(dt3);
                DropDownList6.DataSource = dt3;
                DropDownList6.DataTextField = "M_City";
                DropDownList6.DataValueField = "M_City";
                DropDownList6.DataBind();
                DropDownList6.Items.Insert(0, "Select City");
            }

        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            HttpPostedFile postfile = FileUpload1.PostedFile;
            string filename = Path.GetFileName(postfile.FileName);
            string fileExtension = Path.GetExtension(filename);
            int fileSize = postfile.ContentLength;


            if (fileExtension.ToLower() == ".jpeg" || fileExtension.ToLower() == ".jpg" || fileExtension.ToLower() == ".gif" || fileExtension.ToLower() == ".png" || fileExtension.ToLower() == ".bmp")
            {


                Stream stream = postfile.InputStream;
                BinaryReader binaryReader = new BinaryReader(stream);
                Byte[] bytes = binaryReader.ReadBytes((int)stream.Length);


                SqlCommand cmd1 = new SqlCommand("SP_ProductRegi", con);
                cmd1.CommandType = CommandType.StoredProcedure;
                SqlParameter para = new SqlParameter()
                {
                    ParameterName = @"M_Name",
                    Value = DropDownList1.SelectedItem.ToString()

                };

                cmd1.Parameters.Add(para);

                SqlParameter para1 = new SqlParameter()
                {
                    ParameterName = @"S_Name",
                    Value = DropDownList2.SelectedItem.ToString()

                };

                cmd1.Parameters.Add(para1);

                SqlParameter para7 = new SqlParameter()
                {
                    ParameterName = @"PC_category_name",
                    Value = DropDownList5.SelectedItem.ToString()

                };

                cmd1.Parameters.Add(para7);

                SqlParameter para2 = new SqlParameter()
                {
                    ParameterName = @"PB_Brand_Name",
                    Value = DropDownList4.SelectedItem.ToString()
                   
                };

                cmd1.Parameters.Add(para2);

                SqlParameter para3 = new SqlParameter()
                {
                    ParameterName = @"P_Name",
                    Value = DropDownList3.SelectedItem.ToString()

                };

                cmd1.Parameters.Add(para3);

                SqlParameter para4 = new SqlParameter()
                {
                    ParameterName = @"PR_Type",
                    Value = txtproducttype.Text

                };

                cmd1.Parameters.Add(para4);

                SqlParameter para5 = new SqlParameter()
                {
                    ParameterName = @"PR_Price",
                    Value = Convert.ToDecimal(txtproductprice.Text)

                };

                cmd1.Parameters.Add(para5);

                SqlParameter para6 = new SqlParameter()
                {
                    ParameterName = @"PR_OfferPrice",
                    Value = Convert.ToDecimal(txtproductofferprice.Text)

                };

                cmd1.Parameters.Add(para6);


                SqlParameter para8 = new SqlParameter()
                {
                    ParameterName = @"PR_Description",
                    Value = txtDescription.Text

                };


                cmd1.Parameters.Add(para8);

                

                SqlParameter para9 = new SqlParameter()
                {
                    ParameterName = @"M_City",
                    Value = DropDownList6.SelectedValue.ToString()

                };

                cmd1.Parameters.Add(para9);



                SqlParameter paradata = new SqlParameter()
                {
                    ParameterName = @"PR_Image",
                    Value = bytes

                };

                cmd1.Parameters.Add(paradata);
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();
                

                
            }
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlCommand cmd1 = new SqlCommand("Select Distinct(PC_category_name),P_Name  from Products where P_Name='" + DropDownList3.SelectedItem + "'", con);
            SqlDataAdapter adp1 = new SqlDataAdapter();
            adp1.SelectCommand = cmd1;
            DataSet ds1 = new DataSet();
            adp1.Fill(ds1);
            DropDownList5.DataSource = ds1;
            DropDownList5.DataTextField = "PC_category_name";
            DropDownList5.DataValueField = "PC_category_name";
            DropDownList5.DataBind();
            DropDownList5.Items.Insert(0, " Select Product Category Name");

        }

        protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
        {
           //display product brand
                SqlCommand cmd3 = new SqlCommand("Select Distinct(PB_Brand_Name),PC_category_name from Products where PC_category_name='" + DropDownList5.SelectedItem + "'", con);
                SqlDataAdapter adp3 = new SqlDataAdapter();
                adp3.SelectCommand = cmd3;
                DataSet ds3 = new DataSet();
                adp3.Fill(ds3);
                DropDownList4.DataSource = ds3;
                DropDownList4.DataTextField = "PB_Brand_Name";
                DropDownList4.DataValueField = "PB_Brand_Name";

                DropDownList4.DataBind();
                DropDownList4.Items.Insert(0, " Select Product Brand Name");
     
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("Select * from Shop_Regi where M_Name='"+DropDownList1.SelectedValue.ToString()+"'", con);
            SqlDataAdapter adp2 = new SqlDataAdapter();
            adp2.SelectCommand = cmd2;
            DataSet ds2 = new DataSet();
            adp2.Fill(ds2);
            DropDownList2.DataSource = ds2;
            DropDownList2.DataTextField = "S_Name";
            DropDownList2.DataValueField = "S_Name";
            DropDownList2.DataBind();
            DropDownList2.Items.Insert(0, " Select Shop Name");
        }

        protected void DropDownList6_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adp3 = new SqlDataAdapter("select *  from Mall_Regi where M_City='"+DropDownList6.SelectedValue.ToString()+"' ", con);
            DataTable dt3 = new DataTable();
            adp3.Fill(dt3);
            DropDownList1.DataSource = dt3;
            DropDownList1.DataTextField = "M_Name";
            DropDownList1.DataValueField = "M_Name";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, "Select Mall_Name");
        }

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

          
        
    }
}