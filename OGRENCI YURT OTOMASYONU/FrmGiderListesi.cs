using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OGRENCI_YURT_OTOMASYONU
{
    public partial class FrmGiderListesi : Form
    {
        public FrmGiderListesi()
        {
            InitializeComponent();
        }

        private void FrmGiderListesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayıtDataSet11.Odemeler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.odemelerTableAdapter.Fill(this.yurtKayıtDataSet11.Odemeler);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            FrmGiderGuncelle frg = new FrmGiderGuncelle();
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            frg.id= dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            frg.aciklama = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            frg.tutar = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            frg.tur = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            frg.tarih = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            frg.Show();
        }
    }
}
