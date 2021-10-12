using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EmployeeManagementWebApp
{
    public class DbConnection
    {
        public void insertDepartment(string dept_name)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=EmployeeManagement;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("insert into department values ('"+dept_name+"')", sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void deleteDepartment(int dept_no)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=EmployeeManagement;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("delete from department where departmentNumber = "+dept_no, sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void updateDepartment(int dept_no,string dept_name)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=EmployeeManagement;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("update department set name='"+dept_name+"' where departmentNumber = " + dept_no, sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public DataTable getDeparmentByNo(int dept_no)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=EmployeeManagement;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("select * from department where departmentNumber ="+dept_no, sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }
        public DataTable getDepartments()
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=EmployeeManagement;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("select * from department", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }

        #region Project
        public void insertProject(string proj_name,string start_date)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=EmployeeManagement;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("insert into project values ('" + proj_name +"','"+start_date+ "')", sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void deleteProject(int proj_no)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=EmployeeManagement;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("delete from project where projectNumber = " + proj_no, sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void updateProject(int proj_no, string proj_name, string start_date)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=EmployeeManagement;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("update project set name='" + proj_name+"',start_date='"+start_date + "' where projectNumber = " + proj_no, sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public DataTable getProjectByNo(int proj_no)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=EmployeeManagement;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("select * from project where projectNumber =" + proj_no, sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }
        public DataTable getProjects()
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=EmployeeManagement;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("select * from project", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }

        #endregion
        public void insertEmployee(string job_title,string last_name,string first_name,string gender,string birthday,string hire_date,int dept_no,int proj_no)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=EmployeeManagement;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("insert into employee values ('" + job_title+"','"+last_name+"','"+first_name+"','"+gender+"','"+birthday+"','"+hire_date+"',"+dept_no+","+proj_no+ ")", sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void deleteEmployee(int emp_no)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=EmployeeManagement;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("delete from employee where employeeNumber = " + emp_no, sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void updateEmployee(int emp_no, string job_title, string last_name, string first_name, string gender, string birthday, string hire_date, int dept_no, int proj_no)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=EmployeeManagement;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("update employee set job_Title='" +job_title +"',lastName='"+last_name+"',firstName='"+first_name+"',gender='"+gender+"',birthday='"+birthday+"',hiredate='"+hire_date+"',departmentNumber="+dept_no+",projectNumber="+proj_no + " where employeeNumber = " + emp_no, sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public DataTable getEmployeeByNo(int emp_no)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=EmployeeManagement;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("select * from employee where employeeNumber =" + emp_no, sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }
        public DataTable getEmployees()
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-UJ2QCA0O;Initial Catalog=EmployeeManagement;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("select * from employee", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }
    }
}