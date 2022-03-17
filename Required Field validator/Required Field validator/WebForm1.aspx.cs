using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Required_Field_validator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string sqlstr = "data source=SAIKAT-SANIL\\SQL2019;initial catalog=B15;integrated security=true;";
            SqlConnection conn = new SqlConnection(sqlstr);
            conn.Open();

            string query = "INSERT INTO Form1 VALUES('" + Name.Text + "','" + Mobile.Text + "','" + Age.Text + "','" + Gender.SelectedValue + "','" + Email.Text + "','" + Password.Text + "')";
            SqlCommand comd = new SqlCommand(query, conn);
            int i = comd.ExecuteNonQuery();
            if (i > 0)
            {
                Registered.Text = "Successfully Registered";
            }
            else
            {
                Registered.Text = "Registration failed";
            }
        }
    }
}