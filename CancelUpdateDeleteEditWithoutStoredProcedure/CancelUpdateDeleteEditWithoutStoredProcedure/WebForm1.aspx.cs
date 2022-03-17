using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Web.UI.WebControls;

namespace CancelUpdateDeleteEditWithoutStoredProcedure
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.BindGrid();
            }
        }
        private void BindGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            string query = "SELECT * FROM Employee2";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using(SqlDataAdapter sda=new SqlDataAdapter(query, con))
                {
                    using(DataTable dt=new DataTable())
                    {
                        sda.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                }
            }
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];
            int ID = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);
            string Name = (row.FindControl("txtName") as TextBox).Text;
            string Mobile = (row.FindControl("txtMobile") as TextBox).Text;
            int Age = Convert.ToInt32((row.FindControl("txtAge") as TextBox).Text);
            string Gender = (row.FindControl("txtGender") as TextBox).Text;
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            string query = "UPDATE Employee2 SET Name=@Name,Mobile=@Mobile,Age=@Age,Gender=@Gender WHERE ID=@ID";
            using(SqlConnection con=new SqlConnection(constr))
            {
                using(SqlCommand cmd=new SqlCommand(query))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Mobile", Mobile);
                    cmd.Parameters.AddWithValue("@Age", Age);
                    cmd.Parameters.AddWithValue("@Gender", Gender);
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            GridView1.EditIndex = -1;
            this.BindGrid();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            this.BindGrid();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int ID = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            string query = "DELETE FROM Employee2 WHERE ID=@ID";
            using(SqlConnection con=new SqlConnection(constr))
            {
                using(SqlCommand cmd=new SqlCommand(query))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            this.BindGrid();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            this.BindGrid();
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            string query = "Insert into Employee2 values (@0,@1,@2,@3)";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("0", name.Text);
                    cmd.Parameters.AddWithValue("1", mob.Text);
                    cmd.Parameters.AddWithValue("2", age.Text);
                    cmd.Parameters.AddWithValue("3", gender.SelectedValue);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        Registered.Text = "Successfully Registered";
                    }
                    catch (Exception ex)
                    {
                        Registered.Text = "Not Registered Due to Invalid Input";
                    }



                    con.Close();

                }
            }
            this.BindGrid();
        }
    }
}