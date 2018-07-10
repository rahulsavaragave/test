using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin
{
    public class BAL
    {
        // Mall Registration
        public int M_Id { get; set; }
        public string  M_Name      { get; set; }
        public string  M_OwnerName { get; set; }
        public decimal  M_MbNo      { get; set; }
        public string  M_EmailId   { get; set; }
        public string  M_UserName  { get; set; }
        public string  M_Password  { get; set; }
        public int     M_NoOfFloors{ get; set; }
        public int     M_NoOfShops { get; set; }
        public string  M_Country   { get; set; }
        public string  M_State     { get; set; }
        public string  M_City      { get; set; }
        public string  M_Status    { get; set; }
        public string  M_Area      { get; set; }


        //login Field
        public string L_Email { get; set; }
        public string L_pass{ get; set; }

        //Products Fields
        public int P_Id { get; set; }
        public string P_Name { get; set; }
        public string PB_Brand_Name { get; set; }
        public string PC_category_name { get; set; }

        // Shopes Registration Field
        public string S_RegiNo { get; set; }
        public string S_Name { get; set; }

        public string S_OwnerName{ get; set; }
        public string S_Category { get; set; }

        public string S_Contactno { get; set; }
        public string S_Email { get; set; }

        public string S_UserName { get; set; }
        public string S_Password{ get; set; }

        public string S_Status { get; set; }
       
        //ProductRegistration Fields


        public int PR_Id { get; set; }

        public string PR_Type { get; set; }
        public decimal PR_Price { get; set; }
       
        public decimal PR_OfferPrice { get; set; }
        public string  PR_Image { get; set; }
    }


   
}