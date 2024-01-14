<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HDFC_Loans.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <style type="text/css">
        .login-box {
            width: 400px;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 10px;
            margin: 50px auto;
            background-color: #f9f9f9;
        }

        .login-box img {
            display: block;
            margin: 0 auto;
        }

        .login-box label {
            display: block;
            margin-bottom: 10px;
        }

        .login-box input {
            width: 100%;
            padding: 10px;
            margin-bottom: 20px;
            box-sizing: border-box;
        }

        .login-box button {
            width: 100%;
            padding: 10px;
            background-color: #4CAF50;
            color: white;
            border: none;
            border-radius: 5px;
            cursor: pointer;
        }
    </style>

    <div class="login-box">
        <img src="Images/logimage.jpg" alt="Login Image" height="150" />
        <label for="TextBox1">Username</label>
        <asp:TextBox ID="TextBox1" runat="server" Height="30px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter username" ForeColor="Red"></asp:RequiredFieldValidator>

        <label for="TextBox2">Password</label>
        <asp:TextBox ID="TextBox2" runat="server" Height="30px" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter your password" ForeColor="Red"></asp:RequiredFieldValidator>

        <br />
        <br />

        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <br />
        <br />

        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
