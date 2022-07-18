﻿using System;
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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select*from Admin where YoneticiAd=@p1 and yoneticisifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if(oku.Read())
            {
                FrmAnaSayfa fr = new FrmAnaSayfa();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatali Kullanici Adi Yada Sifre ");
                TxtKullaniciAdi.Clear();
                TxtSifre.Clear();
                TxtKullaniciAdi.Focus();

            }
            bgl.baglanti().Close();
        }
    }
}
