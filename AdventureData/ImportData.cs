﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace AdventureData
{
    public class ImportData
    {
        public static DataTable GetProducts()
        {
            DataTable dtProducts = new DataTable();
            dtProducts.Columns.Add("ProductID", typeof(int));
            dtProducts.Columns.Add("ProductName", typeof(string));
            dtProducts.Columns.Add("SupplierID", typeof(int));
            dtProducts.Columns.Add("CategoryID", typeof(int));
            dtProducts.Columns.Add("QuantityPerUnit", typeof(string));
            dtProducts.Columns.Add("UnitPrice", typeof(decimal));
            dtProducts.Columns.Add("UnitsInStock", typeof(int));
            dtProducts.Columns.Add("UnitsOnOrder", typeof(int));
            dtProducts.Columns.Add("ReorderLevel", typeof(Int16));
            dtProducts.Columns.Add("Discontinued", typeof(bool));

            dtProducts.Rows.Add(1, "Chai", 1, 1,
                    "10 boxes x 20 bags", 18.00, 39, 0, 10, 0);
            dtProducts.Rows.Add(2, "Chang", 1, 1,
                    "24 - 12 oz bottles", 19.00, 17, 40, 25, 0);
            dtProducts.Rows.Add(3, "Aniseed Syrup", 1, 2,
                    "12 - 550 ml bottles", 10.00, 13, 70, 25, 0);
            dtProducts.Rows.Add(4, "Chef Anton's Cajun Seasoning", 2, 2,
                    "48 - 6 oz jars", 22.00, 53, 0, 0, 0);
            dtProducts.Rows.Add(5, "Chef Anton's Gumbo Mix", 2, 2,
                    "36 boxes", 21.35, 0, 0, 0, 1);
            dtProducts.Rows.Add(6, "Grandma's Boysenberry Spread", 3, 2,
                    "12 - 8 oz jars", 25.00, 120, 0, 25, 0);
            dtProducts.Rows.Add(7, "Uncle Bob's Organic Dried Pears", 3, 7,
                    "12 - 1 lb pkgs.", 30.00, 15, 0, 10, 0);
            dtProducts.Rows.Add(8, "Northwoods Cranberry Sauce", 3, 2,
                    "12 - 12 oz jars", 40.00, 6, 0, 0, 0);
            dtProducts.Rows.Add(9, "Mishi Kobe Niku", 4, 6,
                    "18 - 500 g pkgs.", 97.00, 29, 0, 0, 1);
            dtProducts.Rows.Add(10, "Ikura", 4, 8,
                    "12 - 200 ml jars", 31.00, 31, 0, 0, 0);

            return dtProducts;
        }
    }
}
