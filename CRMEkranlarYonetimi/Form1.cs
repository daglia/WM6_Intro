using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMEkranlarYonetimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private FrmNew _frmNew;
        private FrmOpen _frmOpen;
        public List<int> Sayilar;

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_frmNew == null || _frmNew.IsDisposed)
            {
                _frmNew = new FrmNew();
                _frmNew.MdiParent = this; //Form içinde -parent'ında- oluşacak
                _frmNew.Show();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmOpen == null || _frmOpen.IsDisposed)
            {
                _frmOpen = new FrmOpen();
                _frmOpen.MdiParent = this;
                _frmOpen.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sayilar = new List<int>(new int[]{1,4,1,5,32,4,23,5,3});
        }
    }
}
