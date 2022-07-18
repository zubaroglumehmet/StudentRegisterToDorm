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
    public partial class FrmGiderGuncelle : Form
    {
        public FrmGiderGuncelle()
        {
            InitializeComponent();
        }
        public string aciklama, tutar, tur, tarih, id;

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Odemeler set Aciklama=@p1,Tutar=@p2,Tur=@p3,Tarih=@p4 where Odemeid=@p5", bgl.baglanti());
                komut.Parameters.AddWithValue("@P5", TxtGiderId.Text);
                komut.Parameters.AddWithValue("@P1", Txtaciklama.Text);
                komut.Parameters.AddWithValue("@p2", Txttutar.Text);
                komut.Parameters.AddWithValue("@p3", Txttur.Text);
                komut.Parameters.AddWithValue("@p4", Txttarih.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Guncelleme Başarılı");
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu Yeniden Deneyin");
            }
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void FrmGiderGuncelle_Load(object sender, EventArgs e)
        {
            TxtGiderId.Text = id;
            Txtaciklama.Text = aciklama;
            Txttutar.Text = tutar;
            Txttur.Text = tur;
            Txttarih.Text = tarih;
        }

        
    }
}
