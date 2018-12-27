using System;
using System.Windows.Forms;

namespace KisiEnvanteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kisi yeniKisi = new Kisi();
            try
            {
                yeniKisi.Ad = txtAd.Text;
                yeniKisi.Soyad = txtSoyad.Text;
                yeniKisi.Email = txtEmail.Text;
                yeniKisi.Telefon = txtTelefon.Text;
                yeniKisi.TCKN = txtTckn.Text;

                MessageBox.Show($"Hosgeldin {yeniKisi.Ad} {yeniKisi.Soyad}");
                FormuTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormuTemizle()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                    control.Text = string.Empty;
                else if (control is CheckBox)
                    (control as CheckBox).Checked = false;
                else if(control is ListBox lstBox)
                    lstBox.Items.Clear();
            }
        }
    }
}
