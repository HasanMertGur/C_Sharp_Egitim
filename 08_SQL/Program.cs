using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_SQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net kütüphanesi kullanırız

            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNum;


            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Lütfen getirmek istediğiniz tablo numaarasını giriniz: ");
            tableNum = Console.ReadLine();
            Console.WriteLine("--------------------------------------------");


            SqlConnection connection = new SqlConnection("Data Source=EYCEMCI\\SQLEXPRESS; initial Catalog=CSharpEgitim;" +
                " integrated security=true");
            // Data Source: Sql Server'ın ismi
            // initial Catalog: Sql Server'da hangi veri tabanını kullanacağımızı belirtiyoruz
            // integrated security: Sql Server'a bağlanmak için Windows kimlik bilgilerini kullanacağımızı belirtiyoruz yani true
            // SqlConnection bir class'tır
            // connection bu classtan türetilen bir instance(nesne)'dır


            SqlCommand command = new SqlCommand("Select * From Table_1",connection);
            // SqlCommand classından command instance'ı oluşturduk içine de yapmak istediğimiz query'i yazdık
            // hangi databese'e bağlanacağımızı SqlConnection class'ından türettiğimiz connection instance'ı ile belirttik


            SqlDataAdapter adapter = new SqlDataAdapter(command);
            // bu kodlarımızla sql arasında bir köprü olur


            DataTable table = new DataTable();
            // bize ramden bir alan sağladı


            adapter.Fill(table);
            // adapter ile table'ı doldurduk

            connection.Close();
            // connection'ı kapatıyoruz

            foreach (DataRow row in table.Rows)
            {
                // DataRow: Sql'den gelen satırları temsil eder
                // data table'dan gelen bir sınıf türüdür

                foreach (var item in row.ItemArray)  // var tüm değişken türlerini kapsar
                                                     // table'ın satrılarını tek tek geziyoruz item ile
                                                     // rowdan gelen içeriğin satırlarını okuruz row.ItemArray ile
                {
                    Console.Write(item.ToString());    // ToString: item'ı string'e çevirir
                }
                Console.WriteLine();                // her satırdan sonra bir alt satıra geçiyoruz
            }
            Console.Read();
        }
    }
}
