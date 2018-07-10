using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.IO;
using System.Data;
using System.Data.SqlClient;
public partial class Kidimage : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(Connection.connection);
    string filename, path;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        //this.ClientScript.RegisterClientScriptBlock(this.GetType(), "Close", "javascript:Window.close", true);
        Response.Redirect("Kids_Talent.aspx");
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


                SqlCommand cmd1 = new SqlCommand("SP_UploadImg", con);
                cmd1.CommandType = CommandType.StoredProcedure;
                SqlParameter para = new SqlParameter()
                {
                    ParameterName = @"Name",
                    Value = txtiname.Text

                };

                cmd1.Parameters.Add(para);

                SqlParameter para1 = new SqlParameter()
                {
                    ParameterName = @"ContentType",
                    Value = txtimgname.Text

                };
                cmd1.Parameters.Add(para1);
                SqlParameter paradata = new SqlParameter()
                {
                    ParameterName = @"Data",
                    Value = bytes

                };

                cmd1.Parameters.Add(paradata);
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();
                
            }
        }
    
    protected void Button2_Click(object sender, EventArgs e)
    {

        using (BinaryReader br = new BinaryReader(FileUpload1.PostedFile.InputStream))
        {
            byte[] bytes = br.ReadBytes((int)FileUpload1.PostedFile.InputStream.Length);
            
         string name=  Path.GetFileName(FileUpload1.PostedFile.FileName);
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "insert into Kids_Video(Name, ContentType, Data) values (@Name, @ContentType, @Data)";
                    cmd.Parameters.AddWithValue("@Name",txtname.Text);
                    cmd.Parameters.AddWithValue("@ContentType", "video/mp4");
                    cmd.Parameters.AddWithValue("@Data", bytes);
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                   
                   
                }
            }
        
       // Response.Redirect(Request.Url.AbsoluteUri);
        //ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", " alert('Your Video has been Submitted Successfully..............');", true);
        Response.Write("<script>alert('Your Video has been Submitted Successfully')</script>");
    }
    
}