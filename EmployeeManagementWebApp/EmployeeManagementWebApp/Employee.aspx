<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="EmployeeManagementWebApp.Employee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <b><p style="margin-left: 160px">
                EMPLOYEE&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btn_Department" runat="server" OnClick="btn_Department_Click" Text="Department" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btn_Project" runat="server" OnClick="btn_Project_Click" Text="Project" />
            <br />
            </p></b>
            <table>
                <tr>
                    <th>Employee Number</th>
                    <td>
                         <asp:Label ID="lblEmployeeNumber" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <th>Job Title</th>
                    <td>
                        <asp:TextBox ID="txtJobTitle" runat="server"></asp:TextBox>
                       
                    </td>
                </tr>
                <tr>
                    <th>Last Name</th>
                    <td>
                        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th>First Name</th>
                    <td>
                        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th>Gender</th>
                    <td>
                        <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th>Birthday</th>
                    <td>
                        <asp:TextBox ID="txtBirthday" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th>Hire Date</th>
                    <td>
                        <asp:TextBox ID="txtHireDate" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th>Department Number</th>
                    <td>
                        <asp:DropDownList ID="ddlDepartmentNumber" runat="server" >
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <th>Project Number</th>
                    <td>
                        <asp:DropDownList ID="ddlProjectNumber" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
            </table>
            <br />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click"  />
            &nbsp;&nbsp;
            <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click"  />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click"  />
            <br />
        </div>
        <br />
        <br />
        Search By Employee Number:
        <asp:TextBox ID="tbEmployeeNumber" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_Search" runat="server" OnClick="btn_Search_Click" Text="Search" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_Refresh" runat="server" OnClick="btn_Refresh_Click" Text="Refresh" />
        <br />
        <br />
        <br />
        Employee Details:<br />
        <br />
        <asp:GridView ID="gvEmployeeDetails" runat="server" AutoGenerateColumns="False" OnRowCommand="gvEmployeeDetails_RowCommand" OnRowDeleting="gvEmployeeDetails_RowDeleting" OnRowEditing="gvEmployeeDetails_RowEditing">
            <Columns>
                <asp:BoundField DataField="employeeNumber" HeaderText="Employee Number" />
                <asp:BoundField DataField="job_Title" HeaderText="Job Title" />
                <asp:BoundField DataField="lastName" HeaderText="Last Name" />
                <asp:BoundField DataField="firstName" HeaderText="First Name" />
                <asp:BoundField DataField="gender" HeaderText="Gender" />
                <asp:BoundField DataField="birthday" HeaderText="Birthday" />
                <asp:BoundField DataField="hiredate" HeaderText="Hire Date" />
                <asp:BoundField DataField="departmentNumber" HeaderText="Department Number" />
                <asp:BoundField DataField="projectNumber" HeaderText="Project Number" />
                <asp:TemplateField HeaderText="Edit">
                    <ItemTemplate>
                        <asp:LinkButton ID="lb_Edit" runat="server"  CommandName="Edit" CommandArgument='<%# Eval("employeeNumber") %>'>Edit</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Delete">
                    <ItemTemplate>
                        <asp:LinkButton ID="lb_Delete" runat="server"  CommandName="Delete" CommandArgument='<%# Eval("employeeNumber") %>'>Delete</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
