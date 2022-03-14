using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace Insert
{
    public partial class insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            string sqlstr = "data source=SAIKAT-SANIL\\SQL2019;initial catalog=B15;integrated security=true;";
            SqlConnection conn = new SqlConnection(sqlstr);
            conn.Open();

            string query = "INSERT INTO NewForm VALUES('" + Name.Text + "','" + Phone.Text + "','" + genderBtn.SelectedValue + "')";
            SqlCommand comd = new SqlCommand(query, conn);
            int i = comd.ExecuteNonQuery();
            if (i > 0)
            {
                lbl.Text = "Successfully Registered";
            }
            else
            {
                lbl.Text = "Registration failed";
            }
        }
    }
}