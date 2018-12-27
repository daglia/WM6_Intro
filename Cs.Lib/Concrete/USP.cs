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
    public class USP : Tabanca
    {
        public USP()
        {
            this.Fiyat = 200m;
            this.Ulke = "Almanya";
            this._sarjorKapasitesi = 12;
            this._kalanFisek = this._sarjorKapasitesi;
            this.SilahResmi.Image = Properties.Resources.USP;
            this.Hasar = 35;
        }
        public override int AtesEt()
        {
            SoundPlayer soundPlayer;
            if(KalanFisek != 0)
            {
                soundPlayer = new SoundPlayer(Properties.Resources.USP_Ates);
                soundPlayer.Play();
                Thread.Sleep(250);
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
            new SoundPlayer(Properties.Resources.USP_Reload).Play();
            Thread.Sleep(1125);
            this._kalanFisek = this._sarjorKapasitesi;
            return KalanFisek;
        }
    }
}
