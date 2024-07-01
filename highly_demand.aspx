<%@ Page Title="" Language="C#" MasterPageFile="~/POS-Master.Master" AutoEventWireup="true" CodeBehind="highly_demand.aspx.cs" Inherits="Point_Of_Sale.highly_demand" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="Styles/highly_demand.css">
   <script src="Scripts/highly_demand.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!DOCTYPE html>
    <html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Highly demanded Products</title>
    </head>
    <body>
         <h1>Highly demanded Products</h1>
        <div class="InventoryInputContainer">
             <a class="returnButton" href="InventoryManegment.aspx">Back</a>
            <div class="InventoryForm">
               
                <div class="InventoryInputs">
                    <!-- Add GridView control to display products -->
                    <asp:GridView ID="GridViewhighly_demand" runat="server" AutoGenerateColumns="True">
                    </asp:GridView>
                    
                    <!-- Button to trigger display of products -->
                    
                    <asp:Button ID="btnhighly_demand" runat="server" Text="Display Products" OnClick = "button_click_display_highly_demand" CssClass="clickButton"/>
                    
                    <!-- Display messages or notifications -->
                    <div id="message" runat="server"></div>
                       </div>
            </div>
        </div>
    </body>
    </html>
</asp:Content>
