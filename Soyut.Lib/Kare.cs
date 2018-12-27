using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soyut.Lib
{
    public class Kare : Sekil
    {
        public override double AlanHesapla()
        {
            return Math.Pow(X, 2);
        }

        public override double CevreHesapla()
        {
            return X * 4;
        }

        public override double KosegenHesapla()
        {
            return Math.Sqrt(2) * X;
        }
    }
}