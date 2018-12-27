namespace Cs.App
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
            this.gbYakinSaldiri = new System.Windows.Forms.GroupBox();
            this.btnSaldir = new System.Windows.Forms.Button();
            this.gbFirlatilan = new System.Windows.Forms.GroupBox();
            this.btnFirlat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSilahlar = new System.Windows.Forms.ComboBox();
            this.gb_AstesliSilah = new System.Windows.Forms.GroupBox();
            this.btnYenidenDoldur = new System.Windows.Forms.Button();
            this.lblDurum = new System.Windows.Forms.Label();
            this.btnAtesEt = new System.Windows.Forms.Button();
            this.lblDetay = new System.Windows.Forms.Label();
            this.panelSilah = new System.Windows.Forms.Panel();
            this.gbYakinSaldiri.SuspendLayout();
            this.gbFirlatilan.SuspendLayout();
            this.gb_AstesliSilah.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbYakinSaldiri
            // 
            this.gbYakinSaldiri.Controls.Add(this.btnSaldir);
            this.gbYakinSaldiri.Location = new System.Drawing.Point(16, 202);
            this.gbYakinSaldiri.Name = "gbYakinSaldiri";
            this.gbYakinSaldiri.Size = new System.Drawing.Size(276, 100);
            this.gbYakinSaldiri.TabIndex = 0;
            this.gbYakinSaldiri.TabStop = false;
            this.gbYakinSaldiri.Text = "Yakın Saldırı Kontrol";
            this.gbYakinSaldiri.Visible = false;
            this.gbYakinSaldiri.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSaldir
            // 
            this.btnSaldir.Location = new System.Drawing.Point(6, 19);
            this.btnSaldir.Name = "btnSaldir";
            this.btnSaldir.Size = new System.Drawing.Size(77, 75);
            this.btnSaldir.TabIndex = 1;
            this.btnSaldir.Text = "Saldır";
            this.btnSaldir.UseVisualStyleBackColor = true;
            this.btnSaldir.Click += new System.EventHandler(this.btnSaldir_Click);
            // 
            // gbFirlatilan
            // 
            this.gbFirlatilan.Controls.Add(this.btnFirlat);
            this.gbFirlatilan.Location = new System.Drawing.Point(298, 202);
            this.gbFirlatilan.Name = "gbFirlatilan";
            this.gbFirlatilan.Size = new System.Drawing.Size(276, 100);
            this.gbFirlatilan.TabIndex = 1;
            this.gbFirlatilan.TabStop = false;
            this.gbFirlatilan.Text = "Fırlatılan Silah Kontrol";
            this.gbFirlatilan.Visible = false;
            // 
            // btnFirlat
            // 
            this.btnFirlat.Location = new System.Drawing.Point(6, 19);
            this.btnFirlat.Name = "btnFirlat";
            this.btnFirlat.Size = new System.Drawing.Size(77, 75);
            this.btnFirlat.TabIndex = 0;
            this.btnFirlat.Text = "Fırlat";
            this.btnFirlat.UseVisualStyleBackColor = true;
            this.btnFirlat.Click += new System.EventHandler(this.btnFirlat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Silah Seçiniz";
            // 
            // cmbSilahlar
            // 
            this.cmbSilahlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSilahlar.FormattingEnabled = true;
            this.cmbSilahlar.Location = new System.Drawing.Point(105, 13);
            this.cmbSilahlar.Name = "cmbSilahlar";
            this.cmbSilahlar.Size = new System.Drawing.Size(187, 21);
            this.cmbSilahlar.TabIndex = 3;
            this.cmbSilahlar.SelectedIndexChanged += new System.EventHandler(this.cmbSilahlar_SelectedIndexChanged);
            // 
            // gb_AstesliSilah
            // 
            this.gb_AstesliSilah.Controls.Add(this.btnYenidenDoldur);
            this.gb_AstesliSilah.Controls.Add(this.lblDurum);
            this.gb_AstesliSilah.Controls.Add(this.btnAtesEt);
            this.gb_AstesliSilah.Location = new System.Drawing.Point(16, 96);
            this.gb_AstesliSilah.Name = "gb_AstesliSilah";
            this.gb_AstesliSilah.Size = new System.Drawing.Size(276, 100);
            this.gb_AstesliSilah.TabIndex = 4;
            this.gb_AstesliSilah.TabStop = false;
            this.gb_AstesliSilah.Text = "Silah Kontrol";
            this.gb_AstesliSilah.Visible = false;
            // 
            // btnYenidenDoldur
            // 
            this.btnYenidenDoldur.Location = new System.Drawing.Point(89, 19);
            this.btnYenidenDoldur.Name = "btnYenidenDoldur";
            this.btnYenidenDoldur.Size = new System.Drawing.Size(77, 75);
            this.btnYenidenDoldur.TabIndex = 2;
            this.btnYenidenDoldur.Text = "Doldur";
            this.btnYenidenDoldur.UseVisualStyleBackColor = true;
            this.btnYenidenDoldur.Click += new System.EventHandler(this.btnYenidenDoldur_Click);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurum.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDurum.Location = new System.Drawing.Point(172, 35);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(77, 31);
            this.lblDurum.TabIndex = 4;
            this.lblDurum.Text = "label2";
            // 
            // btnAtesEt
            // 
            this.btnAtesEt.Location = new System.Drawing.Point(6, 19);
            this.btnAtesEt.Name = "btnAtesEt";
            this.btnAtesEt.Size = new System.Drawing.Size(77, 75);
            this.btnAtesEt.TabIndex = 1;
            this.btnAtesEt.Text = "Ateş Et";
            this.btnAtesEt.UseVisualStyleBackColor = true;
            this.btnAtesEt.Click += new System.EventHandler(this.btnAtesEt_Click);
            this.btnAtesEt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAtesEt_MouseDown);
            this.btnAtesEt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAtesEt_MouseUp);
            // 
            // lblDetay
            // 
            this.lblDetay.AutoSize = true;
            this.lblDetay.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetay.ForeColor = System.Drawing.Color.Chocolate;
            this.lblDetay.Location = new System.Drawing.Point(18, 43);
            this.lblDetay.Name = "lblDetay";
            this.lblDetay.Size = new System.Drawing.Size(0, 19);
            this.lblDetay.TabIndex = 3;
            // 
            // panelSilah
            // 
            this.panelSilah.Location = new System.Drawing.Point(298, 12);
            this.panelSilah.Name = "panelSilah";
            this.panelSilah.Size = new System.Drawing.Size(276, 184);
            this.panelSilah.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 314);
            this.Controls.Add(this.lblDetay);
            this.Controls.Add(this.panelSilah);
            this.Controls.Add(this.gb_AstesliSilah);
            this.Controls.Add(this.cmbSilahlar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbFirlatilan);
            this.Controls.Add(this.gbYakinSaldiri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbYakinSaldiri.ResumeLayout(false);
            this.gbFirlatilan.ResumeLayout(false);
            this.gb_AstesliSilah.ResumeLayout(false);
            this.gb_AstesliSilah.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbYakinSaldiri;
        private System.Windows.Forms.GroupBox gbFirlatilan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSilahlar;
        private System.Windows.Forms.Button btnFirlat;
        private System.Windows.Forms.Button btnSaldir;
        private System.Windows.Forms.GroupBox gb_AstesliSilah;
        private System.Windows.Forms.Button btnAtesEt;
        private System.Windows.Forms.Button btnYenidenDoldur;
        private System.Windows.Forms.Label lblDetay;
        private System.Windows.Forms.Panel panelSilah;
        private System.Windows.Forms.Label lblDurum;
    }
}

