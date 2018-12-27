using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KisiselKontroller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*
             * Standart kalıpların olduğu ekranlardan birden fazla yerde kullanılması gerekiyorsa bu ekranlar UserControl olarak tasarlanıp istenilen yere toolbox üzerinden sürükle bırakla oluşturulabilir.
             */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txtConverter1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Okunan: " + txtConverter1.ConvertedText);
        }

        private void txtConverter1_Load_1(object sender, EventArgs e)
        {

        }

        private void txtConverter1_SinirAsildi(string mesaj)
        {
            MessageBox.Show(mesaj);
        }
    }
}
