using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XmlJsonServislerineBaglanma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Doviz> dovizler;
        private FourFactory fourFactory;
        private int sayac = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            var doviz = dovizler[sayac++ % dovizler.Count];
            lblKod.Text = $"{doviz.Birim} {doviz.Ad} - {doviz.Kod}";
            lblDeger.Text = $"Alış: {doviz.Alis:c4}\nSatış: {doviz.Satis:c4}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                fourFactory = new FourFactory();
                dovizler = DovizFactory.Dovizler; //Dovizler static property olduğu için doğrudan çağırılabiliyor.

                //listBox1.Items.AddRange(dovizler.ToArray());
                listBox1.DataSource = dovizler;
                //listBox1.DisplayMember = "Gorunum";
                //listBox1.ValueMember = "Satis";
                timer1.Start();
            }
            catch (Exception ex)
            {
                timer1.Stop();
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            Doviz seciliDoviz = listBox1.SelectedItem as Doviz;
            this.Text = $"{seciliDoviz.Birim} {seciliDoviz.Ad} - {seciliDoviz.Kod} Alış: {seciliDoviz.Alis:c4} Satış: {seciliDoviz.Satis:c4}";
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            var liste = fourFactory.Firmalar;
            lstFirmalar.DataSource = liste.OrderBy(x=>x.name).ToList();
            lstFirmalar.DisplayMember = "name";
        }

        private Four.Venue seciliFirma;

        private void lstFirmalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFirmalar.SelectedItem == null) return;
            seciliFirma = lstFirmalar.SelectedItem as Four.Venue;
            lblFirmaAdi.Text = seciliFirma.name;
            lblAdres.Text = seciliFirma.location.address;
        }

        private BrowserForm form;

        private void btnHaritadaGoster_Click(object sender, EventArgs e)
        {
            if (seciliFirma == null) return;
            string enlem = seciliFirma.location.lat.ToString().Replace(",", ".");
            string boylam = seciliFirma.location.lng.ToString().Replace(",", ".");
            string url = $"https://www.google.com/maps/@{enlem},{boylam},20z";
            //Process.Start(url); **Kolay yolu**

            if(form == null || form.IsDisposed)
            {
                form = new BrowserForm(new Uri(url), seciliFirma.name); //URL ve title girilmesi zorunlu tutuluyor.
                form.Title = seciliFirma.name;
                form.StartPosition = FormStartPosition.CenterScreen; //Ortada açılsın diye.
                //form.WindowState = FormWindowState.Maximized; //Tam ekran yapar.
                form.Show(); //Birden fazla ekran oluşmasını engeller.
            }

            //form = form ?? new BrowserForm(new Uri(url), seciliFirma.name); //URL ve title girilmesi zorunlu tutuluyor.
            //form.Title = seciliFirma.name;
            //form.StartPosition = FormStartPosition.CenterScreen; //Ortada açılsın diye.
            ////form.WindowState = FormWindowState.Maximized; //Tam ekran yapar.
            //form.Show(); //Birden fazla ekran oluşmasını engeller.
        }
    }
}
