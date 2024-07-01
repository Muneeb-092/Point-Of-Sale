<%@ Page Title="" Language="C#" MasterPageFile="~/POS-Master.Master" AutoEventWireup="true" CodeBehind="Display_Employees.aspx.cs" Inherits="Point_Of_Sale.Display_Employees" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="Styles/display_employees.css">
    <script src="Scripts/Display_Employees.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!DOCTYPE html>
    <html>
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>All Employees</title>
    </head>
    <body>
       <h1 style="margin-left: 50px;">All Employees</h1>
        <div class="InventoryInputContainer">
             <a class="returnButton" href="EmployeeManegment.aspx">Back</a>
            <div class="InventoryForm">
   
                <div class="InventoryInputs">
                    <!-- Add GridView control to display employees -->
                    <asp:GridView ID="GridViewEmployees" runat="server" AutoGenerateColumns="True" >
                    </asp:GridView>
                    </div>
                  <asp:Button ID="btnDisplayEmployees" runat="server" Text="Display" OnClick="button_click_display_employees" CssClass="clickButton" />
        
                    <!-- Button to trigger display of products -->
                    
                    <!-- Display messages or notifications -->
                    <div id="message"></div>
            </div>
        </div>
    </body>
    </html>
</asp:Content>
