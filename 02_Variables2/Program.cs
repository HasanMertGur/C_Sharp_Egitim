using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DOUBLE_DEĞİŞKENLER

            //double num = 19.05;
            //Console.WriteLine(num);


            //Console.WriteLine("******** PRICE LIST**********");

            //double applePrice = 14.85,
            //    orangePrice = 20.95,
            //    strawwberyPrice = 45,
            //    potatoPrice = 9.74;
            //Console.WriteLine("Elma fiyatı: "+ applePrice);
            //Console.WriteLine("Portakal fiyatı: "+ orangePrice);
            //Console.WriteLine("Çilek fiyatı: "+ strawwberyPrice);
            //Console.WriteLine("Patates fiyatı: "+ potatoPrice);


            //double appleGram = 1.245,
            //    orangeGram = 2.650,
            //    strawwberyGram = 0.750,
            //    potatoGram = 4.859;

            //Console.WriteLine("Elma: "+(applePrice*appleGram));
            //Console.WriteLine("Portakal: "+(orangeGram*orangePrice));
            //Console.WriteLine("Çilek: "+(strawwberyGram*strawwberyPrice));
            //Console.WriteLine("Patates: "+(potatoGram*potatoPrice));
            //double sum = (appleGram * applePrice) + (orangePrice * orangeGram) + (strawwberyPrice * strawwberyGram) + (potatoPrice * potatoGram);
            //Console.WriteLine();
            //Console.WriteLine("Total: " + sum);

            #endregion




            #region CHAR_DEĞİŞKENLER

            // char değişkenler "" değil '' içinde tanımlanır

            //char symbol = 'A';
            //Console.WriteLine(symbol);

            #endregion



            #region STRING INPUTLAR

            //Console.WriteLine("***Turkish Airlines Passenger Information***");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict,
            //    passengerCity, passengerAge, passengerID;

            //Console.Write("Passenger Name: "); // Input alırken write kullanırız ki alt satıra atmasın
            //passengerName = Console.ReadLine(); // bu şekilde readline olarak input alırız

            //Console.Write("Passenger Surname");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Passenger District: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Passenger City: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Passanger Age: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Passanger ID: ");
            //passengerID = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("----------TICKET--------");
            //Console.WriteLine("Passenger: "+passengerName+passengerSurname);
            //Console.WriteLine("Region: "+passengerDistrict+"/"+passengerCity);
            //Console.WriteLine("Age: "+passengerAge);
            //Console.WriteLine("ID: "+passengerID);

            #endregion




            #region INTEGER INPUT ve DÖNÜŞÜMLER

            //int shoePrice=1000, compPrice=20000, chairPrice=5000, 
            //    tvPrice=12000;
            //int shoeCount, compCount, chairCount, tvCount;

            //Console.Write("Kaç tane ayakkabı alacaksınız: ");
            //shoeCount = int.Parse(Console.ReadLine());
            //// Parse methodu 32 bit depolayabiliyor readline string döndürür
            //// parse onu int şeklinde dönüştürür
            //Console.Write("Kaç tane pc alacaksınız: ");
            //compCount = int.Parse(Console.ReadLine());
            //Console.Write("Kaç tane sandalye alacaksınız: ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Kaç tane tvCount alacaksınız: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice=(shoeCount*shoePrice)+(compCount * compPrice) +(chairCount*chairPrice)+(tvCount*compPrice);

            //Console.WriteLine();

            //Console.WriteLine("Toplam ücret: "+totalPrice);
            #endregion




            #region DOUBLE INPUT

            //double ex1, ex2, ex3, result;

            //Console.Write("1. Sınavı giriniz: ");
            //ex1 = double.Parse(Console.ReadLine());
            //Console.Write("2. Sınavı giriniz: ");
            //ex2 = double.Parse(Console.ReadLine());
            //Console.Write("3. Sınavı giriniz: ");
            //ex3 = double.Parse(Console.ReadLine());

            //result = (ex1+ex2 + ex3)/3;
            //Console.WriteLine();
            //Console.WriteLine("Ortalama: "+result);

            #endregion



            #region CHAR INPUT

            //char gender;

            //Console.Write("Cinsiyet giriniz: ");
            //gender = char.Parse(Console.ReadLine());

            #endregion
        }
    }
}
