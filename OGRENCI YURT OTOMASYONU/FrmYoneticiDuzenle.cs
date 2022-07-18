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
    public partial class FrmYoneticiDuzenle : Form
    {
        public FrmYoneticiDuzenle()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayıtDataSet13.Admin' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.adminTableAdapter.Fill(this.yurtKayıtDataSet13.Admin);

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Admin (YoneticiAd,Yoneticisifre) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtKullanıcıAd.Text);
            komut.Parameters.AddWithValue("@P2", txtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yönetici Eklendi");
            this.adminTableAdapter.Fill(this.yurtKayıtDataSet13.Admin);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad, sifre, id;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[2].Value.ToString();


            TxtKullanıcıAd.Text = ad;
            txtSifre.Text = sifre;
            TxtYoneticiId.Text = id;




        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Admin where Yoneticiid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtYoneticiId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Silme İşlemi Başarılı");
            this.adminTableAdapter.Fill(this.yurtKayıtDataSet13.Admin);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Admin  set YoneticiAd=@p1,Yoneticisifre=@p2 where Yoneticiid=@p3",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKullanıcıAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            komut.Parameters.AddWithValue("@p3", TxtYoneticiId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme Başarılı");
            this.adminTableAdapter.Fill(this.yurtKayıtDataSet13.Admin);

        }
    }
}
