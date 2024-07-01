<%@ Page Title="" Language="C#" MasterPageFile="~/POS-Master.Master" AutoEventWireup="true" CodeBehind="DeleteProduct.aspx.cs" Inherits="Point_Of_Sale.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="Styles/POS-delete_product.css">
    <script src="Scripts/POS-delete_product.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Delete Product</title>
</head>
<body>
    <div class="returnContainer">
        <a href="InventoryManegment.aspx" class="returnButton">Back</a>
        <div class="returnForm">
            <h2>Delete Product</h2>
            <div class="returnInputs">
                <label for="productID">Product ID:</label>
                <asp:TextBox ID="productID" runat="server" placeholder="Enter Product ID..."></asp:TextBox>
                <label for="quantity">Quantity:</label>
                <asp:TextBox ID="quantity" runat="server" placeholder="Enter Quantity..."></asp:TextBox>
                <asp:Button class="deleteButton" ID="deleteProductButton" runat="server" Text="Delete Product" OnClick="deleteProduct_Click" />
            </div>
            <div class= "msg" id="message" runat="server"></div>
        </div>
    </div>
</body>
</html>

</asp:Content>
