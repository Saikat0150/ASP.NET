using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Display_Conditional_data_in_gridview
{
    public partial class Display_Query_Data : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            string str = "data source=SAIKAT-SANIL\\SQL2019;initial catalog=B15;integrated security=true";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string query = "SELECT * FROM form WHERE Name='" + Name.Text+"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
        }
    }
}