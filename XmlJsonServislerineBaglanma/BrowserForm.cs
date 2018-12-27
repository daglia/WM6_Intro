﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XmlJsonServislerineBaglanma
{
    public partial class BrowserForm : Form
    {
        public BrowserForm(Uri url, string title)
        {
            InitializeComponent();
            this.Url = url;
            this.Title = title;
        }

        public Uri Url { get; set; }
        public string Title { get; set; }

        private void BrowserForm_Load(object sender, EventArgs e)
        {
            this.webBrowser1.Url = Url;
            this.Text = Title;
        }
    }
}
