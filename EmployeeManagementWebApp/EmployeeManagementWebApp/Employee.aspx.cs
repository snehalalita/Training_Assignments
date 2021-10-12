using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeManagementWebApp
{
    public partial class Employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DbConnection dbObj = new DbConnection();
                DataTable dtEmployeeResult = dbObj.getEmployees();
                gvEmployeeDetails.DataSource = dtEmployeeResult;
                gvEmployeeDetails.DataBind();

                DataTable dtDepartmentResult = dbObj.getDepartments();
                for (int i = 0; i < dtDepartmentResult.Rows.Count; i++)
                {
                    ddlDepartmentNumber.Items.Add(new ListItem(dtDepartmentResult.Rows[i][0].ToString() + "-" + dtDepartmentResult.Rows[i][1].ToString(), dtDepartmentResult.Rows[i][0].ToString()));
                }

                DataTable dtProjectResult = dbObj.getProjects();
                for (int i = 0; i < dtProjectResult.Rows.Count; i++)
                {
                    ddlProjectNumber.Items.Add(new ListItem(dtProjectResult.Rows[i][0].ToString() + "-" + dtProjectResult.Rows[i][1].ToString(), dtProjectResult.Rows[i][0].ToString()));
                }
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            
            DbConnection dbObj = new DbConnection();
            dbObj.insertEmployee(txtJobTitle.Text, txtLastName.Text, txtFirstName.Text, txtGender.Text, txtBirthday.Text, txtHireDate.Text, Convert.ToInt32(ddlDepartmentNumber.SelectedValue.ToString()), Convert.ToInt32(ddlProjectNumber.SelectedValue.ToString()));
            btnReset_Click(sender, e);
            DataTable dtEmployeeResult = dbObj.getEmployees();
            gvEmployeeDetails.DataSource = dtEmployeeResult;
            gvEmployeeDetails.DataBind();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtJobTitle.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtGender.Text = string.Empty;
            txtBirthday.Text = string.Empty;
            txtHireDate.Text = string.Empty;
            lblEmployeeNumber.Text = string.Empty;
            ddlDepartmentNumber.SelectedIndex = 0;
            ddlProjectNumber.SelectedIndex = 0;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            DbConnection dbObj = new DbConnection();
            dbObj.updateEmployee(Convert.ToInt32(lblEmployeeNumber.Text),txtJobTitle.Text, txtLastName.Text, txtFirstName.Text, txtGender.Text, txtBirthday.Text, txtHireDate.Text, Convert.ToInt32(ddlDepartmentNumber.SelectedValue.ToString()), Convert.ToInt32(ddlProjectNumber.SelectedValue.ToString()));
            btnReset_Click(sender, e);
            DataTable dtEmployeeResult = dbObj.getEmployees();
            gvEmployeeDetails.DataSource = dtEmployeeResult;
            gvEmployeeDetails.DataBind();
        }

        protected void gvEmployeeDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int emp_no = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Edit")
            {
                DbConnection dbObj = new DbConnection();
                DataTable dt = dbObj.getEmployeeByNo(emp_no);
                txtJobTitle.Text = dt.Rows[0][1].ToString();
                txtLastName.Text = dt.Rows[0][2].ToString();
                txtFirstName.Text = dt.Rows[0][3].ToString();
                txtGender.Text = dt.Rows[0][4].ToString();
                txtBirthday.Text = dt.Rows[0][5].ToString();
                txtHireDate.Text = dt.Rows[0][6].ToString();
                ddlDepartmentNumber.SelectedValue = dt.Rows[0][7].ToString();
                ddlProjectNumber.SelectedValue = dt.Rows[0][8].ToString();
                lblEmployeeNumber.Text = emp_no.ToString();
                

            }
            else if (e.CommandName == "Delete")
            {
                DbConnection dbObj = new DbConnection();
                dbObj.deleteEmployee(emp_no);
                DataTable dtEmployeeResult = dbObj.getEmployees();
                gvEmployeeDetails.DataSource = dtEmployeeResult;
                gvEmployeeDetails.DataBind();


            }
        }

        protected void gvEmployeeDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void gvEmployeeDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void btn_Search_Click(object sender, EventArgs e)
        {

            DbConnection dbObj = new DbConnection();
            
            DataTable dtEmployeeResult = dbObj.getEmployeeByNo(Convert.ToInt32(tbEmployeeNumber.Text));
            gvEmployeeDetails.DataSource = dtEmployeeResult;
            gvEmployeeDetails.DataBind();
        }

        protected void btn_Refresh_Click(object sender, EventArgs e)
        {
            tbEmployeeNumber.Text = string.Empty;
            DbConnection dbObj = new DbConnection();
            DataTable dtEmployeeResult = dbObj.getEmployees();
            gvEmployeeDetails.DataSource = dtEmployeeResult;
            gvEmployeeDetails.DataBind();
        }

        protected void btn_Department_Click(object sender, EventArgs e)
        {
            Response.Redirect("Department.aspx");
        }

        protected void btn_Project_Click(object sender, EventArgs e)
        {
            Response.Redirect("Project.aspx");
        }
    }
}