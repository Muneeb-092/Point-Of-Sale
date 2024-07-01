<%@ Page Title="" Language="C#" MasterPageFile="~/POS-Master.master" AutoEventWireup="true" CodeBehind="Reporting.aspx.cs" Inherits="Point_Of_Sale.WebForm14" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="Styles/POS-Reporting.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="loginHeader">
            <h1>Reports</h1>
        </div>
    <div class="inventoryLinks">
        <h2>Choose Report Type:</h2>
        <ul>
            <li><a href="daily_report.aspx">Daily Report</a></li>
            <li><a href="monthly_report.aspx">Monthly Report</a></li>
            <li><a href="yearly_report.aspx">Yearly Report</a></li>
        </ul>
    </div>
</asp:Content>
