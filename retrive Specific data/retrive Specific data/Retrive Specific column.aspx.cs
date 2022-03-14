using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace retrive_Specific_data
{
    public partial class Retrive_Specific_column : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string str = "data source=SAIKAT-SANIL\\SQL2019;initial catalog=B15;integrated security=true;";
            SqlConnection conn = new SqlConnection(str);
            string sqlstr = "select * from Employee1";
            SqlCommand comd = new SqlCommand(sqlstr, conn);
            SqlDataReader dr;
            conn.Open();
            label1data.Text = "Database Connected";
            dr = comd.ExecuteReader();
            while (dr.Read() == true)
            {
                label1data.Text = label1data.Text + " " + dr.GetValue(1) + " " + dr.GetValue(3) + " ";
            }
            dr.Close();
            conn.Close();
            label1data.Text = label1data.Text + " Database Disconnected";
        }
    }
}