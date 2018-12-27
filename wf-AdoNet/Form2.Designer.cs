namespace wf_AdoNet
{
    partial class Form2
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
            this.btnGetAllCategories = new System.Windows.Forms.Button();
            this.lvCategories = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnGetAllCategories
            // 
            this.btnGetAllCategories.Location = new System.Drawing.Point(140, 21);
            this.btnGetAllCategories.Name = "btnGetAllCategories";
            this.btnGetAllCategories.Size = new System.Drawing.Size(185, 25);
            this.btnGetAllCategories.TabIndex = 0;
            this.btnGetAllCategories.Text = "Get All Categories";
            this.btnGetAllCategories.UseVisualStyleBackColor = true;
            this.btnGetAllCategories.Click += new System.EventHandler(this.btnGetAllCategories_Click);
            // 
            // lvCategories
            // 
            this.lvCategories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvCategories.Location = new System.Drawing.Point(22, 79);
            this.lvCategories.Name = "lvCategories";
            this.lvCategories.Size = new System.Drawing.Size(452, 226);
            this.lvCategories.TabIndex = 1;
            this.lvCategories.UseCompatibleStateImageBehavior = false;
            this.lvCategories.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Category ID";
            this.columnHeader1.Width = 85;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Category Name";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Description";
            this.columnHeader3.Width = 93;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 325);
            this.Controls.Add(this.lvCategories);
            this.Controls.Add(this.btnGetAllCategories);
            this.Name = "Form2";
            this.Text = "ADO.Net ExecuteReader()";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetAllCategories;
        private System.Windows.Forms.ListView lvCategories;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}