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
    public partial class FrmOgrKayıt : Form
    {
        public FrmOgrKayıt()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void Form1_Load(object sender, EventArgs e)
        {
           // BÖLÜMLERİ LİSTELEME KOMUTLARI
            SqlCommand komut = new SqlCommand("Select BolumAd From Bolumler", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                CmbBolum.Items.Add(oku[0].ToString());
            }
            bgl.baglanti().Close();
            //BOŞ ODALARI LİSTELEME KOMUTLARI

            SqlCommand komut2 = new SqlCommand("Select Odano From Odalar where OdaKapasite != OdaAktif", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while(oku2.Read())
            {
                CmbOdaNo.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

            //Odadaki Öğrenci Sayısını Arttırma
            SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktif=OdaAktif+1 where OdaNo=@oda1", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda1", CmbOdaNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();

            //OGRENCI BILGILERININ KAYIT EDILME KOMUTLARI
            try
            {
                
                SqlCommand komutkaydet = new SqlCommand("insert into Ogrenci(OgrAd,OgrSoyad,OgrTC,OgrTelefon,OgrDogum,OgrBolum,OgrMail,OgrOdaNo,OgrVeliAdSoyad,OgrVeliTelefon,OgrVeliAdres,OgrKanGrubu) values(@Ad,@Soyad,@TC,@Telefon,@Dogum,@Bolum,@Mail,@OdaNo,@VeliAdSoyad,@VeliTelefon,@VeliAdres,@KanGrubu)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@Ad", TxtOgrAd.Text);
                komutkaydet.Parameters.AddWithValue("@Soyad", TxtOgrSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@TC", MskTC.Text);
                komutkaydet.Parameters.AddWithValue("@Telefon", MskOgrTelefon.Text);
                komutkaydet.Parameters.AddWithValue("@Dogum", MskDogum.Text);
                komutkaydet.Parameters.AddWithValue("@Bolum", CmbBolum.Text);
                komutkaydet.Parameters.AddWithValue("@Mail", TxtMail.Text);
                komutkaydet.Parameters.AddWithValue("@OdaNo", CmbOdaNo.Text);
                komutkaydet.Parameters.AddWithValue("@VeliAdSoyad", TxtVeliAdSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@VeliTelefon", MskVeliTelefon.Text);
                komutkaydet.Parameters.AddWithValue("@VeliAdres", RchAdres.Text);
                komutkaydet.Parameters.AddWithValue("@KanGrubu", textBox1.Text);
                komutkaydet.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("BAŞARILI BİR ŞEKİLDE KAYIT OLUŞTURULDU");


                //OGRENCI ID YI LABELE CEKME
                SqlCommand komut = new SqlCommand("select Ogrid from Ogrenci", bgl.baglanti());

                SqlDataReader oku = komut.ExecuteReader();
                while(oku.Read())
                {
                    label13.Text = oku[0].ToString();
                }
                bgl.baglanti().Close();

                // YENİ BORÇ OLUŞTURMA

                SqlCommand komutkaydet2 = new SqlCommand("insert into Borclar (Ogrid,OgrAd,OgrSoyad) values (@x1,@x2,@x3)", bgl.baglanti());
                komutkaydet2.Parameters.AddWithValue("@x1", label13.Text);
                komutkaydet2.Parameters.AddWithValue("@x2", TxtOgrAd.Text);
                komutkaydet2.Parameters.AddWithValue("@x3", TxtOgrSoyad.Text);
                bgl.baglanti().Close();

            }
            catch (Exception)
            {
              MessageBox.Show("HATA OLUSTU!! PROGRAMI KAPATIP TEKRAR DENEYIN");

            }

           


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtOgrAd.Text = "";
            TxtOgrSoyad.Text = "";
            MskTC.Text = "";
            TxtOgrAd.Text = "";
            TxtOgrSoyad.Text = "";
            MskTC.Text = "";
            MskOgrTelefon.Text = "";
            MskDogum.Text ="";
            CmbBolum.Text ="";
            TxtMail.Text = "";
            CmbOdaNo.Text = "";
            TxtVeliAdSoyad.Text = "";
            MskVeliTelefon.Text="";
            RchAdres.Text = "";
            textBox1.Text = "";
        }

        
    }
}
