using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    public class Personel : Kisi
    {
        public decimal Maas { get; set; } //Sadece get olursa sadece okunur, sadece set olursa sadece yazılır.

        public Gorevler Gorev { get; set; }
    }
}
