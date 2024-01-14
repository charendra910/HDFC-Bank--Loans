<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ViewAll.aspx.cs" Inherits="HDFC_Loans.ViewAll" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style12 {
            margin-left: 120px;
           
        }

        .auto-style13 {
            margin-left: 240px;  
        }
    .auto-style15 {
        width: 254px;
        margin-left: 200px;  
    }
        .auto-style17 {
            width: 300px;
            height:20px;
            margin-left: 280px;  margin-right:280px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <p>
        <br />
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource3" DataKeyNames="LoanNo">
            <Columns>
                <asp:BoundField DataField="LoanNo" HeaderText="Loan No" SortExpression="LoanNo" />
                <asp:BoundField DataField="AccountNo" HeaderText="Account No" SortExpression="AccountNo" />
                <asp:BoundField DataField="HolderName" HeaderText="Holder Name" SortExpression="HolderName" />
                <asp:BoundField DataField="LoanCategory" HeaderText="Loan Category" SortExpression="LoanCategory" />
                <asp:BoundField DataField="LoanType" HeaderText="Loan Type" SortExpression="LoanType" />
                <asp:BoundField DataField="IssueDate" HeaderText="Issue Date" SortExpression="IssueDate" />
                <asp:BoundField DataField="Amount" HeaderText="Amount" SortExpression="Amount" />
                <asp:BoundField DataField="CurrentAddress" HeaderText="Current Address" SortExpression="CurrentAddress" />
                <asp:BoundField DataField="LoanRemarks" HeaderText="Loan Remarks" SortExpression="LoanRemarks" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Loan]"></asp:SqlDataSource>
    </p>
    <br />
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <p class="auto-style17">Total number of entries: <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></p>
    <p class="auto-style13">
        <asp:Button ID="Button1" runat="server" Text="Get Details" OnClick="Button1_Click" />
    </p>
</asp:Content>
