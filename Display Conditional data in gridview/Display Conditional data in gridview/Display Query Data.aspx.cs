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
            string query = "SELECT * FROM form WHERE Age<'" + Age.Text+"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
                lbl.Text = "Search Successfull";
            }
            else
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
                lbl.Text = "No such Name found";
            }
        }
    }
}