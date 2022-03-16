using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace UsingConnectionStrings
{
    public partial class Find_Student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void search_Click(object sender, EventArgs e)
        {
            string source = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            SqlConnection conn = new SqlConnection(source);
            conn.Open();
            string query = "SELECT * FROM form WHERE Age<'" + name.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Goutput.DataSource = ds;
                Goutput.DataBind();
                lbl.Text = "Search Successfull";
            }
            else
            {
                Goutput.DataSource = ds;
                Goutput.DataBind();
                lbl.Text = "No such Name found";
            }
        }
    }
}