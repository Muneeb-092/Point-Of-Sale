<%@ Page Title="" Language="C#" MasterPageFile="~/POS-Master.Master" AutoEventWireup="true" CodeBehind="display_products.aspx.cs" Inherits="Point_Of_Sale.WebForm15" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="Styles/DisplayProduct.css">
    <script src="Scripts/display_products.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!DOCTYPE html>
    <html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>All Products</title>
    </head>
    <body>
        <h1 style="margin-left: 64px;">All Products</h1>
        <div class="InventoryInputContainer">
             <a class="returnButton" href="InventoryManegment.aspx">Back</a>
            <div class="InventoryForm">
                
                <div class="InventoryInputs">
                    <!-- Add GridView control to display products -->
                    <asp:GridView ID="GridViewProducts" runat="server" AutoGenerateColumns="True">
                    </asp:GridView>
                    
                    <!-- Button to trigger display of products -->
                    
                    <asp:Button ID="btnDisplayProducts" runat="server" Text="Display" OnClick = "button_click_display_products" CssClass ="clickButton" />
                    
                    <!-- Display messages or notifications -->
                    <div id="message" runat="server"></div>
                       </div>
            </div>
        </div>
    </body>
    </html>
</asp:Content>
