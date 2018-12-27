namespace KronometreCozum
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
            this.lblSaat = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cbZamanli = new System.Windows.Forms.CheckBox();
            this.dtpZamanli = new System.Windows.Forms.DateTimePicker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDakika = new System.Windows.Forms.Label();
            this.lblSaniye = new System.Windows.Forms.Label();
            this.lblSalise = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaat.Location = new System.Drawing.Point(18, 27);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(45, 29);
            this.lblSaat.TabIndex = 0;
            this.lblSaat.Text = "00";
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(257, 12);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(58, 44);
            this.btnStartStop.TabIndex = 4;
            this.btnStartStop.Text = "Başla";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(257, 62);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(58, 44);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Sıfırla";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbZamanli
            // 
            this.cbZamanli.AutoSize = true;
            this.cbZamanli.Location = new System.Drawing.Point(201, 143);
            this.cbZamanli.Name = "cbZamanli";
            this.cbZamanli.Size = new System.Drawing.Size(76, 17);
            this.cbZamanli.TabIndex = 6;
            this.cbZamanli.Text = "Zamanlı mı";
            this.cbZamanli.UseVisualStyleBackColor = true;
            // 
            // dtpZamanli
            // 
            this.dtpZamanli.CustomFormat = "hh:mm:ss:ms";
            this.dtpZamanli.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpZamanli.Location = new System.Drawing.Point(23, 140);
            this.dtpZamanli.Name = "dtpZamanli";
            this.dtpZamanli.Size = new System.Drawing.Size(172, 20);
            this.dtpZamanli.TabIndex = 7;
            this.dtpZamanli.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpZamanli.ValueChanged += new System.EventHandler(this.dtpZamanli_ValueChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(23, 83);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(206, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDakika
            // 
            this.lblDakika.AutoSize = true;
            this.lblDakika.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDakika.Location = new System.Drawing.Point(68, 27);
            this.lblDakika.Name = "lblDakika";
            this.lblDakika.Size = new System.Drawing.Size(45, 29);
            this.lblDakika.TabIndex = 9;
            this.lblDakika.Text = "00";
            // 
            // lblSaniye
            // 
            this.lblSaniye.AutoSize = true;
            this.lblSaniye.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaniye.Location = new System.Drawing.Point(118, 27);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(45, 29);
            this.lblSaniye.TabIndex = 10;
            this.lblSaniye.Text = "00";
            // 
            // lblSalise
            // 
            this.lblSalise.AutoSize = true;
            this.lblSalise.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalise.Location = new System.Drawing.Point(168, 27);
            this.lblSalise.Name = "lblSalise";
            this.lblSalise.Size = new System.Drawing.Size(61, 29);
            this.lblSalise.TabIndex = 11;
            this.lblSalise.Text = "000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 170);
            this.Controls.Add(this.lblSalise);
            this.Controls.Add(this.lblSaniye);
            this.Controls.Add(this.lblDakika);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dtpZamanli);
            this.Controls.Add(this.cbZamanli);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.lblSaat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckBox cbZamanli;
        private System.Windows.Forms.DateTimePicker dtpZamanli;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDakika;
        private System.Windows.Forms.Label lblSaniye;
        private System.Windows.Forms.Label lblSalise;
    }
}

