using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspCrud
{
    public partial class Registration : System.Web.UI.Page
    {
        string constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_register", con);
                cmd.Parameters.AddWithValue("@Name", txt_name.Text);
                cmd.Parameters.AddWithValue("@Email", txt_email.Text);
                cmd.Parameters.AddWithValue("@Mobile", txt_mobile.Text);
                cmd.Parameters.AddWithValue("@Gender", rb_gender.Text);
                cmd.Parameters.AddWithValue("@Username", txt_username.Text);
                cmd.Parameters.AddWithValue("@Password", txt_password.Text);
                cmd.CommandType = CommandType.StoredProcedure;
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    Response.Write("Registered Successfully");
                }
                else
                {
                    Response.Write("Registration Failed");
                }
                con.Close();
            }
            catch(Exception Ex)
            {
                Response.Write(Ex.Message);
            }
            
        }

        protected void btn_Login_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}