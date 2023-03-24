using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NortWindUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Kategoriler kf = new Kategoriler();
        private void kategorilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (kf.IsDisposed)
            {
                kf = new Kategoriler();
            }
            kf.MdiParent = this;
            kf.Show();
        }
        Urunler urn = new Urunler();
        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (urn.IsDisposed)
            {
                urn = new Urunler();
            }
            urn.MdiParent = this;
            urn.Show();
        }
    }
}
