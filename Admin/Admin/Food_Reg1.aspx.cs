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
    public partial class Food_Reg1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(Connection.Conn);
        string filename, path;
        protected void Page_Load(object sender, EventArgs e)
        {

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


                SqlCommand cmd1 = new SqlCommand("SP_FoodRegi", con);
                cmd1.CommandType = CommandType.StoredProcedure;
                SqlParameter para = new SqlParameter()
                {
                    ParameterName = @"name",
                    Value = txtfoddItem.Text

                };

                cmd1.Parameters.Add(para);

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