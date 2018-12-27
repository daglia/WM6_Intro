using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Selamlama();
            Selamlama();
            Selamlama();
            Selamlama();
            Selamlama();

            int toplam = Topla(3, 6,9,4,5,2,3,5,6,6);
            Console.WriteLine("Toplam: " + toplam);

            Console.WriteLine(Disc(1, 2, 1));
        }
        
        /// <summary>
        /// Program her çalıştığında kullanıcıya selam vermeye yarar.
        /// </summary>

        static void Selamlama()
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
                return;
            Console.WriteLine("Merhaba methodu");
        }


        /// <summary>
        /// Verilen 2 tam sayıyı toplayan metod.
        /// </summary>
        /// <param name="sayi1">Toplama yapılacak birinci sayı</param>
        /// <param name="sayi2">Toplama yapılacak ikinci sayı</param>
        /// <returns>İki sayının toplam değeri</returns>

        static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        static int Topla(int carpim, params int[] sayilar)
        {
            int toplam = 0;
            for(int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            return toplam * carpim;
        }

        static string Disc(int a, int b, int c)
        {
            int sonuc = (b * b) - (4 * a * c);

            if (sonuc < 0)
                return "Denklemin reel kökü yoktur.";

            if (sonuc == 0)
                return "Denklemin bir reel kökü vardır.";

            return "Denklemin iki reel kökü vardır.";
        }
    }
}
