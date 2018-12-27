using Cs.Lib.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cs.Lib.Concrete
{
    public class DesertEagle : Tabanca
    {
        public DesertEagle()
        {
            this._sarjorKapasitesi = 7;
            this.Ulke = "İsrail";
            this.Hasar = 80;
            this.Fiyat = 700m;
            this._kalanFisek = this._sarjorKapasitesi;
            this.SilahResmi.Image = Properties.Resources.Deagle;
        }
        public override int AtesEt()
        {
            SoundPlayer soundPlayer;
            if (KalanFisek != 0)
            {
                soundPlayer = new SoundPlayer(Properties.Resources.Deagle_Ates);
                soundPlayer.Play();
                Thread.Sleep(600);
                this._kalanFisek--;
            }
            else
            {
                soundPlayer = new SoundPlayer(Properties.Resources.Bitik_Mermi_Sesi);
                soundPlayer.Play();
                Thread.Sleep(100);
            }
            return this._kalanFisek;
        }

        public override int YenidenDoldur()
        {
            new SoundPlayer(Properties.Resources.Deagle_Reload).Play();
            Thread.Sleep(1250);
            this._kalanFisek = this._sarjorKapasitesi;
            return KalanFisek;
        }
    }
}
