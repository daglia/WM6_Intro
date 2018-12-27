using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs.Lib.Abstracts
{
    public abstract class YakinSaldiri : Silah, IVurulabilir
    {
        protected int _vurusKatsayisi;
        public int VurusKatsayisi
        {
            get => _vurusKatsayisi;
        }
        public abstract int Vur();
    }
}
