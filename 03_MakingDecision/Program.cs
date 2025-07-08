using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If Else

            //Console.Write("Lütfen bir şifre giriniz: ");
            //string password;
            //password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}


            //-------------------------


            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Veriler doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı Bilgi");
            //}

            //-------------------------

            //int number;
            //Console.Write("Sayıyı Giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Yanlış");
            //}

            //-------------------------

            //int exam1, exam2, exam3, average;
            //string result = "Hata!";

            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç İyi";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç Çok İyi";
            //}

            //-------------------------

            //string city;
            //Console.Write("Lütfen Şehri Giriniz: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}


            //-------------------------

            //Console.Write("Lütfen bir kullanıcı adı giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz");
            //}

            //-------------------------

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //------------------------------------------

            //Console.Write("Lütfen 1.sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("1.Sayının 2.Sayıya bölümünden kalan: " + result);

            //------------------------------------------

            //Console.Write("Lütfen bir sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());


            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı Çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Tektir");
            //}
            #endregion

            #region Char Değişkenler ile Karar Yapıları


            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}

            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}

            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}

            #endregion

            #region Örnek proje uygulaması
            //Console.WriteLine("****** C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Detayları görmek istediğiniz menü seçiniz: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Ana Yemekler ------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Köri Soslu Tavuk");
            //    Console.WriteLine("2- Kızartma Tabağı");
            //    Console.WriteLine("3- Fasülye Pilavı");
            //    Console.WriteLine("4- Fırında Somon");
            //    Console.WriteLine("5- Patlıcan Musakka");
            //    Console.WriteLine("6- Köri Soslu Tavuk");
            //    Console.WriteLine("------------ Ana Yemekler ------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Çorbalar ------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorba");
            //    Console.WriteLine("------------ Çorbalar ------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Pizzalar ------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("------------ Pizzalar ------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ İçecekler ------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("------------ İçecekler ------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Tatlılar ------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Triliçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("------------ Tatlılar ------------");
            //    Console.WriteLine();
            //}


            #endregion

            #region Switch Case

            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber= int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{ case 1: Console.WriteLine("Ocak Ayı"); break;
            //  case 2: Console.WriteLine("Şubat Ayı"); break;
            //  case 3: Console.WriteLine("Mart Ayı"); break;
            //  case 4: Console.WriteLine("Nisan Ayı"); break;
            //  case 5: Console.WriteLine("Mayıs Ayı"); break;
            //  case 6: Console.WriteLine("Haziran Ayı"); break;
            //  case 7: Console.WriteLine("Temmuz Ayı"); break;
            //  case 8: Console.WriteLine("Ağustos Ayı"); break;
            //  case 9: Console.WriteLine("Eylül Ayı"); break;
            //  case 10: Console.WriteLine("Ekim Ayı"); break;
            //  case 11: Console.WriteLine("Kasım Ayı"); break;
            //  case 12: Console.WriteLine("Aralık Ayı"); break;
            //  default: Console.WriteLine("Geçersiz ay numarası!"); break;
            //}

            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;
            
            //Console.Write("Lütfen 1.Sayıyı Giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen İşlem Sembolünü Giriniz (+, -, *, /): ");
            //symbol = char.Parse(Console.ReadLine());
            //Console.WriteLine();


            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Sonuç: " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Sonuç: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Sonuç: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Sonuç: " + result);
            //        break;

            //}

            #endregion

            Console.Read();
        }
    }
}
