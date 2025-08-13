using System;
using System.Data;
using System.Data.SqlClient;

namespace _3_veritabani2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CRUD: Create - Read- Update - Delete
            #region Ürün Ekleme
            //string productName;
            //decimal productPrice;
            ////bool productStock;

            //Console.Write("Ürün adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Birim Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-624K52L; initial Catalog=first_database; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into Producttable (ProductName,ProductPrice,ProductStock) values (@productName,@productPrice,@productStock)", connection); //buradaki @productName ismi çok önemli değil @a da diyebilirdik, eşlemeyi aşağıda yapıyoruz
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStock", true);
            //command.ExecuteNonQuery();

            //connection.Close();
            //Console.WriteLine("Ürün eklemesi başarılı");
            #endregion

            #region Ürün Listeleme
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-624K52L; initial Catalog=first_database; integrated security=true");
            connection.Open();

            SqlCommand command = new SqlCommand("Select * From ProductTable", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine();
            }

            connection.Close();
            #endregion

            #region Ürün Silme
            //Console.Write("Silmek istediğiniz ürünün ismini girin: ");
            //string productName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-624K52L; initial Catalog=first_database; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From ProductTable Where ProductName=@productName", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.ExecuteNonQuery(); // sorgusuz yürüt

            //Console.WriteLine("Silme işlemi başarıyla gerçekleştirildi");

            //connection.Close();
            #endregion

            #region Ürün Güncelleme
            //Console.Write("Güncellenecek ÜrünID: ");
            //int productID = int.Parse(Console.ReadLine());
            //Console.Write("Güncellenecek Ürün adı: ");
            //string productName = Console.ReadLine();
            //Console.Write("Güncellenecek Ürün fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());
            //Console.Write("Güncellenecek Stok durumu: ");
            //bool productStock = bool.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-624K52L; initial Catalog=first_database; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Update ProductTable Set ProductName=@productName, ProductPrice=@productPrice, ProductStock=@productStock Where ProductID=@productID", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStock", productStock);
            //command.Parameters.AddWithValue("@productID", productID);
            //command.ExecuteNonQuery();

            //Console.WriteLine("Güncelleme başarılı");

            //connection.Close();
            #endregion

            Console.Read();
        }
    }
}
