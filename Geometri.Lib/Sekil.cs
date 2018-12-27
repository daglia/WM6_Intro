using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri.Lib
{
    //Her kare bir şekildir, ama her şekil bir kare değildir. Şekil bu yüzden abstract olur.
    public abstract class Sekil //Public olmazsa diğer projelerden ulaşılamaz, internal kalır.
    {
        public double X { get; set; }

        /*
         * virtual keywordu override edebilmemizi sağlamakta. Eğer override edilmezse base classta yazıldığı gibi çalışır. Override edildikten sonra, override edilmiş classtan kalıtım alınırsa kalıtım alan class override edilmiş halini kalıtım alır. İsterse kendisi tekrar override eder.
         */

        public virtual double CevreHesapla()
        {
            return 4 * X;
        }

        public virtual double AlanHesapla()
        {
            return Math.Pow(X, 2);
        }

        public virtual double KosegenHesapla()
        {
            return Math.Sqrt(2) * X;
        }
    }
}