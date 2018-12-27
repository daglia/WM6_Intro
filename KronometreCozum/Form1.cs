using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KronometreCozum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Ön tanımlı değişkenler burada tanımlanıyor
        private DateTime kronometre = new DateTime(), simdi = DateTime.Now, once = DateTime.Now;
        private bool basladiMi = false;

        private void Yaz()
        {
            lblSaat.Text = $"{kronometre.Hour:00}";
            lblDakika.Text = $"{kronometre.Minute:00}";
            lblSaniye.Text = $"{kronometre.Second:00}";
            lblSalise.Text = $"{kronometre.Millisecond:000}";
        }

        private void dtpZamanli_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (basladiMi) return;

            kronometre = new DateTime();
            Yaz();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            once = simdi;
            simdi = DateTime.Now;
            TimeSpan fark = simdi - once; //Birim zamanı verir
            kronometre = kronometre.AddMilliseconds(fark.TotalMilliseconds);

            if (cbZamanli.Checked)
            {
                DateTime bitis = dtpZamanli.Value;
                TimeSpan toplamFark = bitis - new DateTime(bitis.Year, bitis.Month, bitis.Day);
                TimeSpan baslangictanFark = kronometre - new DateTime();

                int yuzde = (int)(baslangictanFark.TotalMilliseconds / toplamFark.TotalMilliseconds * 100);

                if(yuzde >= 100)
                {
                    yuzde = 100;
                    kronometre = new DateTime(kronometre.Year, kronometre.Month, kronometre.Day, kronometre.Hour, kronometre.Minute, kronometre.Second); //ms 0 olsun diye
                    btnStartStop.PerformClick(); //Tıklamış gibi çalıştırır
                    
                    Yaz();
                    //kronometre = new DateTime();
                }

                progressBar1.Value = yuzde;
            }
            Yaz();
        }

        

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            basladiMi = !basladiMi;

            if (basladiMi)
            {
                btnStartStop.Text = "Durdur"; //Buton yazısı
                btnStartStop.FlatStyle = FlatStyle.Flat; //Buton tipi
                btnStartStop.BackColor = Color.Chartreuse; //Buton rengi
                simdi = DateTime.Now;
                timer1.Start();
                btnReset.Enabled = false;
            }
            else
            {
                btnStartStop.Text = "Basla";
                btnStartStop.FlatStyle = FlatStyle.Standard;
                btnStartStop.BackColor = Color.IndianRed;
                timer1.Stop();
                btnReset.Enabled = true;
            }
        }
    }
}
