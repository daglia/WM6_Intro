using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNesnesi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random

            Random rnd = new Random();

            // ***BİRİNCİ PROGRAM***

            /*
            byte sayi;
            int i = 0;
            int zar1;
            int zar2;

            do
            {
                Console.Write("1-6 arasında bir sayı girin: ");

                try
                {
                    sayi = Convert.ToByte(Console.ReadLine());
                    if (sayi < 1 || sayi > 6)
                        throw new Exception("Lütfen 1-6 arasında bir sayı giriniz.");
                    break;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            } while (true);

            do
            {
                zar1 = rnd.Next(1, 7);
                zar2 = rnd.Next(1, 7);
                i++;
                Console.WriteLine(i + ". Deneme: " + zar1 + " - " + zar2);
            } while (!(sayi == zar1 && sayi == zar2));

            Console.WriteLine("*********************************");
            Console.WriteLine(i + " denemede tutturdun!");
            
            */

            // ***İKİNCİ PROGRAM***

            
            
            int tut;
            int tah;
            int i = 1;

            tut = rnd.Next(0, 101);

            Console.Write("Bir sayı tuttum, acaba ne tuttum? 0-100 arası salla bir şey: ");

            do
            {
                do
                {
                    try
                    {
                        tah = Convert.ToInt16(Console.ReadLine());
                        if (tah < 0 || tah > 100)
                            throw new Exception("0-100 arası demiştim...\nTekrar gir: ");
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                } while (true);

            
                
                if (tah < tut)
                {
                    i++;
                    Console.Write("Çık çık...\nYeniden gir: ");
                }
                else if (tah > tut)
                {
                    i++;
                    Console.Write("Çok söyledin, az söyle...\nYeniden gir: ");
                }
            } while (tah != tut);
            

            Console.WriteLine("Tebrikler! " + i + ". denemende buldun!");

    
    

            //1-6 arasında girilen sayı üzerinden bir zar oyunu oynanacak.

            //Program 0-100 arasında bir sayı aklında tutacak ve kullanıcıdan bunu bilmesini isteyecek
            //Her tahminde kullanıcıya yukarı aşağı şeklinde ipucu verecek bildiğinde ise kaçıncı denemede bildiğini yazacak
        }
    }
}
