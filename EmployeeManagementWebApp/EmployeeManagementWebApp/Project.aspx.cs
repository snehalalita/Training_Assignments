using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeManagementWebApp
{
    public partial class Project : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            DbConnection dbObj = new DbConnection();
            DataTable dtProjectResult = dbObj.getProjects();
            gvProjectDetails.DataSource = dtProjectResult;
            gvProjectDetails.DataBind();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string proj_name =txtProjectName.Text;
            string start_date = txtProjectStartDate.Text;
            DbConnection dbObj = new DbConnection();
            dbObj.insertProject(proj_name,start_date);
            btnReset_Click(sender, e);
            DataTable dtProjectResult = dbObj.getProjects();
            gvProjectDetails.DataSource = dtProjectResult;
            gvProjectDetails.DataBind();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtProjectName.Text = string.Empty;
            txtProjectStartDate.Text = string.Empty;
            lblProjectNo.Text = string.Empty;
        }

        protected void gvProjectDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int proj_no = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Edit")
            {
                DbConnection dbObj = new DbConnection();
                DataTable dt = dbObj.getProjectByNo(proj_no);
                txtProjectName.Text = dt.Rows[0][1].ToString();
                txtProjectStartDate.Text = dt.Rows[0][2].ToString();
                lblProjectNo.Text = proj_no.ToString();
  
            }
            else if(e.CommandName=="Delete")
            {
                DbConnection dbObj = new DbConnection();
                dbObj.deleteProject(proj_no);
                DataTable dtProjectResult = dbObj.getProjects();
                gvProjectDetails.DataSource = dtProjectResult;
                gvProjectDetails.DataBind();
              
            }
        }

        protected void gvProjectDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void gvProjectDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            DbConnection dbObj = new DbConnection();
            dbObj.updateProject(Convert.ToInt32(lblProjectNo.Text), txtProjectName.Text, txtProjectStartDate.Text);
            btnReset_Click(sender,e);
            DataTable dtProjectResult = dbObj.getProjects();
            gvProjectDetails.DataSource = dtProjectResult;
            gvProjectDetails.DataBind();
        }

        protected void btn_Search_Click(object sender, EventArgs e)
        {
            DbConnection dbObj = new DbConnection();
            DataTable dtProjectResult = dbObj.getProjectByNo(Convert.ToInt32(tbProjectNumber.Text));
            gvProjectDetails.DataSource = dtProjectResult;
            gvProjectDetails.DataBind();
        }

        protected void btn_Refresh_Click(object sender, EventArgs e)
        {
            DbConnection dbObj = new DbConnection();
            tbProjectNumber.Text = string.Empty;
            DataTable dtProjectResult = dbObj.getProjects();
            gvProjectDetails.DataSource = dtProjectResult;
            gvProjectDetails.DataBind();
        }

        protected void btn_Department_Click(object sender, EventArgs e)
        {
            Response.Redirect("Department.aspx");
        }

        protected void btn_Employee_Click(object sender, EventArgs e)
        {
            Response.Redirect("Employee.aspx");
        }
    }
}