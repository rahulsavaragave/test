using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class ViewInfo : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(Connection.connection);
    public string str;
    public int i, j;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {

            if (Session["city"] == null)
            {
                SqlCommand cmd = new SqlCommand("select * from ProductRegi where PR_Id='" + Session["id"] + "' ", con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                Label1.Text = ds.Tables[0].Rows[0]["P_Name"].ToString();
                Label2.Text = ds.Tables[0].Rows[0]["PB_Brand_Name"].ToString();
                Label3.Text = ds.Tables[0].Rows[0]["PR_Price"].ToString();
                Label4.Text = ds.Tables[0].Rows[0]["PR_OfferPrice"].ToString();
                Label5.Text = ds.Tables[0].Rows[0]["PR_Description"].ToString();

                UpdatePanel2.Visible = false;
                UpdatePanel1.Visible = true;
                DataList1.DataSource = ds;
                DataList1.DataBind();
            }
            else
            {
                //M_City='" + Session["city"] + "' and 
                SqlCommand cmd = new SqlCommand("select * from ProductRegi where PR_Id='" + Session["id"] + "' and  M_Name='" + Session["Mall"] + "'", con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                Label1.Text = ds.Tables[0].Rows[0]["P_Name"].ToString();
                Label2.Text = ds.Tables[0].Rows[0]["PB_Brand_Name"].ToString();
                Label3.Text = ds.Tables[0].Rows[0]["PR_Price"].ToString();
                Label4.Text = ds.Tables[0].Rows[0]["PR_OfferPrice"].ToString();
                Label5.Text = ds.Tables[0].Rows[0]["PR_Description"].ToString();

                UpdatePanel2.Visible = false;
                UpdatePanel1.Visible = true;
                DataList1.DataSource = ds;
                DataList1.DataBind();

            }

        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (Session["city"] == null)
        {
            if (DropDownList1.SelectedItem.ToString() == "Min" && DropDownList2.SelectedValue.ToString() == "2000+")
            {
                i = 500;
                j = 4000;
                SqlCommand cmd = new SqlCommand("select * from ProductRegi where PR_Price BETWEEN'" + i + "' And '" + j + "' and P_Name='" + Label1.Text + "' ", con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                UpdatePanel1.Visible = false;
                UpdatePanel2.Visible = true;
                DataList2.DataSource = ds;
                DataList2.DataBind();
                con.Close();

            }
            else
            {
                if (DropDownList2.SelectedItem.ToString() == "2000+")
                {
                    j = 4000;
                    SqlCommand cmd = new SqlCommand("select * from ProductRegi where PR_Price BETWEEN'" + DropDownList1.SelectedValue.ToString() + "' And '" + j + "' and P_Name='" + Label1.Text + "' ", con);
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    UpdatePanel1.Visible = false;
                    UpdatePanel2.Visible = true;
                    DataList2.DataSource = ds;
                    DataList2.DataBind();
                    con.Close();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("select * from ProductRegi where PR_Price BETWEEN'" + DropDownList1.SelectedValue.ToString() + "' And '" + DropDownList1.SelectedValue.ToString() + "' and P_Name='" + Label1.Text + "' ", con);
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    UpdatePanel1.Visible = false;
                    UpdatePanel2.Visible = true;
                    DataList2.DataSource = ds;
                    DataList2.DataBind();
                    con.Close();
                }
            }


        }
        else
        {
            if (DropDownList1.SelectedItem.ToString() == "Min" && DropDownList2.SelectedValue.ToString() == "2000+")
            {
                i = 500;
                j = 4000;
                SqlCommand cmd = new SqlCommand("select * from ProductRegi where PR_Price BETWEEN'" + i + "' And '" + j + "' and P_Name='" + Label1.Text + "' and  M_City='" + Session["city"] + "' and  M_Name='" + Session["Mall"] + "' ", con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                UpdatePanel1.Visible = false;
                UpdatePanel2.Visible = true;
                DataList2.DataSource = ds;
                DataList2.DataBind();
                con.Close();

            }
            else
            {
                if (DropDownList2.SelectedItem.ToString() == "2000+")
                {
                    j = 4000;
                    SqlCommand cmd = new SqlCommand("select * from ProductRegi where PR_Price BETWEEN'" + DropDownList1.SelectedValue.ToString() + "' And '" + j + "' and P_Name='" + Label1.Text + "' and  M_City='" + Session["city"] + "' and  M_Name='" + Session["Mall"] + "' ", con);
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    UpdatePanel1.Visible = false;
                    UpdatePanel2.Visible = true;
                    DataList2.DataSource = ds;
                    DataList2.DataBind();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("select * from ProductRegi where PR_Price BETWEEN'" + DropDownList1.SelectedValue.ToString() + "' And '" + DropDownList1.SelectedValue.ToString() + "' and P_Name='" + Label1.Text + "' and  M_City='" + Session["city"] + "' and  M_Name='" + Session["Mall"] + "' ", con);
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    UpdatePanel1.Visible = false;
                    UpdatePanel2.Visible = true;
                    DataList2.DataSource = ds;
                    DataList2.DataBind();
                    con.Close();
                }
            }

        }
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (Session["city"] == null)
        {
            if (DropDownList1.SelectedItem.ToString() == "Min" && DropDownList2.SelectedValue.ToString() == "2000+")
            {
                i = 500;
                j = 4000;
                SqlCommand cmd = new SqlCommand("select * from ProductRegi where PR_Price BETWEEN'" + i + "' And '" + j + "' and P_Name='" + Label1.Text + "' ", con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                UpdatePanel1.Visible = false;
                UpdatePanel2.Visible = true;
                DataList2.DataSource = ds;
                DataList2.DataBind();
                con.Close();

            }
            else
            {
                if (DropDownList1.SelectedItem.ToString() == "Min")
                {
                    i = 500;
                    SqlCommand cmd = new SqlCommand("select * from ProductRegi where PR_Price BETWEEN'" + i + "' And '" + DropDownList2.SelectedValue.ToString() + "' and P_Name='" + Label1.Text + "' ", con);
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    UpdatePanel1.Visible = false;
                    UpdatePanel2.Visible = true;
                    DataList2.DataSource = ds;
                    DataList2.DataBind();
                    con.Close();
                }
                else
                {
                    if (DropDownList2.SelectedItem.ToString() == "2000+")
                    {
                        j = 4000;
                        SqlCommand cmd = new SqlCommand("select * from ProductRegi where PR_Price BETWEEN'" + DropDownList1.SelectedValue.ToString() + "' And '" + j + "' and P_Name='" + Label1.Text + "' ", con);
                        con.Open();
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        UpdatePanel1.Visible = false;
                        UpdatePanel2.Visible = true;
                        DataList2.DataSource = ds;
                        DataList2.DataBind();
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("select * from ProductRegi where PR_Price BETWEEN'" + DropDownList1.SelectedValue.ToString() + "' And '" + DropDownList2.SelectedValue.ToString() + "' and P_Name='" + Label1.Text + "' ", con);
                        con.Open();
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        UpdatePanel1.Visible = false;
                        UpdatePanel2.Visible = true;
                        DataList2.DataSource = ds;
                        DataList2.DataBind();
                        con.Close();
                    }
                }
            }
        }/////////
        else
        {
            if (DropDownList1.SelectedItem.ToString() == "Min" && DropDownList2.SelectedValue.ToString() == "2000+")
            {
                i = 500;
                j = 4000;
                SqlCommand cmd = new SqlCommand("select * from ProductRegi where PR_Price BETWEEN'" + i + "' And '" + j + "' and P_Name='" + Label1.Text + "' and  M_City='" + Session["city"] + "' and  M_Name='" + Session["Mall"] + "'  ", con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                UpdatePanel1.Visible = false;
                UpdatePanel2.Visible = true;
                DataList2.DataSource = ds;
                DataList2.DataBind();

            }
            else
            {
                if (DropDownList1.SelectedItem.ToString() == "Min")
                {
                    i = 500;
                    SqlCommand cmd = new SqlCommand("select * from ProductRegi where PR_Price BETWEEN'" + i + "' And '" + DropDownList2.SelectedValue.ToString() + "' and P_Name='" + Label1.Text + "' and  M_City='" + Session["city"] + "' and  M_Name='" + Session["Mall"] + "'  ", con);
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    UpdatePanel1.Visible = false;
                    UpdatePanel2.Visible = true;
                    DataList2.DataSource = ds;
                    DataList2.DataBind();
                }
                else
                {
                    if (DropDownList2.SelectedItem.ToString() == "2000+")
                    {
                        j = 4000;
                        SqlCommand cmd = new SqlCommand("select * from ProductRegi where PR_Price BETWEEN'" + DropDownList1.SelectedValue.ToString() + "' And '" + j + "' and P_Name='" + Label1.Text + "' ", con);
                       
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        UpdatePanel1.Visible = false;
                        UpdatePanel2.Visible = true;
                        DataList2.DataSource = ds;
                        DataList2.DataBind();
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("select * from ProductRegi where PR_Price BETWEEN'" + DropDownList1.SelectedValue.ToString() + "' And '" + DropDownList2.SelectedValue.ToString() + "' and P_Name='" + Label1.Text + "' and  M_City='" + Session["city"] + "' and  M_Name='" + Session["Mall"] + "'  ", con);
                       
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        UpdatePanel1.Visible = false;
                        UpdatePanel2.Visible = true;
                        DataList2.DataSource = ds;
                        DataList2.DataBind();
                    }
                }
            }
        }
    }
    protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        foreach (ListItem list in CheckBoxList1.Items)
        {
            if (list.Selected)
            //if (CheckBoxList1.SelectedItem.Selected)
            {

                SqlCommand cmd = new SqlCommand("select * from ProductRegi where PB_Brand_Name='" + CheckBoxList1.SelectedItem.ToString() + "' ", con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                UpdatePanel1.Visible = false;
                UpdatePanel2.Visible = true;
                DataList2.DataSource = ds;
                DataList2.DataBind();
                con.Close();
            }
            else
            {
               // Response.Write("<script>alert('Please Check Above Field')</script>");
            }



        }
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        LinkButton b = (LinkButton)sender;
        int i = Convert.ToInt32(b.CommandName);
        Session["id"] = i;
        Response.Redirect("~/ViewInfo.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("select * From ProductRegi where P_Name LIKE '%" + txtsearch.Text + "%' or PB_Brand_Name LIKE '%" + txtsearch.Text + "%'   ", con);

        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataSet dt = new DataSet();
        adp.Fill(dt);

        if (dt.Tables[0].Rows.Count > 0)
        {
            UpdatePanel1.Visible = false;
            UpdatePanel2.Visible = true;
            DataList2.DataSource = dt;
            DataList2.DataBind();
        }
        else
        {
            //Response.Write("Not Available");
        }
    }
}