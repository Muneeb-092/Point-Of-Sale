<%@ Page Title="" Language="C#" MasterPageFile="~/POS-Master.Master" AutoEventWireup="true" CodeBehind="monthly_report.aspx.cs" Inherits="Point_Of_Sale.monthly_report" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="Styles/monthly_report.css">
   <script src="Scripts/monthly_report.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!DOCTYPE html>
    <html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Monthly Report</title>
    </head>
    <body>
         <h1>Monthly Report</h1>
        <div class="InventoryInputContainer">
             <a class="returnButton" href="Reporting.aspx">Back</a>
            <div class="InventoryForm">
               
                <div class="InventoryInputs">
                    <!-- Add GridView control to display products -->
                         <div id="message" style="padding: inherit; font-family: Arial, Helvetica, sans-serif; font-size: large; font-weight: bold; font-style: normal; font-variant: normal; color: #FFFFFF; background-color: #450F60;"></div> 
 <div id="message1" style="padding: inherit; font-family: Arial, Helvetica, sans-serif; font-size: large; font-weight: bold; font-style: normal; font-variant: normal; color: #FFFFFF; background-color: #450F60;"></div> 
 <div id="message2"style="font-family: Arial, Helvetica, sans-serif;font-size: large; font-weight: bold; font-style: normal; font-variant: normal; color: #FFFFFF; margin-bottom:25px; background-color: #450F60;"></div>
                    <asp:GridView ID="GridViewmonthly_report" runat="server" AutoGenerateColumns="True">
                    </asp:GridView>
                    
                    <!-- Button to trigger display of products -->
                     <asp:TextBox ID="txtReportMonth" runat="server" placeholder="Select Month and Year" type="month"></asp:TextBox>

                    <asp:Button ID="btnmonthly_report" runat="server" Text="Display Report" OnClick = "button_click_display_monthly_report" CssClass="clickButton"/>
                    
                    <!-- Display messages or notifications -->
                    <div id="msg" runat="server"></div>
                       </div>
            </div>
        </div>
    </body>
    </html>
</asp:Content>
