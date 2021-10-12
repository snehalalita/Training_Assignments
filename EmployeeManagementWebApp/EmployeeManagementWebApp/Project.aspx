<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Project.aspx.cs" Inherits="EmployeeManagementWebApp.Project" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 39px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <b> <p style="margin-left: 160px">
                PROJECT&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btn_Department" runat="server" OnClick="btn_Department_Click" Text="Department" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btn_Employee" runat="server" OnClick="btn_Employee_Click" Text="Employee" />
                <br />
            </p></b>
            <table> 
                <tr>
                    <th class="auto-style1">Project Name 
                        
                    </th>
                    <td class="auto-style1"> 
                        <asp:TextBox ID="txtProjectName" runat="server"></asp:TextBox>
                       
                        <asp:Label ID="lblProjectNo" runat="server"></asp:Label>
                       
                    </td>
                    
                </tr>
                <tr>
                    <th>Start Date 
                        
                    </th>
                    <td> 
                        <asp:TextBox ID="txtProjectStartDate" runat="server"></asp:TextBox>
                       

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
        <br />
        Search By Project Number:
        <asp:TextBox ID="tbProjectNumber" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_Search" runat="server" OnClick="btn_Search_Click" Text="Search" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_Refresh" runat="server" OnClick="btn_Refresh_Click" Text="Refresh" />
        <br />
        <br />
        <br />
        Project Details:<br />
        <br />
        <asp:GridView ID="gvProjectDetails" runat="server" AutoGenerateColumns="False" OnRowCommand="gvProjectDetails_RowCommand" OnRowDeleting="gvProjectDetails_RowDeleting" OnRowEditing="gvProjectDetails_RowEditing">
            <Columns>
                <asp:BoundField DataField="projectNumber" HeaderText="Project Number" />
                <asp:BoundField DataField="name" HeaderText="Project Name" />
                <asp:BoundField DataField="start_date" HeaderText="Start Date" />
                <asp:TemplateField HeaderText="Edit">
                    <ItemTemplate>
                        <asp:LinkButton ID="lb_Edit" runat="server" CommandName="Edit" CommandArgument='<%# Eval("projectNumber") %>'>Edit</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Delete">
                    <ItemTemplate>
                        <asp:LinkButton ID="lb_Delete" runat="server" CommandName="Delete" CommandArgument='<%# Eval("projectNumber") %>'>Delete</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
