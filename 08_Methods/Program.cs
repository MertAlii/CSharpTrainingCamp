using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar
            //Geriye değer döndürmeyen metotlar
            // Customer--> Listele , Ekle, Sil, Güncelle
            //void

            //void CustomerList()
            //{
            //    Console.WriteLine("Mert Ali Alkan");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Mehmet Demir");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();

            //--------------------------------

            //void sum()
            //{
            //    int x = 10;
            //    int y = 20;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //sum();

            //--------------------------------

            #endregion

            #region Geriye Değer Döndürmeyen Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mert Ali Alkan");

            //--------------------------------

            //void CustomerCard(string name, string surName)
            //    {
            //    Console.WriteLine("Müşteri Adı: " + name + " " + surName);            
            //    }

            //CustomerCard("Mert Ali", "Alkan");
            //CustomerCard("Ayşe", "Yıldız");

            //--------------------------------

            #endregion

            #region Geriye Değer Döndürmeyen Parametreli Metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(10, 20, 30);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Mert Ali Alkan";
            //}
            //CustomerName();

            //--------------------------------

            //string StudentCard()
            //{
            //    string name = "Mert Ali";
            //    string surName = "Alkan";
            //    return name + " " + surName;
            //}
            //Console.WriteLine(StudentCard());





            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkenti: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x,y, z;
            //Console.Write("Lütfen Ülke Adını Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Lütfen Başkent Adını Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Lütfen Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));
            //--------------------------------
            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(10, 20));

            //--------------------------------



            #endregion

            #region Örnek Uygulama
            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + " isimli öğrenci sınavı geçti Ortalama: " + result;
            //    }
            //    else
            //    {
            //        return student + " isimli öğrenci sınavı geçemedi Ortalama: " + result;
            //    }
            //}

            //Console.WriteLine(ExamResult("Mert Ali Alkan", 60, 70, 80));
            //Console.WriteLine(ExamResult("Ayşe Yıldız", 30, 30, 45));
            #endregion

            Console.Read();
        }
    }
}
