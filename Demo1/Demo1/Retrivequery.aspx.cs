using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Demo1
{
    public partial class Retrivequery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cnstr = "data source=SAIKAT-SANIL\\SQL2019;initial catalog=B15;integrated security=true;";
            SqlConnection cn = new SqlConnection(cnstr);
            string sqlstr = "select * from student";
            SqlCommand cmd = new SqlCommand(sqlstr, cn);
            SqlDataReader dr;
            cn.Open();
            l1Data.Text = "Database Connected.";
            
            dr = cmd.ExecuteReader();
            while (dr.Read() == true)
            {
                l1Data.Text = l1Data.Text + dr.GetValue(0) + " " + dr.GetValue(1) + " " + dr.GetValue(2)+ " " + dr.GetValue(3);
            }
            dr.Close();
            cn.Close();
            l1Data.Text = l1Data.Text + "\n Database Disconnected";

        }
    }
}