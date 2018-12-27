using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array aynı tip verilerin tek bir değişkende saklanması için kullanılabilir.

            int[] sayilar = new int[5];

            //index sıfırdan başlar

            sayilar[0] = 5;
            sayilar[1] = 55;
            sayilar[2] = 45;
            sayilar[3] = 15;
            sayilar[4] = 52;

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

            foreach (int gelen in sayilar)
            {
                Console.WriteLine(gelen);
            }

            string[] kisiler = {"Kamil", "Ahmet", "Falan", "Filan"};

            double[,] matris = new double[2, 2];

            matris[0, 0] = 3.14;
            matris[0, 1] = 5;
            matris[1, 0] = 2;
            matris[1, 1] = 1;

            for(int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    Console.Write(matris[i, j] + " ");
                }
                Console.WriteLine();
            }

            Random rnd = new Random();

            matris = new double[10, 4];

            for(int i = 0; i < matris.GetLength(0); i++)
            {
                for(int j = 0; j < matris.GetLength(1); j++)
                {
                    matris[i, j] = rnd.NextDouble();
                    Console.Write(matris[i, j] + " - ");
                }
                Console.WriteLine();
            }

            ArrayList liste = new ArrayList();
            liste.Add(5);
            liste.Add("Kamil");
            liste.Add(true);
            liste.Add(3.14);

            //ArrayList obje tipi döner.

            List<int> listem = new List<int>()
            {
                3, 4, 2, 1, 2
            }; //Bu liste sadece int alabilir, çünkü öyle tanımlanmıştır.

            listem.Add(5);
            listem.Add(6);
            listem.Add(9);
            listem.Add(14);

            listem.Remove(0);

            /*
             * Önceden tanımlı kelimelerin bulunduğu bir adam asmaca oyunu programlayınız.
             * 6 hak
             * Puanlandırma: sorudaki harf sayısı * 100 = maksimum puan
             * Her yanlış cevapta puanın %15'i azalacak
             * 2 çeşit kullanıcı girişi olacak
             * 1.si harf harf tahmin
             * 2.si kelime tahmini
             * 
             * 2 çeşit oyun bitirme olacak:
             * 1.si harfleri tek tek bilerek
             * 2.si kelime tahmini yaparak
             * 
             * _ _ _ _ _ _ _ _
             * i
             * i _ _ _ _ _ _ _
             * l
             * i _ _ _ _ _ _ l
             * istanbul
             * tebrikler, tekrar oynamak ister misiniz?
             * */
        }
    }
}
