<%@ Page Title="" Language="C#" MasterPageFile="~/POS-Master.Master" AutoEventWireup="true" CodeBehind="low_inventory.aspx.cs" Inherits="Point_Of_Sale.low_inventory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="Styles/low_inventory.css">
   <script src="Scripts/low_inventory.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!DOCTYPE html>
    <html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Products having low Stock</title>
    </head>
    <body>
       <h1 style="margin-left: 446px;">Products having low Stock</h1>
        <div class="InventoryInputContainer">
             <a class="returnButton" href="InventoryManegment.aspx">Back</a>
            <div class="InventoryForm">
                
                <div class="InventoryInputs">
                    <!-- Add GridView control to display products -->
                    <asp:GridView ID="GridViewlowinventory" runat="server" AutoGenerateColumns="True">
                    </asp:GridView>
                    
                    <!-- Button to trigger display of products -->
                    
                    <asp:Button ID="btnDisplaylowinventory" runat="server" Text="Display Products" OnClick = "button_click_display_low_inventory" CssClass="clickButton"/>
                    
                    <!-- Display messages or notifications -->
                    <div id="message" runat="server"></div>
                       </div>
            </div>
        </div>
    </body>
    </html>
</asp:Content>
