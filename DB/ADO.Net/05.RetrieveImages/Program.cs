using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Drawing.Imaging;

//Write a program that retrieves the images for all categories in the Northwind database 
//and stores them as JPG files in the file system.

namespace RetrieveImages
{
    class Program
    {
        static void Main()
        {
            SqlConnection dbConn = new SqlConnection(
                "Server=.\\SQLSERVER2012; Database=Northwind; Integrated Security = true");

            dbConn.Open();

            using (dbConn)
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT c.CategoryName, c.Picture FROM Categories c", dbConn);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                int offset = 78;
                using (reader)
                {
                    while (reader.Read())
                    {
                        string name = (string)reader["CategoryName"];

                        if (name.Contains('/'))
                        {
                            name = name.Replace('/', ' ');
                        }

                        Console.WriteLine(name + " image saved");

                        byte[] picturesBytes = reader["Picture"] as byte[];

                        MemoryStream stream = new MemoryStream(
                            picturesBytes, offset,
                            picturesBytes.Length - offset);

                        Image img = Image.FromStream(stream);
                        using (img)
                        {
                            img.Save("..\\..\\" + name + ".jpg", ImageFormat.Jpeg);
                        }
                    }
                }
            }
        }
    }
}
