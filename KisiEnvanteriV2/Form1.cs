﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace KisiEnvanteriV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Kisi> kisiler = new List<Kisi>();
        List<Kisi> aramalar = new List<Kisi>();

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
                if(memoryStream.Length > 0)
                {
                    yeniKisi.Fotograf = memoryStream.ToArray();
                }
                memoryStream = new MemoryStream();

                kisiler.Add(yeniKisi);
                //MessageBox.Show($"Hosgeldin {yeniKisi.Ad} {yeniKisi.Soyad}");
                FormuTemizle();
                lstKisiler.Items.AddRange(kisiler.ToArray());
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
                {
                    if (control.Name == "txtAra")
                        continue;
                    control.Text = string.Empty;
                }
                else if (control is CheckBox)
                    (control as CheckBox).Checked = false;
                else if (control is ListBox lstBox)
                    lstBox.Items.Clear();
                else if (control is PictureBox)
                    pictureBox1.Image = null;
            }
        }

        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;

            //Kisi seciliKisi = lstKisiler.SelectedItem as Kisi;
            Kisi seciliKisi = (Kisi)lstKisiler.SelectedItem;
            txtAd.Text = seciliKisi.Ad;
            txtSoyad.Text = seciliKisi.Soyad;
            txtEmail.Text = seciliKisi.Email;
            txtTelefon.Text = seciliKisi.Telefon;
            txtTckn.Text = seciliKisi.TCKN;
            if(seciliKisi.Fotograf != null && seciliKisi.Fotograf.Length > 0)
            {
                pictureBox1.Image = new Bitmap(new MemoryStream(seciliKisi.Fotograf));
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;

            Kisi seciliKisi = (Kisi)lstKisiler.SelectedItem;

            try
            {
                seciliKisi.Ad = txtAd.Text;
                seciliKisi.Soyad = txtSoyad.Text;
                seciliKisi.TCKN = txtTckn.Text;
                seciliKisi.Telefon = txtTelefon.Text;
                seciliKisi.Email = txtEmail.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            FormuTemizle();
            lstKisiler.Items.AddRange(kisiler.ToArray());

        }

        private void txtAra_KeyUp(object sender, KeyEventArgs e)
        {
            string ara = txtAra.Text.ToLower();
            aramalar = new List<Kisi>();

            //foreach (Kisi kisi in kisiler)
            //{
            //    if (kisi.Ad.ToLower().Contains(ara) || kisi.Soyad.ToLower().Contains(ara) ||
            //        kisi.TCKN.StartsWith(ara))
            //    {
            //        aramalar.Add(kisi);
            //    }
            //}

            //Linq
            kisiler.Where(kisi => kisi.Ad.ToLower().Contains(ara) || kisi.Soyad.ToLower().Contains(ara) || kisi.TCKN.StartsWith(ara)).ToList().ForEach(kisi => aramalar.Add(kisi));

            FormuTemizle();
            lstKisiler.Items.AddRange(aramalar.ToArray());
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;

            Kisi seciliKisi = (Kisi)lstKisiler.SelectedItem;
            kisiler.Remove(seciliKisi);

            FormuTemizle();
            lstKisiler.Items.AddRange(kisiler.ToArray());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void jSONToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dışarıAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyaKaydet.Title = "Bir XML dosyası seçiniz";
            dosyaKaydet.Filter = "(XML Dosyası) | *.xml;";
            dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaKaydet.FileName = "Kisiler.xml";

            if(dosyaKaydet.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Kisi>));
                TextWriter textWriter = new StreamWriter(dosyaKaydet.FileName);
                serializer.Serialize(textWriter, kisiler); //Kisi class'ı public olmalı
                textWriter.Close();
                textWriter.Dispose();
                MessageBox.Show($"XML başarıyla dışa aktarıldı: {dosyaKaydet.FileName}");
            }
        }

        private void btnHop_Click(object sender, EventArgs e)
        {
            txtAd.Text = "Alpero";
            txtSoyad.Text = "Maduro";
            txtEmail.Text = "alperomaduro@gmail.com";
            txtTelefon.Text = "012345678901";
            txtTckn.Text = "12345678901";
        }

        private void içeriAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "Bir XML dosyası seçiniz";
            dosyaAc.Filter = "(XML Dosyası) | *.xml;";
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaAc.FileName = "Kisiler.xml";

            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Kisi>));
                XmlReader reader = new XmlTextReader(dosyaAc.FileName);
                if (xmlSerializer.CanDeserialize(reader))
                {
                    kisiler = xmlSerializer.Deserialize(reader) as List<Kisi>;
                    MessageBox.Show($"{kisiler.Count} kişi sisteme başarıyla eklendi.");
                    lstKisiler.Items.Clear();
                    lstKisiler.Items.AddRange(kisiler.ToArray());
                }
                else
                {
                    MessageBox.Show("Lütfen bir XML dosyası seçin.");
                }
            }
        }

        private void dışarıAktarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dosyaKaydet.Title = "Bir JSON dosyası seçiniz";
            dosyaKaydet.Filter = "(JSON Dosyası) | *.json;";
            dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaKaydet.FileName = "Kisiler.json";

            if (dosyaKaydet.ShowDialog() == DialogResult.OK)
            {
                FileStream file = File.Open(dosyaKaydet.FileName, FileMode.Open);
                StreamWriter writer = new StreamWriter(file);
                writer.Write(JsonConvert.SerializeObject(kisiler));
                writer.Close();
                writer.Dispose();
                MessageBox.Show($"JSON başarıyla dışa aktarıldı: {dosyaKaydet.FileName}");
            }
        }

        private void içeriAktarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "Bir JSON dosyası seçiniz";
            dosyaAc.Filter = "(JSON Dosyası) | *.json;";
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaAc.FileName = "Kisiler.json";

            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream dosya = File.OpenRead(dosyaAc.FileName);
                    StreamReader reader = new StreamReader(dosya);
                    string dosyaIcerigi = reader.ReadToEnd();
                    reader.Close();
                    dosya.Close();
                    kisiler = JsonConvert.DeserializeObject<List<Kisi>>(dosyaIcerigi);
                    //kisiler = JsonConvert.DeserializeObject(dosyaIcerigi) as List<Kisi>;
                    //kisiler = (List<Kisi>)JsonConvert.DeserializeObject(dosyaIcerigi);

                    MessageBox.Show($"{kisiler.Count} kişi sisteme başarıyla eklendi.");
                    lstKisiler.Items.Clear();
                    lstKisiler.Items.AddRange(kisiler.ToArray());
                }
                catch (Exception)
                {
                    MessageBox.Show("Bir hara oluştu.");
                }
            }
        }

        MemoryStream memoryStream = new MemoryStream();
        int bufferSize = 64;
        byte[] resimArray = new byte[64];

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "Bir fotoğraf dosyasını seçiniz.";
            dosyaAc.Filter = "JPG | *.jpg";
            dosyaAc.Multiselect = false;
            dosyaAc.FileName = string.Empty;
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if(dosyaAc.ShowDialog() == DialogResult.OK)
            {
                FileStream dosya = File.Open(dosyaAc.FileName, FileMode.Open);
                while(dosya.Read(resimArray,0,bufferSize) != 0)
                {
                    memoryStream.Write(resimArray, 0, resimArray.Length);
                }
                dosya.Close();
                dosya.Dispose();
                pictureBox1.Image = new Bitmap(memoryStream);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }
    }
}
