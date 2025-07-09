using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud --> Create, Read, Update, Delete

            Console.WriteLine("**** Menü Sipariş İşlem Paneli ****");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------");

            #region Kategori ekleme işlemleri
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=MERTALII\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("INSERT into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori Başarıyla Eklendi!");
            #endregion

            #region Ürün ekleme işlemleri
            //string productName;
            //decimal productPrice;
            ////bool productStatus;


            //Console.Write("Eklemek istediğiniz Ürün Adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Eklemek istediğiniz Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=MERTALII\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("INSERT into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productprice,@productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();

            //connection.Close();
            //Console.WriteLine("Ürün Başarıyla Eklendi!");
            #endregion

            #region Ürün Listeleme İşlemleri

            //SqlConnection connection = new SqlConnection("Data Source=MERTALII\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();
            #endregion

            #region Ürün Silme İşlemleri

            //SqlConnection connection = new SqlConnection("Data Source=MERTALII\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //Console.Write("Silmek istediğiniz Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlCommand command = new SqlCommand("DELETE FROM TblProduct WHERE ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //Console.WriteLine("Ürün Başarıyla Silindi!");


            //connection.Close();


            #endregion

            #region Ürün Güncelleme İşlemleri

            //SqlConnection connection = new SqlConnection("Data Source=MERTALII\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();


            //Console.Write("Güncellemek istediğiniz Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellemek istediğiniz Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellemek istediğiniz Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());
            //SqlCommand command = new SqlCommand("UPDATE TblProduct SET ProductName=@productName, ProductPrice=@productPrice WHERE ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.ExecuteNonQuery();

            //connection.Close();
            //Console.WriteLine("Ürün Başarıyla Güncellendi!");


            #endregion



            Console.Read();

        }
    }
}
