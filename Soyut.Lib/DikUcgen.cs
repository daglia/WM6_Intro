using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soyut.Lib
{
    public class DikUcgen : Dikdortgen
    {
        public override double AlanHesapla()
        {
            return base.AlanHesapla() / 2;
        }

        public override double CevreHesapla()
        {
            return this.X + this.Y + this.KosegenHesapla();
        }
    }
}
