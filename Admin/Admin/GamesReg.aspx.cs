using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.IO;
namespace Admin
{
    public partial class GamesReg : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(Connection.Conn);
        string filename, path;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                selectCountry();
            }
        }

        // coutnry code
        public void selectCountry()
        {
            SqlCommand cmd = new SqlCommand("select * from Country", con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DropDownList1.DataSource = ds;
            DropDownList1.DataTextField = "C_Name";
            DropDownList1.DataValueField = "C_Id";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, " Select Country");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from State where C_Id='" + Convert.ToInt32(DropDownList1.SelectedItem.Value) + "'", con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DropDownList2.DataSource = ds;
            DropDownList2.DataTextField = "S_Name";
            DropDownList2.DataValueField = "S_Id";
            DropDownList2.DataBind();
            DropDownList2.Items.Insert(0, " Select State");

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from City where S_Id='" + Convert.ToInt32(DropDownList2.SelectedItem.Value) + "'", con);
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DropDownList3.DataSource = ds;
            DropDownList3.DataValueField = "CT_Id";
            DropDownList3.DataTextField = "CT_Name";
            DropDownList3.DataBind();
            DropDownList3.Items.Insert(0, " Select City");

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


                SqlCommand cmd1 = new SqlCommand("sp_game", con);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@query", "insert");

                SqlParameter para = new SqlParameter()
                {
                    ParameterName = @"M_Name",
                    Value = txtmallname.Text

                };

                cmd1.Parameters.Add(para);

                SqlParameter para1 = new SqlParameter()
                {
                    ParameterName = @"S_Name",
                    Value = txtshopname.Text

                };

                cmd1.Parameters.Add(para1);

                SqlParameter para2 = new SqlParameter()
                {
                    ParameterName = @"G_name",
                    Value = txtgamename.Text

                };

                cmd1.Parameters.Add(para2);

                SqlParameter para3 = new SqlParameter()
                {
                    ParameterName = @"G_type",
                    Value = txtgametype.Text

                };

                cmd1.Parameters.Add(para3);

                SqlParameter para4 = new SqlParameter()
                {
                    ParameterName = @"Price",
                    Value = txtprice.Text

                };

                cmd1.Parameters.Add(para4);

                SqlParameter para5 = new SqlParameter()
                {
                    ParameterName = @"timeing",
                    Value = txttimeing.Text

                };

                cmd1.Parameters.Add(para5);

                SqlParameter para6 = new SqlParameter()
                {
                    ParameterName = @"country",
                    Value = DropDownList1.SelectedItem.ToString()

                };

                cmd1.Parameters.Add(para6);

                SqlParameter para7 = new SqlParameter()
                {
                    ParameterName = @"state",
                    Value = DropDownList2.SelectedItem.ToString()

                };

                cmd1.Parameters.Add(para7);


                SqlParameter para8 = new SqlParameter()
                {
                    ParameterName = @"City",
                    Value = DropDownList3.SelectedItem.ToString()

                };


                cmd1.Parameters.Add(para8);

                SqlParameter para9 = new SqlParameter()
               {
                   ParameterName = @"area",
                   Value = txtarea.Text

               };


                cmd1.Parameters.Add(para9);



                SqlParameter paradata = new SqlParameter()
                {
                    ParameterName = @"image",
                    Value = bytes

                };

                cmd1.Parameters.Add(paradata);
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();

            }
        }
    }
}