using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            //Foreach(1;2;3;4)

            //1:Değişken Türü
            //2:Değişken Adı
            //3:In
            //4:Liste, Koleksiyon, Dizi

            //string[] cities = { "milano","roma","budapeşte","ankara","istanbul","varşova" };

            //foreach(string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //foreach (int x in numbers)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //foreach (int x in numbers)
            //{   if (x % 2 == 0)
            //    {
            //        Console.WriteLine(x);
            //    }
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>
            //{
            //    1,2,3,4,5
            //};

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //string word = "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}



            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            //Console.WriteLine("*** C# Eğitim Kampı Sınav Uygulaması ***");
            //Console.WriteLine();

            //// Sınıftaki öğrenci sayısını kullanıcıdan alma
            //Console.WriteLine("------------------------------------------");
            //Console.Write("Sınıfınızda kaç öğrenci var?: ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------------------");

            //// Öğrenci isimleri ve not ortalamalarını tutacak diziler
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i + 1}. Öğrencinin ismini giriniz: ");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamResult = 0;

            //    //Her öğrenci için 3 sınav notu girişi
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} için {j + 1}. sınav notunu giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult += value;
            //    }
            //    Console.WriteLine();

            //    studentExamAvg[i] = totalExamResult / 3;

                
            //}
            //// Öğrencilerin ortalanası
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine("------------------------------------------");
            //    Console.WriteLine($"{studentNames[i]} isimli öğrencinin not ortalaması: {studentExamAvg[i]}");

            //    // Öğrencilerin ortalanası ve geçip kalma durumunu yazdırma
            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} isimli öğrenci geçti.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} isimli öğrenci kaldı.");
            //    }
            //    Console.WriteLine("------------------------------------------");

            //}


            #endregion

            Console.Read();

        }
    }
}
