using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperatorOverloading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Elma elma = new Elma() { Agirlik = 5, Fiyat = 4, Renk = Color.Red };
            Armut armut = new Armut() { Agirlik = 7, Fiyat = 5, Renk = Color.ForestGreen };

            var sonuc = elma + armut;

            MessageBox.Show(Convert.ToString(sonuc));
        }
    }
}
