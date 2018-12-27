using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Merhaba, isminiz nedir? : ");
            string ad = Console.ReadLine(); //Kullanıcıdan giriş bekler
            Console.WriteLine("Hoş geldin " + ad + "!");
            Console.Write("Yaşınızı giriniz: ");

            //byte yas = Convert.ToByte(Console.ReadLine()); //Okunan string dönüşüm gerektirebilir.

            /* 1) Dışarıdan bir veri girişi olduğunda (Kullanıcı girişi)
             * 2) Dosya okuma işlemi yapıldığında
             * 3) Veritabanı işlemlerinde
             * 4) Webisteklerde
             * 
             * """TRY-CATCH KULLANMAK ZORUNDASIN!!!"""
             * 
             * ERROR HANDLING - HATA YÖNETİMİ
             */

            try
            {
                byte yas = Convert.ToByte(Console.ReadLine());

                if (yas < 18)
                {
                    Console.WriteLine("Güle güle.");
                }
                else
                {
                    Console.WriteLine("Sistemi kullanmaya devam edebilirsiniz.");
                }
            }
            catch
            {
                Console.WriteLine("Yaşınız sayı olmalı!!!");
            }

            Console.Write("0-100 arasında bir sayı giriniz: ");
            try
            {
                int girilen = int.Parse(Console.ReadLine());
                if (girilen < 0 || girilen > 100)
                {
                    throw new Exception("0 - 100 arası bir sayı girmeliydin hacım.");
                }

                if (girilen % 2 == 1)
                {
                    throw new ArgumentException("Girilen sayı çift olmalı idi her nedense.");
                }

                Console.WriteLine("Girilen sayı: " + girilen);

                double sonuc = girilen / girilen;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Sıfır girmesen iyiydi...");
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Herhangi bir sayı girmedin.");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Ben HER ZAMAN çalışırım >:D");
            }
        }
    }
}