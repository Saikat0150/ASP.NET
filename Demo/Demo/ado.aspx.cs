using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Demo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClick(object sender, EventArgs e)
        {
            string cnstr = "data source=SAIKAT-SANIL\\SQL2019; initial catalog=B15; integrated security=true;";
            SqlConnection cn = new SqlConnection(cnstr);
            cn.Open();
            lblResult.Text = "Successfully Connected";
            cn.Close();
        }
    }
}