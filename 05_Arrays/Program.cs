using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //string[] colors = new string[4];  // Bu şekilde dizi tanımlanır. Dizi boyutu 4'tür.
            //colors[0] = "Red"; // elemanlar böyle atılır.
            //colors[1] = "Green";
            //colors[2] = "Blue";
            //colors[3] = "Yellow";
            //Console.WriteLine(colors[2]);


            //string[] cities = new string[5]; // 5 elemanlı bir dizi tanımladık.
            //cities[0] = "Miami";
            //cities[1] = "New York";
            //cities[2] = "Los Angeles";
            //cities[3] = "Chicago";
            //cities[4] = "Houston";

            //Console.WriteLine("Dizinin boyutu: " + cities.Length); // Dizinin boyutunu yazdırır.
            //Console.WriteLine("Dizinin 3. elemanı: " + cities[2]); // 3. elemanı yazdırır.


            //int[] numbers = new int[5]; // 5 elemanlı bir integer dizisi tanımladık.
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 45;
            //numbers[3] = 42;
            //numbers[4] = 40;
            //Console.WriteLine(numbers[4]); 


            //string[] fruits = { "Apple", "Banana", "Cherry", "Date", "Elderberry" }; // Dizi tanımlarken elemanları da atayabiliriz.
            //Console.WriteLine("Dizinin boyutu: " + fruits.Length);
            //Console.WriteLine("Dizinin 2. elemanı: " + fruits[1]);
            //for (int i = 0; i <fruits.Length; i++)
            //{
            //    Console.WriteLine(fruits[i]);
            //}




            //char[] letters = { 'A', 'B', 'C', 'D', 'E' }; // Karakter dizisi tanımladık.

            //for (int i = 0; i < letters.Length; i++)
            //{
            //    Console.WriteLine(letters[i]);
            //}



            //int[] myArray = { 45, 98, 23, 56, 78, 12, 34, 67, 89, 90 };
            //int max = myArray[0], min = myArray[0];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > max)
            //    {
            //        max = myArray[i];
            //    }
            //    if (myArray[i] < min)
            //    {
            //        min = myArray[i];
            //    }
            //}
            //Console.WriteLine("Dizinin en büyük elemanı: " + max+"\nDizinin en küçük elemanı: "+min);

            //Console.Read();
            #endregion



            #region Dizi Metotları


            //string[] names = { "Alice", "Kob", "Charlie", "David", "Eve" };
            //Array.Sort(names); // Diziyi sıralar küçükten büyüğe doğru.
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine("Sıralanmış dizinin elemanları: " + names[i]);
            //}


            //Array.Reverse(names); // Diziyi ters çevirir.
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine("Ters dizinin elemanları: " + names[i]);
            //}

            //Array.IndexOf(names, "Charlie"); // Dizideki elemanın indeksini bulur.

            //int[] myArray = { 45, 98, 23, 56, 78, 12, 34, 67, 89, 90 };
            //int max = myArray.Max();    // Dizinin en büyük elemanını bulur.
            //int min = myArray.Min();    // Dizinin en küçük elemanını bulur.




            //Console.Read();
            #endregion




            #region Array Input Alma

            //String[] cities = new string[5];


            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i+1}. şehri giriniz: "); // $ işareti pythondaki f string ile aynı işlevdedir
            //    cities[i] = Console.ReadLine();
            //}



            //Console.Read();
            #endregion

        }
    }
}
