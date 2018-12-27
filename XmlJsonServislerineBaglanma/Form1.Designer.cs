namespace XmlJsonServislerineBaglanma
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblKod = new System.Windows.Forms.Label();
            this.lblDeger = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lstFirmalar = new System.Windows.Forms.ListBox();
            this.btnGetir = new System.Windows.Forms.Button();
            this.lblFirmaAdi = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblHereNow = new System.Windows.Forms.Label();
            this.btnHaritadaGoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKod
            // 
            this.lblKod.AutoSize = true;
            this.lblKod.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKod.ForeColor = System.Drawing.Color.DarkRed;
            this.lblKod.Location = new System.Drawing.Point(12, 9);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(85, 34);
            this.lblKod.TabIndex = 0;
            this.lblKod.Text = "lblKod";
            // 
            // lblDeger
            // 
            this.lblDeger.AutoSize = true;
            this.lblDeger.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeger.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblDeger.Location = new System.Drawing.Point(12, 46);
            this.lblDeger.Name = "lblDeger";
            this.lblDeger.Size = new System.Drawing.Size(106, 34);
            this.lblDeger.TabIndex = 1;
            this.lblDeger.Text = "lblDeger";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(18, 153);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(182, 121);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lstFirmalar
            // 
            this.lstFirmalar.FormattingEnabled = true;
            this.lstFirmalar.Location = new System.Drawing.Point(212, 9);
            this.lstFirmalar.Name = "lstFirmalar";
            this.lstFirmalar.Size = new System.Drawing.Size(182, 264);
            this.lstFirmalar.TabIndex = 3;
            this.lstFirmalar.SelectedIndexChanged += new System.EventHandler(this.lstFirmalar_SelectedIndexChanged);
            // 
            // btnGetir
            // 
            this.btnGetir.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetir.Location = new System.Drawing.Point(427, 9);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(75, 46);
            this.btnGetir.TabIndex = 4;
            this.btnGetir.Text = "ÇAYLA!";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // lblFirmaAdi
            // 
            this.lblFirmaAdi.AutoSize = true;
            this.lblFirmaAdi.Location = new System.Drawing.Point(424, 89);
            this.lblFirmaAdi.Name = "lblFirmaAdi";
            this.lblFirmaAdi.Size = new System.Drawing.Size(50, 13);
            this.lblFirmaAdi.TabIndex = 5;
            this.lblFirmaAdi.Text = "Firma Adı";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(424, 125);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(34, 13);
            this.lblAdres.TabIndex = 6;
            this.lblAdres.Text = "Adres";
            // 
            // lblHereNow
            // 
            this.lblHereNow.AutoSize = true;
            this.lblHereNow.Location = new System.Drawing.Point(424, 164);
            this.lblHereNow.Name = "lblHereNow";
            this.lblHereNow.Size = new System.Drawing.Size(98, 13);
            this.lblHereNow.TabIndex = 7;
            this.lblHereNow.Text = "Şu an kaç kişi var?";
            // 
            // btnHaritadaGoster
            // 
            this.btnHaritadaGoster.Location = new System.Drawing.Point(430, 226);
            this.btnHaritadaGoster.Name = "btnHaritadaGoster";
            this.btnHaritadaGoster.Size = new System.Drawing.Size(75, 46);
            this.btnHaritadaGoster.TabIndex = 8;
            this.btnHaritadaGoster.Text = "Haritada Göster";
            this.btnHaritadaGoster.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 284);
            this.Controls.Add(this.btnHaritadaGoster);
            this.Controls.Add(this.lblHereNow);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblFirmaAdi);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.lstFirmalar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblDeger);
            this.Controls.Add(this.lblKod);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKod;
        private System.Windows.Forms.Label lblDeger;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox lstFirmalar;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Label lblFirmaAdi;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblHereNow;
        private System.Windows.Forms.Button btnHaritadaGoster;
    }
}

