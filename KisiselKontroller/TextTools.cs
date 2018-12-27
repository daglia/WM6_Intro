using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselKontroller
{
    public static class TextTools
    {
        public static string OkunusuGetir(int sayi)
        {
            /*if(sayi < 0 || sayi > 9999)
            {
                throw new Exception("Sayı 0-9999 arasında olmalı.");
            }*/

            if (sayi == 0)
                return "sıfır";

            string[] basamak1 = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
            string[] basamak10 = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
            string basamak100 = "yüz";
            string basamak1000 = "bin";

            int birler = sayi % 10;
            int onlar = (sayi / 10) % 10;
            int yuzler = (sayi / 100) % 10;
            int binler = (sayi / 1000) % 10;

            string okunus = string.Empty;

            if (binler > 1)
                okunus += basamak1[binler] + basamak1000;
            else if (binler == 1)
                okunus += basamak1000;

            if (yuzler > 1)
                okunus += basamak1[yuzler] + basamak100;
            else if (yuzler == 1)
                okunus += basamak100;

            okunus += basamak10[onlar];
            okunus += basamak1[birler];         

            return okunus;
        }
    }
}
