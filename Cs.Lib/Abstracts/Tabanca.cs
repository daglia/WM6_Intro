using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs.Lib.Abstracts
{
    public abstract class Tabanca : Silah, IAtesEdebilen, ISarjorlu
    {
        protected int _sarjorKapasitesi, _kalanFisek; //Dışarıdan etkilenmeye kapalı.
        public abstract int AtesEt(); //Her "tabanca" için farklıdır. O yüzden abstract düşünülür.

        public int SarjorKapasitesi
        {
            get => _sarjorKapasitesi;
        }

        public int KalanFisek
        {
            get => _kalanFisek;
        }

        public abstract int YenidenDoldur();
    }
}
