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
    public partial class KalanBorc : Form
    {
        public KalanBorc()
        {
            InitializeComponent();
        }

        

        private void KalanBorc_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayıtDataSet5.Ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciTableAdapter4.Fill(this.yurtKayıtDataSet5.Ogrenci);
            // TODO: Bu kod satırı 'yurtKayıtDataSet4.Ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciTableAdapter3.Fill(this.yurtKayıtDataSet4.Ogrenci);
            // TODO: Bu kod satırı 'yurtKayıtDataSet3.Ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciTableAdapter2.Fill(this.yurtKayıtDataSet3.Ogrenci);
            // TODO: Bu kod satırı 'yurtKayıtDataSet2.Ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciTableAdapter1.Fill(this.yurtKayıtDataSet2.Ogrenci);
            // TODO: Bu kod satırı 'yurtKayıtDataSet1.Ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciTableAdapter.Fill(this.yurtKayıtDataSet1.Ogrenci);
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToLongDateString();
            label7.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
