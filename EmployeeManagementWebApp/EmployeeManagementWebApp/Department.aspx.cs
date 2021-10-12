using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeManagementWebApp
{
    public partial class Department : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbConnection dbObj = new DbConnection();
            DataTable dtDepartmentResult = dbObj.getDepartments();
            gvDepartmentDetails.DataSource = dtDepartmentResult;
            gvDepartmentDetails.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            int dept_no = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Edit")
            {
                DbConnection dbConnection = new DbConnection();
                DataTable dt = dbConnection.getDeparmentByNo(dept_no);
                txtDepartmentName.Text = dt.Rows[0][1].ToString();
                lblDepartmentID.Text = dept_no.ToString();


            }
            else
            {
                DbConnection dbConnection = new DbConnection();
                dbConnection.deleteDepartment(dept_no);
                DataTable dtDepartmentResult = dbConnection.getDepartments();
                gvDepartmentDetails.DataSource = dtDepartmentResult;
                gvDepartmentDetails.DataBind();
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string dept_name = txtDepartmentName.Text;
            DbConnection dbObj = new DbConnection();
            dbObj.insertDepartment(dept_name);
            btnReset_Click(sender,e);
            DataTable dtDepartmentResult = dbObj.getDepartments();
            gvDepartmentDetails.DataSource = dtDepartmentResult;
            gvDepartmentDetails.DataBind();

        }

        protected void gvDepartmentDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void gvDepartmentDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            DbConnection dbObj = new DbConnection();
            dbObj.updateDepartment(Convert.ToInt32(lblDepartmentID.Text),txtDepartmentName.Text);
            lblDepartmentID.Text = string.Empty;
            btnReset_Click(sender, e);
            DataTable dtDepartmentResult = dbObj.getDepartments();
            gvDepartmentDetails.DataSource = dtDepartmentResult;
            gvDepartmentDetails.DataBind();

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtDepartmentName.Text = String.Empty;
            lblDepartmentID.Text = string.Empty;
        }

        protected void btn_Project_Click(object sender, EventArgs e)
        {
            Response.Redirect("Project.aspx");
        }

        protected void btn_Employee_Click(object sender, EventArgs e)
        {
            Response.Redirect("Employee.aspx");
        }
    }
}