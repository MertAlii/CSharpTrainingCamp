using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double Değişkenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("****** Fiyat Listesi ******");
            //Console.WriteLine();

            //double applePrice, orangePrince, strawberryPrice, patatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrince = 20.95;
            //strawberryPrice = 45;
            //patatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("------- Elma Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("------- Portakal Fiyatı: " + orangePrince + " TL");
            //Console.WriteLine("------- Çilek Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("------- Patates Fiyatı: " + patatoPrice + " TL");
            //Console.WriteLine("------- Domates Fiyatı: " + tomatoPrice + " TL");
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, patatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //patatoGram = 4.859;
            //tomatoGram =3.745;

            //double appleTotalPrice, orangeTotalPrice, strawberryTotalPrice, patatoTotalPrice, tomatoTotalPrice;

            //appleTotalPrice = applePrice * appleGram;
            //orangeTotalPrice = orangePrince * orangeGram;
            //strawberryTotalPrice = strawberryPrice * strawberryGram;
            //patatoTotalPrice = patatoPrice * patatoGram;
            //tomatoTotalPrice = tomatoPrice * tomatoGram;

            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrince + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + patatoPrice + " - Gramaj: " + patatoGram + " - Toplam Tutar: " + patatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);
            //Console.WriteLine();

            //double shoppingTotalPrice;
            //shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + patatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine("Toplam Alışveriş Tutarı: " + shoppingTotalPrice + " TL");



            #endregion

            #region Char Değişkenler

            //ABCDEFGH
            //DEF...
            //Toplantı Saat 20.00'de
            // " '

            //char symbol;
            //symbol = 'A';

            //Console.WriteLine(symbol);


            #endregion

            #region Klavyeden Veri Alma

            //Console.WriteLine("******* CSharp Hava Yolları Yolcu Bilgisi *******");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Yolcu TC Kimlik Numarası: ");
            //passengerIdentityNumber = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber +  " - Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " "  + passengerDistrict  + " / " + passengerCity + " " + passengerAge);

            #endregion

            #region  Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen Ayakkabı Adetini Giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Bilgisayar Adetini Giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Sandalye Adetini Giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Televizyon Adetini Giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totelPrice;
            //totelPrice = (shoesPrice * shoesCount) + (computerPrice * computerCount) + (chairPrice * chairCount) + (tvPrice * tvCount);
            //Console.WriteLine();
            //Console.WriteLine("Toplam Alışveriş Tutarı: " + totelPrice + " TL");


            #endregion

            #region Klavyeden Onaltılık Sayı İşlemleri

            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen 1. Sınav Notunu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyetinizi Giriniz (E/K): ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " +  gender);
            #endregion



            Console.Read();
        }
    }
}
