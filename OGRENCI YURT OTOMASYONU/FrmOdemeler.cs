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
    public partial class FrmOdemeler : Form
    {
        public FrmOdemeler()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl =new SqlBaglantim();
        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayıtDataSet12.Borclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borclarTableAdapter2.Fill(this.yurtKayıtDataSet12.Borclar);
            // TODO: Bu kod satırı 'yurtKayıtDataSet10.Borclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borclarTableAdapter1.Fill(this.yurtKayıtDataSet10.Borclar);
            // TODO: Bu kod satırı 'yurtKayıtDataSet9.Ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciTableAdapter.Fill(this.yurtKayıtDataSet9.Ogrenci);
            // TODO: Bu kod satırı 'yurtKayıtDataSet6.Borclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borclarTableAdapter.Fill(this.yurtKayıtDataSet6.Borclar);

        }

      
    
        private void BtnOdemeAl_Click(object sender, EventArgs e)
        {
            
            //odenen tutari kalan tutardan dusme

            int odenen, kalan, yeniborc;
            odenen = Convert.ToInt16(TxtOdenen.Text);
            kalan = Convert.ToInt16(TxtKalan.Text);
            yeniborc = kalan - odenen;
            TxtKalan.Text = yeniborc.ToString();

            SqlCommand komut = new SqlCommand("update Borclar set ogrkalanborc=@p1 where Ogrid=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", TxtOgrid.Text);
            komut.Parameters.AddWithValue("@p1", TxtKalan.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("ÖDEME ALINDI");
            this.borclarTableAdapter2.Fill(this.yurtKayıtDataSet12.Borclar);
            //KASA TABLOSUNA EKLEME YAPMA

            SqlCommand komut2 = new SqlCommand("insert into Kasa(OdemeAy,OdemeMiktar)values(@k1,@k2)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@k1", TxtOdenenAy.Text);
            komut2.Parameters.AddWithValue("@k2", TxtOdenen.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            this.borclarTableAdapter2.Fill(this.yurtKayıtDataSet12.Borclar);
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad, soyad, kalan;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kalan = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            TxtAd.Text = ad;
            TxtSoyad.Text = soyad;
            TxtOgrid.Text = id;
            TxtKalan.Text = kalan;
            this.borclarTableAdapter2.Fill(this.yurtKayıtDataSet12.Borclar);
        }
    }
}
