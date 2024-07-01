<%@ Page Title="" Language="C#" MasterPageFile="~/POS-Master.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Point_Of_Sale.WebForm12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="Styles/POS-Home.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!DOCTYPE html>
<html lang="en">
<head>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<title>Point of Sale System</title>
<link rel="stylesheet" href="POS-Home.css">
</head>
<body>
<header >
    <h1>Welcome to Point of Sale System</h1>
</header>
<nav class="main-nav">
    <ul>
        <li><a href="SalesManegment.aspx">Sales Management</a></li>
        <li><a href="Inventorymanegment.aspx">Inventory Management</a></li>
        <li><a href="EmployeeManegment.aspx">Employee Management</a></li>
        <li><a href="Reporting.aspx">Reports</a></li>
        <li><a href="user.aspx">User Info</a></li>
    </ul>
</nav>
<section class="main-content">
    <h2>Efficiently manage your business with our Point of Sale System</h2>
    <p>Our POS system provides comprehensive tools for managing sales, tracking inventory, managing employees, generating reports, and more. With user-friendly interfaces and powerful features, our system is designed to streamline your operations and improve efficiency.</p>
    <p>Whether you're a small retail shop or a large-scale business, our POS system is tailored to meet your needs. Explore our features and start managing your business more effectively today!</p>
</section>
</body>
</html>

</asp:Content>
