using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;
/// <summary>
/// Summary description for DAL
/// </summary>
public class DAL
{
    SqlConnection con = new SqlConnection(Connection.connection);
    //SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["conn"].ConnectionString);

    // user Registrations Mthode

    public void UserRegis(BAL ba)
    {
        SqlCommand cmd = new SqlCommand("SP_UserRegi", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@qurey", "insert");
        cmd.Parameters.AddWithValue("@Name", ba.Name);
        cmd.Parameters.AddWithValue("@EmailId", ba.Email);
        cmd.Parameters.AddWithValue("@Pass", ba.Pass);
        cmd.Parameters.AddWithValue("@Confirm_pass", ba.Confirm_pass);
        cmd.Parameters.AddWithValue("@Gender", ba.Gender);
        cmd.Parameters.AddWithValue("@Contact_no", ba.Contact_No);
        cmd.Parameters.AddWithValue("@Address", ba.Address);
        cmd.Parameters.AddWithValue("@City", ba.City);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();

    }

    // Login for user method

    public DataTable userlogin(BAL ba)
    {
        SqlDataAdapter adp = new SqlDataAdapter("select * from User_Regi where EmailId='" + ba.Email + "' and Pass='" + ba.Pass + "'", con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        return dt;

    }
}