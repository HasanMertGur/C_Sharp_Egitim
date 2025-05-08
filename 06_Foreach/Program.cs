using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Kullanımı
            // pythondaki for(i in sth) gibi

            // foreach(1,2,3,4)
            // 1:değişken türü
            // 2:değişken adı
            // 3: In
            // 4: Liste, Koleksiyon, Dizi

            //string[] cities = { "İstanbul", "Ankara", "İzmir", "Kütahya", "Mersin", "Niğde" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}



            //Console.Read();
            #endregion



            #region Listeler

            // List<değişken_türü> liste_adı = new List<değişken_türü>();

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6,
            //};
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);}




            //Console.Read();
            #endregion


            #region Örnek Sınav Sistemi

            //Console.WriteLine("****** SINAV UYGULAMASI ******");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            
            //// Öğrenci sayısını al
            //Console.WriteLine("--------------------------------");
            //Console.Write("Sınıfınızda kaç öğrenci vardır: ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("--------------------------------");

            //// Öğrenci isim ve ortalamalarını tutacak dizileri tanımla
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for(int i = 0; i<studentCount; i++)
            //{
            //    Console.Write($"{i+1}. Öğrencinin ismini giriniz: ");
            //    studentNames[i] = Console.ReadLine();

            //    double total = 0;

            //    for(int j = 0; j<3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} Öğrencisinin {j + 1}. sınav notunu giriniz: ");
            //        double examScore = double.Parse(Console.ReadLine());
            //        total += examScore;
            //    }

                
            //studentExamAvg[i] = total / 3;
            //}

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine($"{studentNames[i]} Öğrencisinin not ortalaması: {studentExamAvg[i]}");
            //    if (studentExamAvg[i] < 60)
            //    {
            //        Console.WriteLine($"{studentNames[i]} Öğrencisi sınıfta kaldı.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} Öğrencisi sınıfı geçti.");
            
            //}

            //Console.Read();
            #endregion
        }
    }
}
