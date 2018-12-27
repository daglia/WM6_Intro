using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPart1
{
    class Insan //Yeni bir tanımlama yapmak için, yaratmak için, nitelemek için
    {
        /*
         * Erişim Belirleyiciler - Access Modifiers
         * fields - alanlar
         * constructors - yapıcı metodlar
         * properties - özellikler
         * metodlar - fonksiyonlar
         * delege
         * event
         * destructors - yıkıcı
         * (*)kalıtım - inheritance
         * (*)polymorphism
         */

        //Erişim Belirleyiciler - Access Modifiers

        /* private - Aynı scope ve alt scope içinde erişim yapılan nesnelerdir. Tanımlanan tüm değişken ve metodlar önüne yazılmasa dahi private olarak çalışırlar.
         * 
         * internal - Aynı namespace içerisinde erişime açıktır. class, interface, enum default internal'dır.
         * 
         * public - Farklı namespace'ten erişim için kullanılır.
         * 
         * (*)protected
         * (*)protected internal
         */

        private int _yas; // field'lar _ ile başlar
        private DateTime _dogumTarihi;

        public Insan(int yas)
        {
            this._yas = yas; //this bulunduğu sınıfı temsil eder. O anki referansına erişimde kullanılır.
        }
        
        public Insan()
        {
            
        }

        //Encapsulation (oldschool)

        public void setYas(int yas)
        {
            if(yas <= 0)
            {
                throw new Exception("Yaş sıfırdan büyük olmalı!");
            }
            this._yas = yas;
        }

        public int getYas() => this._yas; //Kısa yoldan döndürme (=> : öyle ki)
        /*{
            return this._yas;
        }*/

        //Property (ft. Encapsulation)
        
        public int Yas
        {
            /*get
            {
                return this._yas;
            }*/
            get { return DateTime.Now.Year - _dogumTarihi.Year; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Yaş sıfırdan büyük olmalı!");
                }
                this._yas = value;
            }
        }

        public DateTime DogumTarihi
        {
            set
            {
                if (DateTime.Now.Year - value.Year < 18)
                    throw new Exception("18 yaşından küçükler sisteme kayıt olamaz.");
                this._yas = YasHesapla(value.Year);
                this._dogumTarihi = value;
            }
        }

        private int YasHesapla(int year) => DateTime.Now.Year - year;
    }
}