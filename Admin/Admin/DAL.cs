using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace Admin
{
    public class DAL
    {
        SqlConnection con=new SqlConnection(Connection.Conn);
        public void MallInsert(BAL ba)
        {
            //Mall Insert Code

            SqlCommand cmd = new SqlCommand("SP_MallRegi");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@query", "insert");
            cmd.Parameters.AddWithValue("@M_Name", ba.M_Name);
            cmd.Parameters.AddWithValue("@M_OwnerName", ba.M_OwnerName);
            cmd.Parameters.AddWithValue("@M_MbNo",ba.M_MbNo);
            cmd.Parameters.AddWithValue("@M_EmailId", ba.M_EmailId);
            cmd.Parameters.AddWithValue("@M_UserName", ba.M_UserName);
            cmd.Parameters.AddWithValue("@M_Password", ba.M_Password);
            cmd.Parameters.AddWithValue("@M_NoOfFloors", ba.M_NoOfFloors);
            cmd.Parameters.AddWithValue("@M_NoOfShops", ba.M_NoOfShops);

            cmd.Parameters.AddWithValue("@M_Country", ba.M_Country);
            cmd.Parameters.AddWithValue("@M_State", ba.M_State);
            cmd.Parameters.AddWithValue("@M_City", ba.M_City);
            cmd.Parameters.AddWithValue("@M_Status", ba.M_Status);
            cmd.Parameters.AddWithValue("@M_Area", ba.M_Area);
           


            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

      
        //login Code
        public DataSet LoginForm(BAL ba)
        {
            SqlCommand cmd = new SqlCommand("select * from Login where A_username='" +ba.L_Email + "' and A_password='" + ba.L_pass + "' ", con);
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }
        //Productinsert code

        public void ProductsInsert(BAL ba)
        {
            SqlCommand cmd = new SqlCommand("insert into Products values('"+ba.P_Name+"','"+ba.PB_Brand_Name+"','"+ba.PC_category_name+"')",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void ShopRegi(BAL ba)
        {
            SqlCommand cmd = new SqlCommand("SP_ShopRegi",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@query", "insert");

            cmd.Parameters.AddWithValue("@M_Id",Convert.ToInt32(ba.M_Id));
            cmd.Parameters.AddWithValue("@M_Name", ba.M_Name);

            cmd.Parameters.AddWithValue("@S_RegiNo", ba.S_RegiNo);
            cmd.Parameters.AddWithValue("@S_Name", ba.S_Name);
            cmd.Parameters.AddWithValue("@S_OwnerName", ba.S_OwnerName);
            cmd.Parameters.AddWithValue("@S_Category", ba.S_Category);
            cmd.Parameters.AddWithValue("@S_Contactno", ba.S_Contactno);

            cmd.Parameters.AddWithValue("@S_Email", ba.S_Email);

            cmd.Parameters.AddWithValue("@S_UserName", ba.S_UserName);
            cmd.Parameters.AddWithValue("@S_Password", ba.S_Password);
            //cmd.Parameters.AddWithValue("@S_Password", ba.S_Password);
            cmd.Parameters.AddWithValue("@M_City", ba.M_City);
            cmd.Parameters.AddWithValue("@M_Area", ba.M_Area);
            cmd.Parameters.AddWithValue("@S_Status",ba.S_Status);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            

        }

        public void ProductRegistration(BAL ba)
        {
            SqlCommand cmd = new SqlCommand("SP_ProductRegistration", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@query", "insert");
            cmd.Parameters.AddWithValue("@M_Name",ba.M_Name);
            cmd.Parameters.AddWithValue("@S_Name",ba.S_Name);
            cmd.Parameters.AddWithValue("@PC_category_name",ba.PC_category_name);
            cmd.Parameters.AddWithValue("@PB_Brand_Name",ba.PB_Brand_Name);
            cmd.Parameters.AddWithValue("@P_Name", ba.P_Name);
            cmd.Parameters.AddWithValue("@PR_Type", ba.PR_Type);
            cmd.Parameters.AddWithValue("@PR_Price", ba.PR_Price);
          
            cmd.Parameters.AddWithValue("@PR_OfferPrice", ba.PR_OfferPrice);
              cmd.Parameters.AddWithValue("@PR_Image", ba.PR_Image);
             con.Open();
            cmd.ExecuteNonQuery();
            
            con.Close();

        }

        public void FoodShopRegi(BAL ba)
        {
            SqlCommand cmd = new SqlCommand("SP_ShopfoodRegi", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ShopOwnerName",ba.S_OwnerName);
            cmd.Parameters.AddWithValue("@MallName", ba.M_Name);
            cmd.Parameters.AddWithValue("@ShopName",ba.S_Name);
            cmd.Parameters.AddWithValue("@ContactNumber",ba.S_Contactno );           
            cmd.Parameters.AddWithValue("@EmailId", ba.S_Email);
            cmd.Parameters.AddWithValue("@UserName", ba.S_UserName);
            cmd.Parameters.AddWithValue("@Password", ba.S_Password);
            cmd.Parameters.AddWithValue("@State", ba.M_State);
            cmd.Parameters.AddWithValue("@City", ba.M_City);
            cmd.Parameters.AddWithValue("@Area", ba.M_Area);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        }
    }
