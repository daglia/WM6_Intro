using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            //PascalCase
            //camelCase

            //İsimlendirme kuralları
            //isimler rakam ile başlayamaz ama rakam bulundurabilirler
            //isimler özel karakter barındıramaz, _ hariç
            //tanımlı komutların ismi kullanılamaz
            //aynı namespace üzerinde daha önce tanımlanmış bir değişken ismi bir daha kullanılamaz.

            //TAD - Tip Ad = Değer;

            //Tamsayı tipler

            byte degiskenByte = 255; //isaretsiz 8bit
            sbyte degiskenSbyte = -128; //isaretli 8bit
            short degiskenShort = 32000; //isaretli 16bit
            ushort degiskenUshort = 65535; //isaretsiz 16bit
            int degiskenInt = int.MaxValue; //isaretli 32bit
            uint degiskenUint = uint.MaxValue; //isaretsiz 32bit
            long degiskenLong = 5000L; //isaretli 64bit
            ulong degiskenUlong = ulong.MaxValue; //isaretsiz 64bit

            degiskenInt = degiskenShort;
            degiskenShort = Convert.ToInt16(degiskenLong);
            Console.WriteLine(degiskenShort);

            //Ondalıklı tipler

            float degiskenFloat = 3.14f;
            double degiskenDouble = 3.14d;
            decimal degiskenDecimal = 3.14m;

            degiskenInt = 0b1011; //binary
            degiskenInt = 0x2e; //hex
            degiskenDouble = 3.01e10;

            Console.WriteLine(degiskenDouble);

            //Metinsel ifadeler

            char degiskenChar = '6';
            string degiskenString = "Hello World";

            //mantıksal ifade

            bool dogruMu = false; //ya da true

            DateTime suan = DateTime.Now;
            suan = new DateTime(2018, 11, 26);

            object degiskenObject = suan;
            degiskenObject = degiskenInt;
            degiskenObject = degiskenDouble;

            var query = degiskenInt * degiskenDouble;

            var a = 1;
            var b = 2d;
            var c = 3m;
            var d = "merhaba";



        }
    }
}
