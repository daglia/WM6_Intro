using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamAsmacaCozum
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int hak = 6, bilinen = 0;
                string[] sorular = { "zeytinburnu", "kahramanmaraş", "çanakkale", "hayrabolu" };
                Random rnd = new Random();
                string seciliSoru = sorular[rnd.Next(sorular.Length)];
                double puan = seciliSoru.Length * 100;
                char[] ekran = new char[seciliSoru.Length];
                for(int i = 0; i < seciliSoru.Length; i++)
                    ekran[i] = '_';

                do
                {
                    foreach (char ee in ekran)
                        Console.Write(ee + " ");
                    //string a = string.Format("\n {0} harf. Puan: {1} Kalan hak: {2}", seciliSoru.Length, puan, hak);
                    string ozet = $"\n--> {seciliSoru.Length} harf. Puan: {puan} Kalan hak: {hak}";
                    Console.WriteLine(ozet);
                    Console.WriteLine("Tahmininizi giriniz:");
                    string tahmin = Console.ReadLine().ToLower();

                    if(tahmin.Length == 1)
                    {
                        bool bildiMi = false, girildiMi =false;

                        for (int k = 0; k < ekran.Length; k++)
                        {
                            if (ekran[k] == tahmin[0])
                            {
                                girildiMi = true;
                                break;
                            }
                        }

                        if (!girildiMi)
                        {
                            for (int i = 0; i < seciliSoru.Length; i++)
                            {

                                if (seciliSoru[i] == tahmin[0])
                                {
                                    bildiMi = true;
                                    ekran[i] = tahmin[0];
                                    bilinen++;
                                }
                            }

                            if (!bildiMi)
                            {
                                hak--;
                                puan *= 0.85;
                            }
                        }
                    }
                    else
                    {
                        if(tahmin == seciliSoru)
                        {
                            break;
                        }

                        hak--;
                        puan *= 0.85;
                    }
                } while (hak > 0 && bilinen != seciliSoru.Length);

                Console.WriteLine(hak > 0 ? "Tebrikler bildiniz!" : "Bilemediniz");

                Console.WriteLine("Tekrar oynamak için e'ye basınız.");
                if (Console.ReadLine().ToLower() != "e")
                    break;
            } while (true);
        }
    }
}