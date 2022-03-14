using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Retriving_full_dataset
{
    public partial class Retriving_full_dataSet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmployeeData();
        }
        public void EmployeeData()
        {
            string str = "data source=SAIKAT-SANIL\\SQL2019;initial catalog=B15;integrated security=true";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            string query = "select * from Employee1";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}