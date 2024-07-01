<%@ Page Title="" Language="C#" MasterPageFile="~/POS-Master.Master" AutoEventWireup="true" CodeBehind="AddEmployee.aspx.cs" Inherits="Point_Of_Sale.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="Styles/POS-Add_Employee.css">
    <script src="Scripts/POS-Add_Employee.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<title>Add New Employee</title>

</head>
<body>
<div class="InventoryInputContainer">
    <a href="EmployeeManegment.aspx" class="returnButton">Back</a>
    <div class="InventoryForm">
        <h2>Add New Employee</h2>
        <div class="InventoryInputs">
            
            <label for="id">ID:</label>
            <asp:TextBox ID="txtID" runat="server" ClientIDMode="Static" required></asp:TextBox>
            
            <label for="name">Name:</label>
            <asp:TextBox ID="txtName" runat="server" ClientIDMode="Static" required></asp:TextBox>

            <label for="email">Email:</label>
            <asp:TextBox ID="txtEmail" runat="server" ClientIDMode="Static" TextMode="Email" required></asp:TextBox>

            <label for="phone">Phone No.:</label>
            <asp:TextBox ID="txtPhone" runat="server" ClientIDMode="Static" required></asp:TextBox>

            <label for="address">Address:</label>
            <asp:TextBox ID="txtAddress" runat="server" ClientIDMode="Static" required></asp:TextBox>

            <label for="cnic">CNIC:</label>
            <asp:TextBox ID="txtCNIC" runat="server" ClientIDMode="Static" required></asp:TextBox>

            <label for="dob">Date Of Birth:</label>
            <asp:TextBox ID="txtDOB" runat="server" ClientIDMode="Static" TextMode="Date" required></asp:TextBox>

            <label for="designation">Designation:</label>
            <asp:TextBox ID="txtDesignation" runat="server" ClientIDMode="Static" required></asp:TextBox>

            <label for="salary">Salary:</label>
            <asp:TextBox ID="txtSalary" runat="server" ClientIDMode="Static"  required></asp:TextBox>

            <label for="joiningDate">Joining date:</label>
            <asp:TextBox ID="txtJoiningDate" runat="server" ClientIDMode="Static" TextMode="Date" required></asp:TextBox>

             <label for="username">User Name:</label>
             <asp:TextBox ID="txtusername" runat="server" ClientIDMode="Static" required></asp:TextBox>

             <label for="password">Password:</label>
             <asp:TextBox ID="txtpassword" runat="server" ClientIDMode="Static" required></asp:TextBox>

             <label for="accessibility">Accessibility Status:</label>
             <asp:TextBox ID="txtaccessibility" runat="server" ClientIDMode="Static" required></asp:TextBox>

           </div>   
          <asp:Button ID="btn_click" runat="server" Text="Add Employee" OnClick="button_click_add_employee" CssClass="clickButton"/>
         
        <div id="msg" runat="server"></div>
    </div>
</div>
<script src="POS-Add_Employee.js"></script>
</body>
</html>






</asp:Content>
