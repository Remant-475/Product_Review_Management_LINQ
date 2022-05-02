using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Product_Management_Review_Linq
{
    class DataTableOperations
    {
        public void CreateDataTable()
        {
                 
            DataTable table = new DataTable();
                
            table.Columns.Add("ProductId");
            table.Columns.Add("UserId");
            table.Columns.Add("Rating");
            table.Columns.Add("Review");
            table.Columns.Add("IsLike");
            table.Rows.Add(1, 1, 2, "Good", true);
            table.Rows.Add(2, 1, 4, "Good", true);
            table.Rows.Add(3, 1, 5, "Good", true);
            table.Rows.Add(4, 1, 6, "Good", false);
            table.Rows.Add(5, 1, 2, "nice", true);
            table.Rows.Add(6, 1, 1, "bad", true);
            table.Rows.Add(8, 1, 1, "Good", false);
            table.Rows.Add(8, 1, 9, "nice", true);
            table.Rows.Add(2, 1, 10, "nice", true);
            table.Rows.Add(10, 1, 8, "nice", true);
            table.Rows.Add(11, 1, 3, "nice", true);
            Console.WriteLine("Data Table Created");
        }
    }
}