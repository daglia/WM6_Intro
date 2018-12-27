using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    public class SefOgretmen : Ogretmen
    {
        public double Katsayi { get; set; }

        public SefOgretmen(string ad):base(ad)
        {

            instanceDate = DateTime.Now;
        }

        public SefOgretmen()
        {

        }
    }
}
