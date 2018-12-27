using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cs.Lib.Abstracts
{
    public abstract class Silah
    {
        public string Ulke { get; protected set; }
        public decimal Fiyat { get; protected set; }
        public int Hasar { get; protected set; }
        public PictureBox SilahResmi { get; protected set; } = new PictureBox(); //Autosetter
        protected Silah()
        {
            SilahResmi.Size = new System.Drawing.Size(500, 400);
            SilahResmi.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }

    public enum Silahlar : byte
    {
        Bıçak,
        USP,
        Glock,
        DesertEagle,
        AK47,
        M4A1S,
        AWP,
        ElBombası,
        FlashBombası
    }
}
