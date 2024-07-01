<%@ Page Title="" Language="C#" MasterPageFile="~/POS-Master.Master" AutoEventWireup="true" CodeBehind="Delete_Employee.aspx.cs" Inherits="Point_Of_Sale.WebForm11" %>
<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" href="Styles/POS-delete_employee.css">
    <script src="Scripts/POS-delete_employee.js"></script>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<title>Delete Employee</title>
<link rel="stylesheet" href="POS-delete_Employee.css">
</head>
<body>
<div class="returnContainer">
    <a href="EmployeeManegment.aspx" class="returnButton">Back</a>
    <div class="returnForm">
        <h2>Fire Employee</h2>
        <div class="returnInputs">
            <label for="EmployeeID">Employee ID</label>
          
            <asp:TextBox ID = "txtID" name="EmployeeID" placeholder="Enter Employee ID..." runat="server" ClientIDMode="Static" required></asp:TextBox>
       
             </div>
            <asp:Button ID="btn_click" runat="server" Text="Fire Employee" OnClick="button_click_delete_employee" CssClass="clickButton"/>
        
       
        <div id="message" runat="server"></div>
    </div>
</div>
<script src="POS-delete_Employee.js"></script>
</body>
</html>


</asp:Content>
