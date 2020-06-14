using System;
using System.Data;

namespace AdventureData
{
    class Program
    {
        static void Main(string[] args)
        {
            const string productsFilePath = "C:\\products.csv"; 

            DataTable dtProducts = ImportData.GetProducts();

            ExportData.ToCSV(dtProducts, productsFilePath);

            ExportData.GetProductList(dtProducts);

            ExportData.GetProductJson(dtProducts);
        }
    }
}
