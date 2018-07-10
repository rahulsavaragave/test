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
    public partial class Shop_Registration : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(Connection.Conn);
        DAL da = new DAL();
        BAL ba = new BAL();
        string filename, path;
        protected void Page_Load(object sender, EventArgs e)
        {
          
                //SqlCommand cmd = new SqlCommand("Select * from City  ", con);
                //SqlDataAdapter adp = new SqlDataAdapter();
                //adp.SelectCommand = cmd;
                //DataSet ds = new DataSet();
                //adp.Fill(ds);
                //DropDownList3.DataSource = ds;
                //DropDownList3.DataValueField = "CT_Id";
                //DropDownList3.DataTextField = "CT_Name";
                //DropDownList3.DataBind();

            if (!IsPostBack)
            {
                SqlCommand cmd1 = new SqlCommand("Select  DISTINCT(M_State) from Mall_Regi", con);
                SqlDataAdapter adp1 = new SqlDataAdapter();
                adp1.SelectCommand = cmd1;
                DataSet ds1 = new DataSet();
                adp1.Fill(ds1);

                DropDownList3.DataSource = ds1;
                DropDownList3.DataValueField = "M_State";
                DropDownList3.DataTextField = "M_State";
                DropDownList3.DataBind();
                DropDownList3.Items.Insert(0, " Select State Name");
            }  
            
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        //    HttpPostedFile postfile = FileUpload1.PostedFile;
        //    string filename = Path.GetFileName(postfile.FileName);
        //    string fileExtension = Path.GetExtension(filename);
        //    int fileSize = postfile.ContentLength;


        //    if (fileExtension.ToLower() == ".jpg" || fileExtension.ToLower() == ".gif" || fileExtension.ToLower() == ".png" || fileExtension.ToLower() == ".bmp")
        //    {


        //        Stream stream = postfile.InputStream;
        //        BinaryReader binaryReader = new BinaryReader(stream);
        //        Byte[] bytes = binaryReader.ReadBytes((int)stream.Length);


        //        SqlCommand cmd1 = new SqlCommand("SP_shopRegi", con);
        //        cmd1.CommandType = CommandType.StoredProcedure;
        //        cmd1.Parameters.AddWithValue("@query", "insert");

        //        SqlParameter para = new SqlParameter()
        //        {
        //            ParameterName=@"State",
        //            Value=DropDownList3.SelectedItem.ToString()
        //        };
            
        //         cmd1.Parameters.Add(para);
        //        SqlParameter para1 = new SqlParameter()
        //        {
        //            ParameterName =@"M_Name",
        //            Value = DropDownList2.SelectedItem.ToString()



        //        };

        //        cmd1.Parameters.Add(para1);

        //        SqlParameter para2 = new SqlParameter()
        //        {
        //            ParameterName = @"Floor",
        //            Value =txtfloor.Text

        //        };

        //        cmd1.Parameters.Add(para2);

        //     SqlParameter para3 = new SqlParameter()
        //        {
        //            ParameterName = @"S_RegiNo",
        //            Value = txtregino.Text

        //        };

        //        cmd1.Parameters.Add(para3);


        //        SqlParameter para4 = new SqlParameter()
        //        {
        //            ParameterName = @"S_Name",
        //            Value =txtshopname.Text

        //        };

        //        cmd1.Parameters.Add(para4);

        //        SqlParameter para5 = new SqlParameter()
        //        {
        //            ParameterName = @"S_OwnerName",
        //            Value =txtshopownername.Text

        //        };

        //        cmd1.Parameters.Add(para5);

        //        SqlParameter para6 = new SqlParameter()
        //        {
        //            ParameterName = @"S_Category",
        //            Value = txtshopcategory.Text

        //        };

        //        cmd1.Parameters.Add(para6);

        //        SqlParameter para7 = new SqlParameter()
        //        {
        //            ParameterName = @"S_Contactno",
        //            Value = txtcontactno.Text

        //        };

        //        cmd1.Parameters.Add(para7);

        //        SqlParameter para8 = new SqlParameter()
        //        {
        //            ParameterName = @"S_Email",
        //            Value =txtemailid.Text

        //        };

        //        cmd1.Parameters.Add(para8);

        //        SqlParameter para9 = new SqlParameter()
        //        {
        //            ParameterName = @"S_UserName",
        //            Value = txtusername.Text

        //        };

        //        cmd1.Parameters.Add(para9);

        //        SqlParameter para10 = new SqlParameter()
        //        {
        //            ParameterName = @"S_Password",
        //            Value = txtpassword.Text

        //        };

        //        cmd1.Parameters.Add(para10);


        //        SqlParameter para11 = new SqlParameter()
        //        {
        //            ParameterName = @"M_City",
        //            Value = DropDownList1.SelectedItem.ToString()

        //        };


        //        cmd1.Parameters.Add(para11);



        //        SqlParameter para12 = new SqlParameter()
        //        {
        //            ParameterName = @"M_Area",
        //            Value =txtarea.Text

        //        };

        //        cmd1.Parameters.Add(para12);

        //     SqlParameter para13 = new SqlParameter()
        //        {
        //            ParameterName = @"S_Status",
        //            Value ="Active"

        //        };

        //        cmd1.Parameters.Add(para13);


        //        SqlParameter paradata = new SqlParameter()
        //        {
        //            ParameterName = @"image",
        //            Value = bytes

        //        };

        //        cmd1.Parameters.Add(paradata);
        //        con.Open();
        //        cmd1.ExecuteNonQuery();
        //        con.Close();

        //        //ba.M_Id =Convert.ToInt32(txtmallid.Text);
        //        //ba.M_City = DropDownList1.SelectedValue.ToString();
        //        //ba.M_Name = DropDownList2.SelectedItem.ToString();
        //        //ba.S_RegiNo = txtregino.Text;
        //        //ba.S_Name = txtshopname.Text;
        //        //ba.S_OwnerName = txtshopownername.Text;
        //        //ba.S_Category = txtshopcategory.Text;
        //        //ba.S_Contactno =txtcontactno.Text;
        //        //ba.S_Email = txtemailid.Text;
        //        //ba.S_UserName = txtusername.Text;
        //        //ba.S_Password = txtpassword.Text;
        //        //ba.M_Area = txtarea.Text;
        //        //ba.S_Status = "";
        //        //da.ShopRegi(ba);


        //}
        
        }

        //select city and automatically come mall name as per city..!

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("Select * from Mall_Regi where M_City='" + DropDownList1.SelectedItem + "'", con);
            SqlDataAdapter adp1 = new SqlDataAdapter();
            adp1.SelectCommand = cmd1;
            DataSet ds1 = new DataSet();
            adp1.Fill(ds1);
            DropDownList2.DataSource = ds1;
            DropDownList2.DataValueField = "M_Name";
            DropDownList2.DataTextField = "M_Name";
            DropDownList2.DataBind();
            DropDownList2.Items.Insert(0, " Select Mall Name");
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("Select * from Mall_Regi where M_Name='" + DropDownList2.SelectedItem + "'", con);
            SqlDataAdapter adp1 = new SqlDataAdapter();
            adp1.SelectCommand = cmd1;
            DataSet ds1 = new DataSet();
            adp1.Fill(ds1);
            //txtarea.Text = ds1.Tables[0].Rows[0]["M_Area"].ToString();
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("Select DISTINCT(M_City) from Mall_Regi where M_State='"+DropDownList3.SelectedItem.ToString()+"' ", con);
            SqlDataAdapter adp1 = new SqlDataAdapter();
            adp1.SelectCommand = cmd1;
            DataSet ds1 = new DataSet();
            adp1.Fill(ds1);

            DropDownList1.DataSource = ds1;
            DropDownList1.DataValueField = "M_City";
            DropDownList1.DataTextField = "M_City";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, " Select City Name");
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


                SqlCommand cmd1 = new SqlCommand("SP_shopRegi", con);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@query", "insert");

                SqlParameter para = new SqlParameter()
                {
                    ParameterName = @"State",
                    Value = DropDownList3.SelectedItem.ToString()
                };

                cmd1.Parameters.Add(para);
                SqlParameter para1 = new SqlParameter()
                {
                    ParameterName = @"M_Name",
                    Value = DropDownList2.SelectedItem.ToString()



                };

                cmd1.Parameters.Add(para1);

                SqlParameter para2 = new SqlParameter()
                {
                    ParameterName = @"Floor",
                    Value = txtfloor.Text

                };

                cmd1.Parameters.Add(para2);

                SqlParameter para3 = new SqlParameter()
                {
                    ParameterName = @"S_RegiNo",
                    Value = txtregino.Text

                };

                cmd1.Parameters.Add(para3);


                SqlParameter para4 = new SqlParameter()
                {
                    ParameterName = @"S_Name",
                    Value = txtshopname.Text

                };

                cmd1.Parameters.Add(para4);

                SqlParameter para5 = new SqlParameter()
                {
                    ParameterName = @"S_OwnerName",
                    Value = txtshopownername.Text

                };

                cmd1.Parameters.Add(para5);

                SqlParameter para6 = new SqlParameter()
                {
                    ParameterName = @"S_Category",
                    Value = txtshopcategory.Text

                };

                cmd1.Parameters.Add(para6);

                SqlParameter para7 = new SqlParameter()
                {
                    ParameterName = @"S_Contactno",
                    Value = txtcontactno.Text

                };

                cmd1.Parameters.Add(para7);

                SqlParameter para8 = new SqlParameter()
                {
                    ParameterName = @"S_Email",
                    Value = txtemailid.Text

                };

                cmd1.Parameters.Add(para8);

                SqlParameter para9 = new SqlParameter()
                {
                    ParameterName = @"S_UserName",
                    Value = txtusername.Text

                };

                cmd1.Parameters.Add(para9);

                SqlParameter para10 = new SqlParameter()
                {
                    ParameterName = @"S_Password",
                    Value = txtpassword.Text

                };

                cmd1.Parameters.Add(para10);


                SqlParameter para11 = new SqlParameter()
                {
                    ParameterName = @"M_City",
                    Value = DropDownList1.SelectedItem.ToString()

                };


                cmd1.Parameters.Add(para11);



                SqlParameter para12 = new SqlParameter()
                {
                    ParameterName = @"M_Area",
                    Value = txtarea.Text

                };

                cmd1.Parameters.Add(para12);

                SqlParameter para13 = new SqlParameter()
                {
                    ParameterName = @"S_Status",
                    Value = "Active"

                };

                cmd1.Parameters.Add(para13);


                SqlParameter paradata = new SqlParameter()
                {
                    ParameterName = @"image",
                    Value = bytes

                };

                cmd1.Parameters.Add(paradata);
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();

                //ba.M_Id =Convert.ToInt32(txtmallid.Text);
                //ba.M_City = DropDownList1.SelectedValue.ToString();
                //ba.M_Name = DropDownList2.SelectedItem.ToString();
                //ba.S_RegiNo = txtregino.Text;
                //ba.S_Name = txtshopname.Text;
                //ba.S_OwnerName = txtshopownername.Text;
                //ba.S_Category = txtshopcategory.Text;
                //ba.S_Contactno =txtcontactno.Text;
                //ba.S_Email = txtemailid.Text;
                //ba.S_UserName = txtusername.Text;
                //ba.S_Password = txtpassword.Text;
                //ba.M_Area = txtarea.Text;
                //ba.S_Status = "";
                //da.ShopRegi(ba);


            }
        }
    }
}