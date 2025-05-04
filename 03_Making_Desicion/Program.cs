using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Making_Desicion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IF-ELSE

            //Console.Write("Lütfen bir şifre giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}


            //string capital, country;

            //Console.Write("Lütfen bir başkent giriniz: ");
            //capital = Console.ReadLine();
            //Console.Write("Lütfen bir ülke giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "Ankara" && country == "Türkiye")
            //{
            //    Console.WriteLine("Doğru");
            //}
            //else if (capital == "Paris" && country == "Fransa")
            //{
            //    Console.WriteLine("Doğru");
            //}
            //else if (capital == "Washington" && country == "ABD")
            //{
            //    Console.WriteLine("Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış");
            //}


            //int exam1,exam2,exam3;
            //Console.Write("Exam1: ");
            //exam1=int.Parse(Console.ReadLine());
            //Console.Write("Exam2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Exam3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //int average = (exam1 + exam2 + exam3) / 3;

            //if (average>0 & average<=50)  // & and demektir
            //{
            //    Console.WriteLine("Sınıfta kaldınız");
            //}
            //if(average>50 & average <= 70)
            //{
            //    Console.WriteLine("Ortalama sonuç");
            //}
            //if (average>70 & average<=84)
            //{
            //    Console.WriteLine("İyi sonuç");
            //}
            //if (average > 84)
            //{
            //    Console.WriteLine("Çok iyi sonuç");
            //}


            // | ya da demektir


            //Console.Write("Lütfen bir kulllanıcı adı giriniz: ");
            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("Yönetici değilsiniz");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz admin");
            //}


            //Console.Read();
            #endregion



            #region bi değişkeni direkt yazdırmak istersek else kullanmak zorundayız
            #endregion


            #region MOD İŞLEMLERİ
            //Console.Write("Enter num1: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter num2: ");
            //int num2 = int.Parse(Console.ReadLine());

            //int remainder = num1 % num2;

            //Console.WriteLine("1. sayının 2. sayıya bölümünden kalan: " + remainder);


            //char team;
            //Console.Write("Lütfen bir takım sembolü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Takımınız Galatasaray");
            //}
            //if(team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Takımınız Beşiktaş");
            //}
            //
            //
            //Console.Read();
            #endregion



            #region SWITCH CASE

            //Console.WriteLine("******MENU******");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("---------------------------------");

            //int menuItem;
            //Console.Write("Lütfen görmek isediğiniz menü ekranını seçiniz('0' to exit): ");
            //menuItem = int.Parse(Console.ReadLine());

            //    switch (menuItem)
            //    {
            //        case 0:
            //            Console.WriteLine("Çıkış yapılıyor...");
            //            break;
            //        case 1:
            //            Console.WriteLine("Ana yemekler menüsü");
            //            Console.WriteLine("1- Kuzu tandır");
            //            Console.WriteLine("2- Tavuk tandır");
            //            Console.WriteLine("3- Izgara köfte");
            //            break;
            //        case 2:
            //            Console.WriteLine("Çorbalar menüsü");
            //            Console.WriteLine("1- Tarator çorbası");
            //            Console.WriteLine("2- Domates çorbası");
            //            Console.WriteLine("3- Mercimek çorbası");
            //            break;
            //        case 3:
            //            Console.WriteLine("Pizzalar menüsü");
            //            Console.WriteLine("1- Margarita pizza");
            //            Console.WriteLine("2- Klasik pizza");
            //            Console.WriteLine("3- İtalyan pizza");
            //            break;
            //        case 4:
            //            Console.WriteLine("İçecekler menüsü");
            //            Console.WriteLine("1- Ayran");
            //            Console.WriteLine("2- Su");
            //            Console.WriteLine("3- Gazoz");
            //            break;

            //        case 5:
            //            Console.WriteLine("Tatlılar menüsü");
            //            Console.WriteLine("1- Baklava");
            //            Console.WriteLine("2- Kadayıf");
            //            Console.WriteLine("3- Sütlaç");
            //            break;
            //        default:
            //            Console.WriteLine("Geçersiz seçim yaptınız. Tekrar deneyiniz."); break;
            //    }
            
            //Console.Read();

            #endregion
        }
    }
}
