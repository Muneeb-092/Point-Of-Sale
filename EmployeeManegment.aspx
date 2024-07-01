<%@ Page Title="" Language="C#" MasterPageFile="~/POS-Master.Master" AutoEventWireup="true" CodeBehind="EmployeeManegment.aspx.cs" Inherits="Point_Of_Sale.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="Styles/POS-Employee_Manegment.css">
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
        <h1>Employee Management</h1>
    </div>
<div class="EmployeesLinks">
    <ul>
        <li><a href="Display_Employees.aspx">Show All Employees</a></li>
        <li><a href="AddEmployee.aspx">Hire Employee</a></li>
        <li><a href="Edit_Employee.aspx">Edit Employee</a></li>
        <li><a href="delete_employee.aspx">Fire Employee</a></li>
    </ul>
</div>
</body>
</html>

</asp:Content>
