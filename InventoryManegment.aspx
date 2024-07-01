<%@ Page Title="" Language="C#" MasterPageFile="~/POS-Master.Master" AutoEventWireup="true" CodeBehind="InventoryManegment.aspx.cs" Inherits="Point_Of_Sale.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="Styles/POS-Inventory_manegment.css">
   
</asp:Content>

   
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!DOCTYPE html>
<html lang="en">
<head>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<title>Inventory Management</title>

</head>
<body>
    <div class="loginHeader">
        <h1>Inventory Management</h1>
    </div>
<div class="EmployeesLinks">
    <ul>
        <li><a href="display_products.aspx">Show Inventory</a></li>
        <li><a href="low_inventory.aspx">Show Low Stock Inventory</a></li>
        <li><a href="highly_demand.aspx">Higly Demanding Products in Inventory</a></li>
        <li><a href="AddProduct.aspx">Add New Product to Inventory</a></li>
        <li><a href="EditProduct.aspx">Edit Product in Inventory</a></li>
        <li><a href="DeleteProduct.aspx">Delete Product in Inventory</a></li>
    </ul>
</div>
</body>
</html>

</asp:Content>
