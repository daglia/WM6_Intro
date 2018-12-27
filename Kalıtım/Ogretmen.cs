using System;
using System.Text.RegularExpressions;

namespace Kalitim
{
    public class Ogretmen:Kisi
    {
        public Branslar Brans { get; set; } //Autoproperty: Kendi kendine field'lar yazar ve get; set; şeklinde kullanılabilir.

        public decimal Maas { get; set; } //Sadece get olursa sadece okunur, sadece set olursa sadece yazılır.

        public Ogretmen(string ad) : base(ad)
        {
            instanceDate = DateTime.Now;
        }

        public Ogretmen()
        {
            
        }
    }
}
