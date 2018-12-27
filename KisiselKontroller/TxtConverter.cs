using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KisiselKontroller
{
    public delegate void SinirAsimiHandler(string mesaj);
    public partial class TxtConverter : UserControl
    {
        public TxtConverter()
        {
            InitializeComponent();
        }

        public event SinirAsimiHandler SinirAsildi;

        public int Sayi { get; set; }
        public DateTime Tarih { get; set; }
        public bool AktifMi { get; set; }
        public Color Renk { get; set; }

        public decimal Value
        {
            get => nuSayi.Value;
            set => nuSayi.Value = value;
        }

        public string ConvertedText => txtOkunus.Text; //Sadece get için böyle yazılabilir. (Read only property)


        private void TxtConverter_Load(object sender, EventArgs e)
        {
            
        }

        private void nuSayi_ValueChanged(object sender, EventArgs e)
        {
            txtOkunus.Text = TextTools.OkunusuGetir(Convert.ToInt32(nuSayi.Value));
            this.ParentForm.Text = txtOkunus.Text;

            int sayi = Convert.ToInt32(nuSayi.Value);
            if(sayi < 0)
            {
                nuSayi.Value = 0;
                SinirAsildi("Sayı 0'dan küçük olamaz.");
                return;
            }
            else if(sayi > 9999)
            {
                nuSayi.Value = 9999;
                SinirAsildi?.Invoke("Sayı 9999'dan büyük olamaz.");
                return;
            }
        }
    }
}
