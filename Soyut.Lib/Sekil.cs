using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soyut.Lib
{
    public abstract class Sekil
        //abstract nesnelerin ornegi (instance) alınamaz.
        //İçerisindeki abstract olmayan nesneler aynen aktarılır.
    {
        public double X;

        public abstract double CevreHesapla();

        public abstract double AlanHesapla();

        public abstract double KosegenHesapla();
    }
}
