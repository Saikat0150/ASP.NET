using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
namespace UsingConnectionStrings
{
    public partial class Find_Student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void search_Click1(object sender, EventArgs e)
        {
            string source = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            //string source = "data source=DESKTOP-NARUTO\\SQL2019;initial catalog=Training2;integrated security=true;";
            SqlConnection conn = new SqlConnection(source);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from form Where name = '" + name.Text + "'", conn);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                reader.Close();
                SqlDataReader rd = cmd.ExecuteReader();
                Goutput.DataSource = rd;
                Goutput.DataBind();
                result.Text = "Search Successful";
            }
            else
            {
                result.Text = "No Such Name Exist in Database";
            }
            conn.Close();
        }
    }
}