<%@ Page Title="POS Login" Language="C#" MasterPageFile="~/BaseMaster.Master" AutoEventWireup="true" CodeBehind="POS-Login.aspx.cs" Inherits="Point_Of_Sale.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head1" runat="server">
    <link href="Styles/POS-login.css" rel="stylesheet">
    <script src="Scripts/POS-login.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlace1" runat="server">
    <div class="container"> 
        <div class="loginHeader">
            <h1>POS</h1>
            <p>Point Of Sale</p>

        </div>
        <div class="loginBody">
            <asp:Panel ID="LoginPanel" runat="server">
                <div class="loginInputsContainer">
                    <label for="txtUsername">Username</label>
                    <asp:TextBox ID="txtUsername" runat="server" placeholder="Username"></asp:TextBox>
                </div>
                <div class="loginInputsContainer">
                    <label for="txtPassword">Password</label>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Password"></asp:TextBox>
                </div>
                <div>
                    <asp:Button ID="btnLogin" class="logintbn" runat="server" Text="Login" OnClick="btnLogin_Click" />
                </div>
                <div id="message" runat="server" class="message"></div>
            </asp:Panel>
        </div>
    </div>
</asp:Content>
