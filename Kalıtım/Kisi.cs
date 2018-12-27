using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    public class Kisi
    {
        private string _ad, _soyad, _telefon, _tckn;
        protected DateTime instanceDate;

        public String Ad
        {
            get => this._ad;
            set
            {
                NameValid(value, "Ad");
                value = value.Trim();
                this._ad = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }
        public String Soyad
        {
            get => this._soyad;
            set
            {
                NameValid(value, "Soyad");
                value = value.Trim();
                this._soyad = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }
        public String Telefon
        {
            get => this._telefon;
            set
            {
                if (!value.StartsWith("5"))
                    throw new Exception("Telefon numarası 5 ile başlamalı");
                if (value.Length != 10)
                    throw new Exception("Telefon numaranız 10 hane olmalı");
                foreach (char harf in value)
                {
                    if (!char.IsDigit(harf))
                        throw new Exception("Telefon numaranız sadece rakamlardan oluşmalıdır");
                }

                this._telefon = value;
            }
        }
        public String TCKN
        {
            get => this._tckn;
            set
            {
                if (value.Length != 11)
                    throw new Exception("TCKN 11 haneli olmalıdır");
                foreach (char harf in value)
                {
                    if (!char.IsDigit(harf))
                        throw new Exception("TCKN sadece rakamlardan oluşmalıdır");
                }

                this._tckn = value;
            }
        }

        private void NameValid(string value, string propertyName)
        {
            foreach (char harf in value)
            {
                if (!(char.IsLetter(harf) || char.IsWhiteSpace(harf)))
                    throw new Exception($"{propertyName} girisi sadece harf ve bosluklarla yapilmalidir.");

            }
        }

        public Kisi(string ad)
        {
            this.Ad = ad;
            instanceDate = DateTime.Now;
        }

        public Kisi()
        {

        }
    }
}
