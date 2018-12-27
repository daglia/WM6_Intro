using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcaksavarOyunu.Lib
{
    public abstract class OyunBase
    {
        protected readonly ContainerControl container; //Sadece kalıtım ile çalışacağı için protected
        protected OyunBase(ContainerControl container)
        {
            this.container = container;
            this.Container = container;
        }
        public PictureBox Resim { get; set; } = new PictureBox();
        public ContainerControl Container { get; private set; }
    }
}
