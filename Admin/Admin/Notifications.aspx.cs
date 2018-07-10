using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Admin
{
    public partial class Notifications : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(Connection.Conn);
        string filename,path;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           HttpPostedFile postfile = FileUpload1.PostedFile;
            string filename = Path.GetFileName(postfile.FileName);
            string fileExtension = Path.GetExtension(filename);
            int fileSize = postfile.ContentLength;

            DateTime expirydate, currentdate;
            expirydate = Convert.ToDateTime(DateTime.Now);
            currentdate = expirydate.AddDays(7);

            if (fileExtension.ToLower() == ".jpg" || fileExtension.ToLower() == ".gif" || fileExtension.ToLower() == ".png" || fileExtension.ToLower() == ".bmp")
            {


                Stream stream = postfile.InputStream;
                BinaryReader binaryReader = new BinaryReader(stream);
                Byte[] bytes = binaryReader.ReadBytes((int)stream.Length);


                SqlCommand cmd1 = new SqlCommand("sp_notification", con);
                cmd1.CommandType = CommandType.StoredProcedure;
                SqlParameter para = new SqlParameter()
                {
                    ParameterName = @"Title",
                    Value = txtname.Text

                };

                cmd1.Parameters.Add(para);

               

               

                SqlParameter paradata = new SqlParameter()
                {
                    ParameterName = @"Descriptions",
                    Value = txtdes.Text

                };

                cmd1.Parameters.Add(paradata);

                SqlParameter paradata1 = new SqlParameter()
                {
                    ParameterName = @"Image",
                    Value = bytes

                };

                cmd1.Parameters.Add(paradata1);

                SqlParameter paradata2 = new SqlParameter()
                {
                    ParameterName = @"Price",
                    Value = txtprice.Text

                };

                cmd1.Parameters.Add(paradata2);

                SqlParameter paradata3 = new SqlParameter()
                {
                    ParameterName = @"Offer_Price",
                    Value = txtpriceoffer.Text

                };

                cmd1.Parameters.Add(paradata3);

                SqlParameter paradata4 = new SqlParameter()
                {
                    ParameterName = @"Expiry_Date",
                    Value =Convert.ToDateTime(currentdate)

                };

                cmd1.Parameters.Add(paradata4);
               
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();



            }
        }
    }
        }
    
