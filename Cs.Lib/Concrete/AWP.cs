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
    public class AWP : Tufek
    {
        public AWP()
        {
            this._atisKatsayisi = 1500;
            this._sarjorKapasitesi = 10;
            this.Ulke = "İngiltere";
            this.Hasar = 120;
            this.Fiyat = 4750m;
            this._kalanFisek = this._sarjorKapasitesi;
            this.SilahResmi.Image = Properties.Resources.AWP;
        }
        public override int AtesEt()
        {
            SoundPlayer soundPlayer;
            if (KalanFisek != 0)
            {
                soundPlayer = new SoundPlayer(Properties.Resources.AWP_Ates);
                soundPlayer.Play();
                Thread.Sleep(_atisKatsayisi);
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
            new SoundPlayer(Properties.Resources.M4A1_Reload).Play();
            Thread.Sleep(1100);
            this._kalanFisek = this._sarjorKapasitesi;
            return KalanFisek;
        }
    }
}
