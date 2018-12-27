using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Random rnd = new Random();
                int rastgele = rnd.Next(1, 100), tahmin = 0, sayac = 0;
                Console.WriteLine("Bir sayı tuttum, tahmin et:");
                do //Bilene kadar dönecek döngü
                {
                    try
                    {
                        sayac++;
                        tahmin = int.Parse(Console.ReadLine());
                        if (tahmin < 1 || tahmin > 99)
                        {
                            throw new ArgumentException("Lütfen 1-100 arasında bir giriş yapınız.");
                        }
                        if (rastgele < tahmin)
                        {
                            Console.WriteLine("Aşağı");
                        }
                        else if (rastgele > tahmin)
                        {
                            Console.WriteLine("Yukarı");
                        }
                        else
                        {
                            Console.WriteLine("Tebrikler, " + sayac + ". denemede bildiniz!");
                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                } while (true);

                Console.WriteLine("Tekrar oynamak için e yazınız.");
                string cevap = Console.ReadLine();
                if (cevap.ToLower() != "e")
                    break;
            } while (true);
        }
    }
}
