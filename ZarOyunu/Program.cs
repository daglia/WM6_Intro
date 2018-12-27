using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int giris = 0, sayac = 0;
            int zar1 = 0, zar2 = 0;
            bool dogruMu = false;
            Console.WriteLine("1-6 arasında bir giriş yapınız:");
                try
                {
                    giris = int.Parse(Console.ReadLine());
                    if(giris < 1 || giris > 6)
                    {
                        throw new ArgumentException("Lütfen 1-6 arasında giriş yapınız.");
                    }
                    
                    do //Girilen sayı çifti bulunana kadar zar atılacak.
                    {
                        
                    } while (true);
                }
                catch(Exception ex)
                {
                    Console.Write(ex.Message);
                }

                

            while (dogruMu)
            {
                sayac++;
                zar1 = rnd.Next(1, 7);
                zar2 = rnd.Next(1, 7);
                Console.WriteLine(sayac + ". deneme: " + zar1 + " - " + zar2);
                if (zar1 == zar2 && zar1 == giris)
                {
                    Console.WriteLine(sayac + ". denemede buldun!");
                    break;
                }


                Console.WriteLine("Tekrar oynamak için e yazınız:");
                string cevap = Console.ReadLine();
                if (cevap.ToLower() != "e")
                    break;
            }
        }
    }
}
