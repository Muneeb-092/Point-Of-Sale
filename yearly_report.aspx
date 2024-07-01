<%@ Page Title="" Language="C#" MasterPageFile="~/POS-Master.Master" AutoEventWireup="true" CodeBehind="yearly_report.aspx.cs" Inherits="Point_Of_Sale.yearly_report" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="Styles/yearly_report.css">
   <script src="Scripts/yearly_report.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!DOCTYPE html>
    <html>
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Yearly Report</title>
    </head>
    <body>
          <h1>Yearly Report</h1>
        <div class="InventoryInputContainer">
             <a class="returnButton" href="Reporting.aspx">Back</a>
            <div class="InventoryForm">
              
                <div class="InventoryInputs">
                         
                   <div id="message" style="padding: inherit; font-family: Arial, Helvetica, sans-serif; font-size: large; font-weight: bold; font-style: normal; font-variant: normal; color: #FFFFFF; background-color: #450F60;"></div> 
 <div id="message1" style="padding: inherit; font-family: Arial, Helvetica, sans-serif; font-size: large; font-weight: bold; font-style: normal; font-variant: normal; color: #FFFFFF; background-color: #450F60;"></div> 
 <div id="message2"style="font-family: Arial, Helvetica, sans-serif;font-size: large; font-weight: bold; font-style: normal; font-variant: normal; color: #FFFFFF; margin-bottom:25px; background-color: #450F60;"></div>
                    <!-- Add GridView control to display products -->
                    <asp:GridView ID="GridViewyearly_report" runat="server" AutoGenerateColumns="True">
                    </asp:GridView>
                    
                    <!-- Button to trigger display of products -->
                    <asp:TextBox ID="txtReportYear" type="number" placeholder="Select Year" min="1800" max="2200" runat = "server" oninput="updateYear()" Width="136px" /></asp:TextBox>
                    
                    <asp:Button ID="btnyearly_report" runat="server" Text="Display Report" OnClick = "button_click_display_yearly_report" CssClass="clickButton"/>
                     </div>
                    <!-- Display messages or notifications -->
                    <div id="msg" runat="server"></div>
                      
            </div>
        </div>
    </body>
    </html>
</asp:Content>
