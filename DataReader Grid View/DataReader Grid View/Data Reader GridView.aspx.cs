using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace DataReader_Grid_View
{
    public partial class Data_Reader_GridView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetEmployee();
        }
        public void GetEmployee()
        {
            string str = "data source=SAIKAT-SANIL\\SQL2019;initial catalog=B15;integrated security=true";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string sqlstr = "SELECT * FROM Employee1";
            SqlCommand comd = new SqlCommand(sqlstr, conn);
            SqlDataReader dr;
            dr = comd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
        }
    }
}