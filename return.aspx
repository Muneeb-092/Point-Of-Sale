<%@ Page Title="" Language="C#" MasterPageFile="~/POS-Master.Master" AutoEventWireup="true" CodeBehind="return.aspx.cs" Inherits="Point_Of_Sale.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="Styles/POS-ReturnSale.css" />
    <script src="Scripts/POS-ReturnSale.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Add New Product</title>
</head>
<body>
    <div class="returnContainer">
        <a href="SalesManegment.aspx" class="backButton">Back</a>
        <div class="returnForm">
            <h2>Return Product</h2>
                <div class="returnInputs">
                    <label for="SaleID">Sale ID:</label>
                    <asp:TextBox ID="SaleID" runat="server" placeholder="Enter Sale ID..."></asp:TextBox>
                    <label for="productID">Product ID:</label>
                    <asp:TextBox ID="productID" runat="server" placeholder="Enter Product ID..."></asp:TextBox>
                    <label for="quantity">Quantity:</label>
                    <asp:TextBox ID="quantity" runat="server" placeholder="Enter Quantity..."></asp:TextBox>
                    <asp:Button class="finalButton" ID="returnProductButton" runat="server" Text="Return Product" OnClick="ReturnProduct_Click" />
                 </div>
            <div class="notify" id="message" runat="server"></div>
        </div>
    </div>
 </body>
</html>
</asp:Content>
