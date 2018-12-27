using Soyut.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soyut.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<object> sekiller = new List<object>();

        private void Form1_Load(object sender, EventArgs e)
        {
            Kare kare = new Kare();
            kare.X = 10;
            MessageBox.Show($"Karenin alanı: {kare.AlanHesapla()}");

            Dikdortgen dikdortgen = new Dikdortgen()
            {
                X = 5, //Yazarken boşluğa basılırsa istenen parametreler gelir
                Y = 12
            };

            MessageBox.Show($"Dikdörtgenin köşegeni: {dikdortgen.KosegenHesapla()}");

            sekiller.Add(kare);
            sekiller.Add(dikdortgen);

            Sekil dikdortgen2 = new Dikdortgen()
            {
                X = 3,
                Y = 4
            };

            Sekil kare2 = new Kare() { X = 5 };

            sekiller.Add(dikdortgen2);
            sekiller.Add(kare2);

            foreach (Sekil sekil in sekiller)
            {
                MessageBox.Show($"Şekil alanı: {sekil.AlanHesapla()}");
            }
        }
    }
}
