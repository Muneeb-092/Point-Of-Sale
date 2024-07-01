<%@ Page Title="" Language="C#" MasterPageFile="~/POS-Master.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="Point_Of_Sale.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="Styles/POS-AddNewToInventory.css">
    <script src="Scripts/POS-AddNewToInventory.js"></script>
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
    <asp:ScriptManager runat="server"></asp:ScriptManager>  
    <asp:UpdatePanel ID="panel1" runat="server">
        <ContentTemplate>
    <div class="InventoryInputContainer">
        <a href="InventoryManegment.aspx" class="returnButton">Back</a>
        <div class="InventoryForm">
            <h2>Add New Product</h2>
            <div class="InventoryInputs">
                <label for="productName">Product Name:</label>
                <asp:TextBox ID="productName" runat="server" placeholder="Enter Product Name..."></asp:TextBox>
                <label for="categoryName">Category Name:</label>
                <asp:TextBox ID="categoryName" runat="server" placeholder="Enter Category Name..."></asp:TextBox>
                <label for="purchasePrice">Purchase Price:</label>
                <asp:TextBox ID="purchasePrice" runat="server" placeholder="Enter Purchase Price..."></asp:TextBox>
                <label for="salePrice">Sale Price:</label>
                <asp:TextBox ID="salePrice" runat="server" placeholder="Enter Sale Price..."></asp:TextBox>
                <label for="quantity">Quantity:</label>
                <asp:TextBox ID="quantity" runat="server" placeholder="Enter Quantity..."></asp:TextBox>
                <asp:Button class="finalButton" ID="addProductButton" runat="server" Text="Add Product" OnClick="addProduct_Click" />
            </div>
            <div class="warn" id="message" runat="server"></div>
        </div>
    </div>
    </ContentTemplate>
    </asp:UpdatePanel>
</body>
</html>

</asp:Content>
