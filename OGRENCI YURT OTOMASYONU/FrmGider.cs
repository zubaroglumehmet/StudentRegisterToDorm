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
    public partial class FrmGider : Form
    {
        public FrmGider()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into Odemeler(Aciklama,Tutar,Tur,Tarih)Values(@p1,@p2,@p3,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@P1", Txtaciklama.Text);
                komut.Parameters.AddWithValue("@p2", Txttutar.Text);
                komut.Parameters.AddWithValue("@p3", Txttur.Text);
                komut.Parameters.AddWithValue("@p4", Txttarih.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("KAYIT BAŞARILI ŞEKİLDE OLUŞTURULDU");
            }
            catch (Exception)
            {

                MessageBox.Show("HATA OLUŞTU YENİDEN DENEYİN");
            }
            
        }

        

       
    }
}
