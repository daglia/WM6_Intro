using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornekler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dışarıdan girilen sayı kadar * karakteri kullanılarak kare şekli çizme
            // Hatalı giriş olduğunda yeniden çalışacak
            //Çizdikten sonra tekrar çalıştırılmak isteniyor mu diye sorulacak (e/h)
            //İçi boş kare çizilecek

            string secim = string.Empty;

            do
            {
                do
                {
                    Console.Write("1) Kare çizdir.\n" +
                    "2) İçi boş kare çizdir.\n" +
                    "3) Eşkenar üçgen çizdir.\n" +
                    "4) İçi boş üçgen çizdir.\n" +
                    "5) Baklava çizdir.\n" +
                    "Seçiminiz: ");
                    secim = Console.ReadLine();
                    if (secim == "1" || secim == "2" || secim == "3" || secim == "4" || secim == "5") break;
                    else{
                        Console.WriteLine("Geçerli bir seçim yapmadınız.");
                    }
                } while(true);

                int x = 0;
                Console.Write("Uzunluğu giriniz: ");

                do
                {
                    try
                    {
                        x = int.Parse(Console.ReadLine());

                        if (x <= 0)
                            throw new Exception("Lütfen pozitif bir sayı giriniz.");
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    } 
                } while (true);

                switch (secim)
                {
                    case "1":
                        for (int i = 0; i < x; i++)
                        {
                            for (int j = 0; j < x; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case "2":
                        for (int i = 0; i < x; i++)
                        {
                            for (int j = 0; j < x; j++)
                            {
                                if ((j == 0 || j == x - 1) || (i == 0 || i == x - 1))
                                {
                                    Console.Write("*");
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.WriteLine();
                        }
                        break;

                    case "3":
                        for (int i = 0; i < x; i++)
                        {
                            for (int j = 0; j < x - i; j++)
                            {
                                Console.Write(" ");
                            }
                            for(int k = 1; k <= 2*i + 1; k++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case "4":
                        for (int i = 1; i <= x; i++)
                        {
                            for (int j = i; j < x; j++)
                            {
                                Console.Write(" ");
                            }
                            for (int k = 1; k <= 2 * i - 1; k++)
                            {
                                if(i == x || k == 1 || k == 2*i - 1)
                                {
                                    Console.Write("*");
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.WriteLine();
                        }
                        break;
                    case "5":
                        for (int i = 0; i < x; i++)
                        {
                            for (int j = 0; j < x - i; j++)
                            {
                                Console.Write(" ");
                            }
                            for (int k = 1; k <= 2 * i + 1; k++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }

                        for(int i = x - 2; i >= 0; i--)
                        {
                            for(int j = x - i - 1; j >= 0; j--)
                            {
                                Console.Write(" ");
                            }
                            for(int k = 2*i + 1; k >= 1; k--)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }

                        break;
                }
                Console.Write("Devam etmek istiyor musunuz? (e/h)");
            } while (Console.ReadLine().ToLower() == "e");
        }
    }
}