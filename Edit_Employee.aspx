<%@ Page Title="" Language="C#" MasterPageFile="~/POS-Master.Master" AutoEventWireup="true" CodeBehind="Edit_Employee.aspx.cs" Inherits="Point_Of_Sale.WebForm10" %>
<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="Styles/POS-Edit_Employee.css">
    <script src="Scripts/POS-Edit_Employee.js"></script>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<title>Update Employee</title>

</head>
<body>
<div class="InventoryInputContainer">
    <a href="EmployeeManegment.aspx" class="returnButton">Back</a>
    <div class="InventoryForm">
        <h2>Edit Employee Info</h2>
        <div class="InventoryInputs">
             <label for="id">ID:</label>
  <asp:TextBox ID="txtID" runat="server" ClientIDMode="Static" required></asp:TextBox>

  <label for="phone">Phone No.:</label>
  <asp:TextBox ID="txtPhone" runat="server" ClientIDMode="Static" TextMode="number" required></asp:TextBox>

  <label for="address">Address:</label>
  <asp:TextBox ID="txtAddress" runat="server" ClientIDMode="Static" required></asp:TextBox>

  <label for="designation">Designation:</label>
  <asp:TextBox ID="txtDesignation" runat="server" ClientIDMode="Static" required></asp:TextBox>

  <label for="salary">Salary:</label>
  <asp:TextBox ID="txtSalary" runat="server" ClientIDMode="Static" TextMode="Number" required></asp:TextBox>
            
   <label for="username">User Name:</label>
    <asp:TextBox ID="txtusername" runat="server" ClientIDMode="Static" required></asp:TextBox>

    <label for="password">Password:</label>
    <asp:TextBox ID="txtpassword" runat="server" ClientIDMode="Static" required></asp:TextBox>

    <label for="accessibility">Accessibility Status:</label>
    <asp:TextBox ID="txtaccessibility" runat="server" ClientIDMode="Static" required></asp:TextBox>
     
        </div>
            <asp:Button ID="btn_click" runat="server" Text="Update Employee" OnClick="button_click_update_employee" CssClass="clickButton"/>
        
        <div id="message" runat="server"></div>
    </div>
</div>

</body>
</html>




</asp:Content>
