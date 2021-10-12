<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Department.aspx.cs" Inherits="EmployeeManagementWebApp.Department" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <b><p style="margin-left: 120px">
                DEPARTMENT&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btn_Project" runat="server" OnClick="btn_Project_Click" Text="Project" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btn_Employee" runat="server" OnClick="btn_Employee_Click" Text="Employee" />
            </p></b>
            <table>
                 <tr>
                    <th>Department Number
                        
                    </th>
                    <td> 
                        <asp:Label ID="lblDepartmentID" runat="server"></asp:Label>
                       
                    </td>
                    
                </tr>
                <tr>
                    <th>Department Name 
                        
                    </th>
                    <td> 
                        <asp:TextBox ID="txtDepartmentName" runat="server"></asp:TextBox>
                       
                        
                       
                    </td>
                    
                </tr>
            </table>
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                    
            <br />
            <br />
                    
        </div>
        Department Details:<br />
        <asp:GridView ID="gvDepartmentDetails" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand" OnRowDeleting="gvDepartmentDetails_RowDeleting" OnRowEditing="gvDepartmentDetails_RowEditing">
            <Columns>
                <asp:BoundField DataField="departmentNumber" HeaderText="Department No" />
                <asp:BoundField DataField="name" HeaderText="Department Name" />
                <asp:TemplateField HeaderText="Edit">
                    <ItemTemplate>
                        <asp:LinkButton ID="lb_Edit" runat="server" CommandName="Edit" CommandArgument='<%# Eval("departmentNumber") %>'>Edit</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Delete">
                    <ItemTemplate>
                        <asp:LinkButton ID="lb_Delete" runat="server" CommandName="Delete" CommandArgument='<%# Eval("departmentNumber") %>'>Delete</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
