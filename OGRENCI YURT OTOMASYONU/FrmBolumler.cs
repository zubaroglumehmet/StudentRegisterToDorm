using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OGRENCI_YURT_OTOMASYONU
{
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayıtDataSet.Bolumler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumlerTableAdapter.Fill(this.yurtKayıtDataSet.Bolumler);

        }

        private void PcbBolumEkle_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand komut1 = new SqlCommand("insert into Bolumler(BolumAd)values(@Ad)", bgl.baglanti());
                komut1.Parameters.AddWithValue("@Ad", TxtBolumAd.Text);
                komut1.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("BÖLÜM EKLEME BAŞARILI");
                this.bolumlerTableAdapter.Fill(this.yurtKayıtDataSet.Bolumler);
                TxtBolumAd.Text = null;
                TxtBolumid.Text = null;
            }
            catch
            {
                MessageBox.Show("HATA OLUŞTU");
            }
        }

        private void PcbBolumSıl_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut2 = new SqlCommand("delete from Bolumler where Bolumid=@Ad", bgl.baglanti());
                komut2.Parameters.AddWithValue("@Ad", TxtBolumid.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("SILME İŞLEMİ BAŞARILI");
                this.bolumlerTableAdapter.Fill(this.yurtKayıtDataSet.Bolumler);
                TxtBolumAd.Text = null;
                TxtBolumid.Text = null;
            }
            catch (Exception)
            {

                MessageBox.Show("HATA OLUŞTU");
            }
        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, bolumad;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            bolumad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            TxtBolumAd.Text = bolumad;
            TxtBolumid.Text = id;
        }

        private void PcbBolumDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut2 = new SqlCommand("update bolumler Set bolumad=@p1 where bolumid=@p2", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p2", TxtBolumid.Text);
                komut2.Parameters.AddWithValue("@p1", TxtBolumAd.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme Başarılı");
                this.bolumlerTableAdapter.Fill(this.yurtKayıtDataSet.Bolumler);
            }
            catch (Exception)
            {

                MessageBox.Show("HATA OLUŞTU");
            }
        }
    }
}
