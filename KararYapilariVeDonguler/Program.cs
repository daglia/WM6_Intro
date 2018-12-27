using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilariVeDonguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operatörler
            //Matematiksel operatörler

            int sayi1 = 6, sayi2 = 10;
            double sayi3 = 0;

            // =
            // + - * /
            sayi3 = sayi2 / (sayi1+0d);
            Console.WriteLine(sayi3);

            sayi1 += sayi2;
            sayi1++;
            ++sayi1;

            sayi1 = 5;
            sayi2 = 10;

            sayi1 = sayi1 + sayi2;
            sayi2 = sayi1 - sayi2;
            sayi1 = sayi1 - sayi2;

            // % mod (kalanlı bölme)

            // +

            string sonuc = "Toplam: " + sayi3;
            Console.WriteLine(sonuc);
            Console.WriteLine("Sonuc: " + 3 + 6 + 9);
            Console.WriteLine("Sonuc: " + (3 + 6 + 9));

            //Karşılaştırma operatörleri
            // < > <= >= == != !    ---- true/false
            bool dogruMu = sayi1 > sayi2;

            dogruMu = sayi1 == sayi2;
            dogruMu = !dogruMu;

            //Mantıksal operatörler
            // & | && ||

            dogruMu = sayi1 < sayi2 & sayi2 % 2 == 0;
            dogruMu = (sayi1 < 0 || sayi1 > 100) && sayi1 % 2 == 0;

            // if eğer anlamında. eğer içine yazılan ifade doğru ise if bloğu, değilse else bloğu çalışır.

            dogruMu = sayi1 % 2 == 0;

            if(dogruMu)
            {
                Console.WriteLine("Sayı1 çifttir.");
            }
            else
            {
                Console.WriteLine("Sayı1 tektir.");
            }

            Console.WriteLine("Sayi1 " + (dogruMu ? "çifttir" : "tektir"));
            Console.WriteLine(sayi1 % 2 == 0 ? "Sayı1 çifttir" : "Sayı1 tektir");

            double notOrtalama = 50;

            if(notOrtalama < 50)
            {
                Console.WriteLine("Kaldınız.");
            }
            else if(notOrtalama < 90)
            {
                Console.WriteLine("Geçtiniz.");
            }
            else
            {
                Console.WriteLine("Üstün başarı.");
            }

            DayOfWeek bugun = DateTime.Now.DayOfWeek;
            
            if(bugun == DayOfWeek.Monday)
            {
                Console.WriteLine("Bugün Pazartesi.");
            }

            switch (bugun)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("Pazar");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Pazartesi");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("Salı");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Çarşamba");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Perşembe");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Cuma");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Cumartesi");
                    break;
            }

            // Döngüler

            while (true)
            {
                Console.WriteLine(DateTime.Now);
                if (DateTime.Now.Second < 30 || DateTime.Now.Second > 50)
                    break;
            }

            Console.WriteLine("test");

            do
            {
                Console.WriteLine(DateTime.Now);
                if (DateTime.Now.Second < 30 || DateTime.Now.Second > 50)
                    break;
            } while (true);

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            //program çalıştığında ekrana bir doktorun muayene saatlerini yazan program. 15er dakika ara ile yazacak. mesai 09.00 ile 16.30 arası olacak. 12.00-13.00 öğle tatili

        }
    }
}