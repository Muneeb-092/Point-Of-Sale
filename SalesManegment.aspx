<%@ Page Title="" Language="C#" MasterPageFile="~/POS-Master.Master" AutoEventWireup="true" CodeBehind="SalesManegment.aspx.cs" Inherits="Point_Of_Sale.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="Styles/POS-Sale_Managment.css">
    <script src="Scripts/POS-Sale_Managment.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server"></asp:ScriptManager>
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
    <div class="container">
        <div class="loginHeader">
            <h1>Sales Management</h1>
        </div>
        <div class="newSale">
            <asp:Button class="newSalebtn" ID="btnNewSale" runat="server" Text="New Sale" OnClick="fun_NewSale" />
        </div>
        <a href="return.aspx" class="returnButton">Return Product</a>
        <div class="warn" id="message" runat="server"></div>
        <div class="saleInputs">
            <label for="txtProductName">Product Name:</label>
            <asp:TextBox ID="txtProductName" runat="server" placeholder="Enter Product Name..." autocomplete="off"></asp:TextBox>

            <label for="txtProductId">Product ID:</label>
            <asp:TextBox ID="txtProductId" runat="server" placeholder="Enter Product ID..."></asp:TextBox>
            <label for="txtPrice">Price:</label>
            <asp:TextBox ID="txtPrice" runat="server" type="text" min="1" step="1" placeholder="Enter Price..."></asp:TextBox>
            <label for="txtQuantity">Quantity:</label>
            <asp:TextBox ID="txtQuantity" runat="server" type="text" min="1" value="1" ></asp:TextBox>
            <label for="txtDiscount">Discount:</label>
            <asp:TextBox ID="txtDiscount" runat="server" type="text" min="0" value="0" step="0.01"></asp:TextBox>
            <asp:Button class="addButton" ID="btnAddProduct" runat="server" Text="Add Product" OnClick="AddProduct"></asp:Button>
        </div>
        <div id="bill" runat="server" class="bill">
            <div class="Saleid" id="Saleid" runat="server"></div>
            <h2>Bill</h2>
            <table id="myTable" runat="server">
                <tr>
                    <th class="space">Product</th>
                    <th class="space">Quantity</th>
                    <th class="space">Price</th>
                    <th>Discount</th>
                </tr>
            </table>
            <div class="total" style="text-align: left; font-size: 18px;">
                Total Amount: Rs: <span id="totalAmount" runat="server">0.00</span>
                <br />
                Total Discount: Rs: <span id="DiscountAmount" runat="server">0.00</span>
                <br />
                Grand Total: Rs: <span id="grandTotal" runat="server">0.00</span>
            </div>
            <asp:Button ID="btnCompleteBill" class ="complete_bill" runat="server" Text="Complete Bill"  onclick="CompleteBill" />
            <asp:Button ID="btnPrintBill" class ="print_bill" runat="server" Text="Print" onclick="PrintBill"  style= "display: none;" />
            <label for="CustomerName">Customer Name:</label>
            <asp:TextBox ID="txtCustomerName" runat="server" style="margin-left: 12px;padding: 8px;margin-top: 100px;box-sizing: border-box;border: 2px solid rgb(139, 130, 143);border-radius: 5px;width: 300px;" ></asp:TextBox>
            <br />
            <label for="CustomerPhNo">Customer Ph #:</label>
            <asp:TextBox ID="txtCustomerPhNo" runat="server" style="margin-left: 17px;padding: 8px;margin-top: 24px;box-sizing: border-box;border: 2px solid rgb(139, 130, 143);border-radius: 5px;width: 300px;" ></asp:TextBox>
        </div>
    </div>

        <script>
            $('#txtProductName').keyup(function () {
                var searchText = $('#txtProductName').val();
                if (searchText.length === 0) {
                    return;
                }
                $.ajax({
                    type: "GET",
                    url: "YourPage.aspx/GetProductSuggestions",
                    data: { searchText: searchText },
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (response) {
                        var list = $('#suggestionList');
                        list.empty();
                        response.d.forEach(function (item) {
                            var li = $('<li>').text(item.Name);
                            li.click(function () {
                                $('#txtProductName').val(item.Name);
                                $('#txtProductId').val(item.Id);
                                $('#txtPrice').val(item.Price);
                                $('#txtQuantity').val(1); // Reset quantity to 1
                                $('#txtDiscount').val(0); // Reset discount to 0
                                list.empty();
                            });
                            list.append(li);
                        });
                    }
                });
            });
        </script>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
