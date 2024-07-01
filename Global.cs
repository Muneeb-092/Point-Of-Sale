using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Point_Of_Sale.WebForm2;

namespace Point_Of_Sale
{
    public class Global
    {
        public static Product[] products = new Product[100];
        public static int i = 0;
        public static int TotalAmount = 0;
        public static int TotalDiscount = 0;
        public static int GrandTotal = 0;
        public static int saleInitaited = 0;
        public static int saleClosed = 0;
        public static int productAdded = 0;

        public static int Login = 0;
        public static int Access = 0;
        public static string User = "";
        public static DateTime loginTime;
    }
}