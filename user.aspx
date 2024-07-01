<%@ Page Title="" Language="C#" MasterPageFile="~/POS-Master.Master" AutoEventWireup="true" CodeBehind="user.aspx.cs" Inherits="Point_Of_Sale.WebForm13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link rel="stylesheet" type="text/css" href="Styles/POS-UserInfo.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    
        
            <div class="container" runat="server">
                <h2 style="font-size: 34px;">Login User Details</h2>
                <div class="user-info">
                    <label for="username">Username:</label>
                    <asp:Label ID="username" runat="server"></asp:Label>
                </div>
                
               <div class="user-info">
                    <label for="loginTime">Loged In at:</label>
                    <asp:Label ID="loginTime" runat="server" ></asp:Label>
                </div>
               <div class="user-info">
                    <label for="accessibility">Accessibility Status:</label>
                    <asp:Label ID="accessibility" runat="server" ></asp:Label>
              </div>
                <asp:Button ID="logoutBtn" runat="server" class="logout-btn" Text="Logout" OnClick="LogoutBtn_Click"  />
            </div>
       
    
</asp:Content>
