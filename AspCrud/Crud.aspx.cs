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

    public partial class Crud : System.Web.UI.Page
    {
        string constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            populate();
        }

        protected void btn_logout_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void btn_create_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("sp_insert", con);
            con.Open();
            cmd.Parameters.AddWithValue("@Name",txt_name.Text);
            cmd.Parameters.AddWithValue("@Degree",txt_degree.Text);
            cmd.Parameters.AddWithValue("@Place",txt_place.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Response.Write("Data Inserted Successfully");
            }
            else
            {
                Response.Write("Date Insertion Failed");
            }
            con.Close();
            populate();
        }

        protected void btn_clear_Click(object sender, EventArgs e)
        {
            txt_id.Text = string.Empty;
            txt_name.Text = string.Empty;
            txt_degree.Text = string.Empty;
            txt_place.Text = string.Empty;  
        }

       public void populate()
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_fetch", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            gv_select.DataSource = ds.Tables[0];
            gv_select.DataBind();
            con.Close();
        }

        protected void gv_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_id.Text = gv_select.SelectedRow.Cells[0].Text.ToString();
            txt_name.Text = gv_select.SelectedRow.Cells[1].Text.ToString();
            txt_degree.Text = gv_select.SelectedRow.Cells[2].Text.ToString();
            txt_place.Text = gv_select.SelectedRow.Cells[3].Text.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("sp_delete", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@Id", txt_id.Text);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Response.Write("Data Deleted Successfully");
            }
            else
            {
                Response.Write("Date Deletion Failed");
            }
            con.Close();
            populate();
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("sp_update", con);
            cmd.CommandType= CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@Id", txt_id.Text);
            cmd.Parameters.AddWithValue("@Name", txt_name.Text);
            cmd.Parameters.AddWithValue("@Degree", txt_degree.Text);
            cmd.Parameters.AddWithValue("@Place", txt_place.Text);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Response.Write("Data Updated Successfully");
            }
            else
            {
                Response.Write("Date Updation Failed");
            }
            con.Close();
            populate();
        }
    }
}