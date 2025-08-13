using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_veritabani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- C# Veri Tabanı Sorgulama ----");
            Console.WriteLine("1) Kategoriler");
            Console.WriteLine("2) Ürünler");
            Console.WriteLine("3) Siparişler");
            Console.WriteLine("4) Çıkış");
            Console.Write("Sorgulamak istediğiniz numarayı seçin: ");

            string numara;
            numara = Console.ReadLine();

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-624K52L; initial Catalog=first_database; integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Select ProductName,ProductPrice From ProductTable",connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
