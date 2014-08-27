using System;
using System.Linq;
using System.Data.SqlClient;

namespace RetrieveNumOfRows
{
    class Program
    {
        static void Main()
        {
            SqlConnection sqlCon = new SqlConnection("Server=.;"
                + "Database=Northwind; Integrated Security=true");

            sqlCon.Open();

            using (sqlCon)
            {
                
            }
        }
    }
}
