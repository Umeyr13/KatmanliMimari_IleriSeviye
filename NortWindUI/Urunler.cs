using NorthWindDAL;
using NorthWindEntities;
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
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }

            UrunlerORM urn = new UrunlerORM();
        private void Urunler_Load(object sender, EventArgs e)
        {
            dataGridViewUrunler.DataSource = urn.Listele();

            KategoriORM kategori = new KategoriORM();
            comboBoxKatad.DataSource=kategori.Listele();
            comboBoxKatad.DisplayMember = "KategoriAdi";
            comboBoxKatad.ValueMember = "KategoriID"; 

            TedarikciORM tedarikci = new TedarikciORM();
            comboBoxtedarikciler.DataSource=tedarikci.Listele();
            comboBoxtedarikciler.DisplayMember ="SirketAdi";
            comboBoxtedarikciler.ValueMember = "TedarikciID";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
               Urun u = new Urun();
            u.UrunAdi = textBoxurunadi.Text;
            u.BirimFiyati = numericFiyat.Value;
            u.HedefStokDuzeyi = (short)numericMiktar.Value;
            u.TedarikciID = Convert.ToInt32 ( comboBoxtedarikciler.SelectedValue);
            u.KategoriID = Convert.ToInt32(comboBoxKatad.SelectedValue);
            u.BirimdekiMiktar = "1";
            urn.Ekle(u);
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            Urun u = new Urun();
            u.UrunID =(int)dataGridViewUrunler.CurrentRow.Cells["UrunID"].Value;
            u.UrunAdi= textBoxurunadi.Text;
            u.BirimFiyati =numericFiyat.Value;
            u.HedefStokDuzeyi =(short)numericMiktar.Value;
            u.KategoriID = (int)comboBoxKatad.SelectedValue;
            u.TedarikciID =(int)comboBoxtedarikciler.SelectedValue;
            u.BirimdekiMiktar = "1";
            urn.Guncelle(u);
            urn.Listele();
        }

        private void dataGridViewUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxurunadi.Text = dataGridViewUrunler.CurrentRow.Cells["Urunadi"].Value.ToString();
            numericFiyat.Value=(decimal)dataGridViewUrunler.CurrentRow.Cells["BirimFiyati"].Value;
            numericMiktar.Value=(short)dataGridViewUrunler.CurrentRow.Cells["HedefStokDuzeyi"].Value;
            comboBoxKatad.SelectedValue = dataGridViewUrunler.CurrentRow.Cells["KategoriID"].Value;
            comboBoxtedarikciler.SelectedValue = dataGridViewUrunler.CurrentRow.Cells["TedarikciID"].Value;
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            urn.Sil(Convert.ToInt32(dataGridViewUrunler.CurrentRow.Cells["UrunID"].Value));
              
        }
    }
}
