using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_SQL_CRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("***** Menü Sipariş Paneli *****");
            //Console.WriteLine();
            //Console.WriteLine("---------------------");

            #region Tek bir sütuna ekleme yapma

            //Console.Write("Eklemek istediğiniz kategori adı: ");
            //string categorNeme = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=EYCEMCI\\SQLEXPRESS; initial catalog=CSharpEgitim; integrated security=true");
            //connection.Open();  // bağlantıyı açtık

            //SqlCommand cmd = new SqlCommand("insert into Table_1 (CategoryName) values (@p1)",connection);
            //// insert into eklemeye yarar
            //// Table_1 işlem yapacağımız tablodur
            //// CategoryName ekleme ayapılacak sütundur
            //// p1'den değer al
            //// connection ekledik veri tabanını belirtmek için

            //cmd.Parameters.AddWithValue("@p1",categorNeme);
            //// bizim vereceğimiz değeri atadık
            //cmd.ExecuteNonQuery();
            //// koşulsuz şekilde sorguyu çalıştır

            //connection.Close();

            //Console.WriteLine("Kategori başarıyla eklendi");

            #endregion


            #region Birden Fazla Sütuna Ekleme Yapma


            // string productName;
            // decimal price;

            // Console.Write("Eklemek istediğiniz ürün: ");
            // productName = Console.ReadLine();
            // Console.Write("Eklemek istediğiniz ürünün fiyatı: ");
            // price = decimal.Parse(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data Source=EYCEMCI\\SQLEXPRESS; initial catalog=CSharpEgitim; integrated security=true");
            //connection.Open();
            // SqlCommand command = new SqlCommand("insert into Table_2 (ProductName,ProductPrice,ProductStatus) values (@p1,@p2,@p3)", connection);
            // command.Parameters.AddWithValue("@p1",productName);    
            // command.Parameters.AddWithValue("@p2",price);    
            // command.Parameters.AddWithValue("@p3",true);    

            // command.ExecuteNonQuery();

            // connection.Close();
            // Console.WriteLine("Başarıyla eklendi");


            #endregion

            #region Ürün Lİsteleme

            //SqlConnection connection = new SqlConnection("Data Source=EYCEMCI\\SQLEXPRESS; initial Catalog=CSharpEgitim;" +
            //    " integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From Table_2", connection);
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

            #region Ürün Silme

            //Console.Write("Silinecek ürünün id'si: ");
            //int productID = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=EYCEMCI\\SQLEXPRESS; initial Catalog=CSharpEgitim;" +
            //    " integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From Table_2 Where ProductId=@productID", connection);
            //// delete komutu silmeye yarar
            //// @ ile değer veririz

            //command.Parameters.AddWithValue("@productID", productID);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Silme işlemi başarıyla gerçekleşti");

            #endregion


            #region Ürün Güncelleme

            //Console.Write("Güncellenecek ürünün id'si: ");

            //int productID = int.Parse(Console.ReadLine());
            //Console.Write("Güncellenecek ürünün adı: ");
            //string productName = Console.ReadLine();
            //Console.Write("Güncellenecek ürünün fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data Source=EYCEMCI\\SQLEXPRESS; initial Catalog=CSharpEgitim;" +
            //   " integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Update Table_2 Set ProductName=@p1,ProductPrice=@p2 Where ProductId=@p3", connection);
            //// update komutu güncellemeye yarar
            //// set ile ayarlarız
            //// where ile hangi id'yi güncelleyeceğimizi belirtiyoruz
            //command.Parameters.AddWithValue("@p1", productName);
            //command.Parameters.AddWithValue("@p2", productPrice);
            //command.Parameters.AddWithValue("@p3", productID);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Güncelleme işlemi başarıyla gerçekleşti");
            //Console.Read();


            #endregion
        }


    }
    }

