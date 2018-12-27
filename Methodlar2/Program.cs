using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodlar2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir kenarı 2 olan karenin alanı: " + AlanHesapla(2, 3.14));
            Console.WriteLine();

            float r = 5;
            Console.WriteLine("Çemberin alanı: " + AlanHesapla(r));

            string[] kisiler = {"Kamil", "Ayşe", "Fatma", "Kerem"};

            Selamlama(kisiler);
        }

        /// <summary>
        /// Kare alan hesabı.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static int AlanHesapla(int a)
        {
            return a * a;
        }

        /// <summary>
        /// Dikdörtgen alan hesabı.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static int AlanHesapla(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// Dikdörtgen alan hesabı.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static double AlanHesapla(double a, double b)
        {
            return a * b;
        }

        static double AlanHesapla(int a, double b)
        {
            return a * b;
        }

        static double AlanHesapla(float r, double pi = Math.PI)
        {
            double rr = Convert.ToDouble(r * r);
            return rr * pi;
        }

        static void Selamlama(string[] kisiler)
        {
            foreach(string kisi in kisiler)
            {
                Console.WriteLine("Hoş geldin " + kisi);
            }
        }
    }
}
