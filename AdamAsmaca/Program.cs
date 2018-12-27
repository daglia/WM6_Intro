using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

namespace AdamAsmaca
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kelimeler = { "macaristan", "lüksemburg", "avustralya", "arjantin", "paraguay", "türkiye", "japonya", "tayland", "azerbaycan", "finlandiya" };
            Random rnd = new Random();

            do { //Oyun
                string kelime = kelimeler[rnd.Next(0, 11)];
                char[] bos = new char[kelime.Length];
                int hak = 6;
                double puan = kelime.Length * 100;
                string tah;
                bool bulunduMu;
                int bulunan = 0;

                for(int i = 0; i < bos.Length; i++)
                {
                    bos[i] = '_';
                }

                Console.WriteLine("Tahminini alalım!");

                foreach (char i in bos)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
                Console.WriteLine();

                do //Tahmin
                {
                    do //Harf girişi
                    {
                        bulunduMu = false;

                        try
                        {
                            tah = Console.ReadLine();

                            if (tah.Length != kelime.Length && tah.Length != 1)
                                throw new Exception("Yanlış oldu... Tekrar dene.");
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    } while (true);

                    if(tah.Length == 1)
                    {
                        for (int i = 0; i < kelime.Length; i++)
                        {
                            if(bos[i] == tah[0]){
                                Console.WriteLine("Bu harfi zaten buldun, başka bir şey söyle");
                                break;
                            }

                            else if(tah[0] == kelime[i])
                            {
                                bos[i] = tah[0];
                                bulunduMu = true;
                                bulunan++;
                            }
                        }

                    }

                    else if(tah == kelime || bulunan == kelime.Length)
                    {
                        Console.WriteLine("Tebrikler, bildin! Puanın: " + puan);
                        break;
                    }

                    foreach (char i in bos)
                    {
                        Console.Write(i);
                        Console.Write(" ");
                    }
                    Console.WriteLine();

                    if (bulunduMu)
                    {
                        Console.WriteLine("Tebrikler, devam edelim!");
                    }
                    else
                    {
                        hak--;
                        Console.WriteLine("Bulamadın! Sadece " + hak + " hakkın kaldı.");
                        puan = puan - (puan * 0.15);
                    }
                } while (hak != 0);

                if(hak == 0)
                {
                    Console.WriteLine("Kaybettin!");
                }

                Console.WriteLine("Tekrar oynamak ister misin? (e/h)");
            } while (Console.ReadLine().ToLower() == "e");
        }
    }
}