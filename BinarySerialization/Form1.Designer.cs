namespace BinarySerialization
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
            this.btnAc = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dosyaAc = new System.Windows.Forms.OpenFileDialog();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.dosyaKaydet = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAc
            // 
            this.btnAc.Location = new System.Drawing.Point(31, 30);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(75, 23);
            this.btnAc.TabIndex = 0;
            this.btnAc.Text = "Aç";
            this.btnAc.UseVisualStyleBackColor = true;
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(146, 30);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dosyaAc
            // 
            this.dosyaAc.FileName = "dosyaAc";
            // 
            // pbResim
            // 
            this.pbResim.Location = new System.Drawing.Point(31, 59);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(190, 203);
            this.pbResim.TabIndex = 2;
            this.pbResim.TabStop = false;
            // 
            // dosyaKaydet
            // 
            this.dosyaKaydet.FileOk += new System.ComponentModel.CancelEventHandler(this.dosyaKaydet_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 281);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnAc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAc;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.OpenFileDialog dosyaAc;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.SaveFileDialog dosyaKaydet;
    }
}

