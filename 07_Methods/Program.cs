using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Void Methodlar
            // () bir parantez açıp kapatmak zorundayız

            // Geriye değer döndürmeyen metotlar
            // void olarak tanımlanır
            //void CustomerList()
            //{
            //    Console.WriteLine("Müşteri Listesi");
            //    Console.WriteLine("1. Müşteri");
            //    Console.WriteLine("2. Müşteri");
            //    Console.WriteLine("3. Müşteri");
            //}
            //CustomerList();

            //void sum()
            //{
            //    int x=1,y=2, z = 3;
            //    int result = x + y + z;
            //    Console.WriteLine(result);
            //}
            //sum();


            // C'DEKİ FONKSİYONLARLA AYNI TEK FARK MAİN İÇİNDE TANIMLAYIP ÇALIŞTIRABİLİRZ

            //Console.Read();
            #endregion


            #region Parametre Alan Void Methodlar

            //void customer(string name)
            //{
            //    Console.WriteLine("Müşteri Listesi");
            //    Console.WriteLine(name);
            //}

            //customer("hasan");

            //Console.Read();
            #endregion


            #region Değer Döndüren Methodlar
            // geri döndüreceği değerin türünde tanımlanır

            //string Customer()
            //{
            //    return "Hasan";
            //}
            //Customer();
            // birşey yazdırmaz çünkü write etmedik


            //string StudentCard()
            //{

            //    return "Öğrenci Kartı";
            //}

            //Console.WriteLine(StudentCard());



            //Console.Read();
            #endregion


            #region Parametre Alan Değer Döndüren Methodlar

            //string CountryCard(string country, string capital, string flag_color)
            //{
            //    string result = "Ülke: " + country + "\n" +
            //        "Başkent: " + capital + "\n" +
            //        "Bayrak Rengi: " + flag_color;
            //    return result;
            //}
            //Console.WriteLine(CountryCard(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"), CountryCard("Almanya", "Berlin", "Siyah-Kırmızı-Sarı"), CountryCard("Fransa", "Paris", "Mavi-Beyaz-Kırmızı")));




            //Console.Read();
            #endregion
        }
    }
}
