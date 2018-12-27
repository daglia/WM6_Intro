using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KisiEnvanteri
{
    public partial class Form1 : Form
    {
        List<Kisi> kisiler = new List<Kisi>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (txtAd.Text == string.Empty)
            {
                MessageBox.Show("Ad boş bırakılamaz.");
            }
            else if (txtSoyad.Text == string.Empty)
            {
                MessageBox.Show("Soyad boş bırakılamaz.");
            }
            else if (txtTelefon.Text == string.Empty)
            {
                MessageBox.Show("Telefon boş bırakılamaz.");
            }
            else if (txtMail.Text == string.Empty)
            {
                MessageBox.Show("E-posta boş bırakılamaz.");
            }
            else if (txtKimlikNo.Text == string.Empty)
            {
                MessageBox.Show("Kimlik no boş bırakılamaz.");
            }
            else
            {
                Kisi yeniKisi = new Kisi();
                try
                {
                    yeniKisi.Ad = txtAd.Text;
                    yeniKisi.Soyad = txtSoyad.Text;
                    yeniKisi.Telefon = txtTelefon.Text;
                    yeniKisi.Mail = txtMail.Text;
                    yeniKisi.TCKN = txtKimlikNo.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                try
                {
                    yeniKisi.Ad = txtAd.Text;
                    yeniKisi.Soyad = txtSoyad.Text;
                    yeniKisi.Telefon = txtTelefon.Text;
                    yeniKisi.Mail = txtMail.Text;
                    yeniKisi.TCKN = txtKimlikNo.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                FormuTemizle();
            }
        }

        private void FormuTemizle()
        {
            txtAd.Text = string.Empty;
            txtSoyad.Text = string.Empty;
            txtTelefon.Text = string.Empty;
            txtMail.Text = string.Empty;
            txtKimlikNo.Text = string.Empty;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            lstListe.Items.Remove(lstListe.SelectedItem);
            FormuTemizle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            lstListe.Items.AddRange(kisiler.ToArray());

            lstListe.SelectionMode = SelectionMode.One;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(lstListe.SelectedIndex >= 0)
            {
                lstListe.Items.Remove(lstListe.SelectedItem);
                lstListe.Items.Insert(lstListe.SelectedIndex, lstListe.Text);
            }
            else
            {
                MessageBox.Show("Seçim yapmadınız.");
            }
        }

        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
