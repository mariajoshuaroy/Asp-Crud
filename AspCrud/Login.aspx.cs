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
    public partial class Login : System.Web.UI.Page
    {
        string constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_register_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_login", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Username",txt_username.Text);
            cmd.Parameters.AddWithValue("Password",txt_password.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            int a = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
            if (a > 0)
            {
                Response.Redirect("Crud.aspx");
            }
            else
            {
                Response.Write("Invalid User");
            }
            con.Close();
        }

        protected void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_username.Text= string.Empty;
            txt_password.Text= string.Empty;    
        }
    }
}