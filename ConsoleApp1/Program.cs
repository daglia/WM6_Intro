/* Doktor muayene takvimi
 * 09.00 - 16.30 arasında mesaisi var.
 * 12.00 - 13.00 arasında öğle tatili var.
 * Muayene saatleri yazdırılacak.
*/

using System;

namespace Odev001Cozum
{
    class Program
    {
        static void Main(string[] args)
        {
            object a = 0; //Her degisken objeden gelir!

            //for döngüsü ile:

            for(int saat = 9; saat <= 16; saat++)
            {
                if (saat == 12)
                {
                    Console.WriteLine("*** Öğle Tatili ***");
                    continue;
                }


                for(int dakika = 0; dakika <= 45; dakika += 15)
                {
                    if (saat == 16 && dakika == 45) break;
                    Console.WriteLine(saat.ToString("00") + "." + dakika.ToString("00")); //String format
                }
            }

            // Diğer çözüm (DateTime ve do-while ile):
            Console.WriteLine("\n\nDiğer Çözüm\n");

            DateTime baslangic = new DateTime(2000, 1, 1, 9, 0, 0);
            do
            {
                if(baslangic.Hour == 12)
                {
                    Console.WriteLine("*** Öğle Tatili ***");
                    baslangic = baslangic.AddHours(1);
                    continue;
                }
                Console.WriteLine(baslangic.ToShortTimeString());
                baslangic = baslangic.AddMinutes(15);
            } while (!(baslangic.Hour == 16 && baslangic.Minute == 45));
        }
    }
}
