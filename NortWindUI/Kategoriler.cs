using NorthWindDAL;
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
    public partial class Kategoriler : Form
    {
        public Kategoriler()
        {
            InitializeComponent();
        }
        KategoriORM kategoriOrm = new KategoriORM();
        private void Kategoriler_Load(object sender, EventArgs e)
        {
            //   KategoriORM korm =new KategoriORM();
            //dataGridViewKategoriler.DataSource = (new KategoriORM()).Listele();
            dataGridViewKategoriler.DataSource = (kategoriOrm).Listele();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kategoriOrm.Sil(Convert.ToInt32(dataGridViewKategoriler.CurrentRow.Cells[0].Value));
        }
    }
}
