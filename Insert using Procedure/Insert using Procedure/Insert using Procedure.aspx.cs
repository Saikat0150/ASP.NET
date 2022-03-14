using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Insert_using_Procedure
{
    public partial class Insert_using_Procedure : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            string sqlstr = "data source=SAIKAT-SANIL\\SQL2019;initial catalog=B15;integrated security=true;";
            SqlConnection conn = new SqlConnection(sqlstr);
            SqlCommand cmd = new SqlCommand("dbo.InsertValue", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("Name", Name.Text);

            cmd.Parameters.AddWithValue("Phone", Phone.Text);

            cmd.Parameters.AddWithValue("Gender", genderBtn.SelectedValue);

            conn.Open();

            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                lbl.Text = "Successfully Registered";
            }
            else
            {
                lbl.Text = "Registration failed";
            }
            conn.Close();
        }
    }
}