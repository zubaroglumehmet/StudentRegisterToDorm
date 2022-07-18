namespace OGRENCI_YURT_OTOMASYONU
{
    partial class FrmGiderGuncelle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txttarih = new System.Windows.Forms.TextBox();
            this.LblTarih = new System.Windows.Forms.Label();
            this.Txttutar = new System.Windows.Forms.TextBox();
            this.LblTutar = new System.Windows.Forms.Label();
            this.Txttur = new System.Windows.Forms.TextBox();
            this.LblTur = new System.Windows.Forms.Label();
            this.Txtaciklama = new System.Windows.Forms.TextBox();
            this.LblAciklama = new System.Windows.Forms.Label();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.TxtGiderId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txttarih
            // 
            this.Txttarih.Location = new System.Drawing.Point(198, 224);
            this.Txttarih.Name = "Txttarih";
            this.Txttarih.Size = new System.Drawing.Size(158, 20);
            this.Txttarih.TabIndex = 17;
            // 
            // LblTarih
            // 
            this.LblTarih.Location = new System.Drawing.Point(32, 224);
            this.LblTarih.Name = "LblTarih";
            this.LblTarih.Size = new System.Drawing.Size(143, 30);
            this.LblTarih.TabIndex = 16;
            this.LblTarih.Text = "GİDERİN TARİHİ";
            // 
            // Txttutar
            // 
            this.Txttutar.Location = new System.Drawing.Point(200, 121);
            this.Txttutar.Name = "Txttutar";
            this.Txttutar.Size = new System.Drawing.Size(158, 20);
            this.Txttutar.TabIndex = 15;
            // 
            // LblTutar
            // 
            this.LblTutar.Location = new System.Drawing.Point(32, 121);
            this.LblTutar.Name = "LblTutar";
            this.LblTutar.Size = new System.Drawing.Size(143, 30);
            this.LblTutar.TabIndex = 14;
            this.LblTutar.Text = "GİDERİN TUTARI";
            // 
            // Txttur
            // 
            this.Txttur.Location = new System.Drawing.Point(198, 167);
            this.Txttur.Name = "Txttur";
            this.Txttur.Size = new System.Drawing.Size(158, 20);
            this.Txttur.TabIndex = 13;
            // 
            // LblTur
            // 
            this.LblTur.Location = new System.Drawing.Point(32, 167);
            this.LblTur.Name = "LblTur";
            this.LblTur.Size = new System.Drawing.Size(143, 30);
            this.LblTur.TabIndex = 12;
            this.LblTur.Text = "GİDERİN TÜRÜ";
            // 
            // Txtaciklama
            // 
            this.Txtaciklama.Location = new System.Drawing.Point(200, 67);
            this.Txtaciklama.Name = "Txtaciklama";
            this.Txtaciklama.Size = new System.Drawing.Size(158, 20);
            this.Txtaciklama.TabIndex = 11;
            // 
            // LblAciklama
            // 
            this.LblAciklama.Location = new System.Drawing.Point(32, 67);
            this.LblAciklama.Name = "LblAciklama";
            this.LblAciklama.Size = new System.Drawing.Size(143, 30);
            this.LblAciklama.TabIndex = 10;
            this.LblAciklama.Text = "GİDERİN AÇIKLAMASI";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(153, 279);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(127, 49);
            this.BtnGuncelle.TabIndex = 9;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // TxtGiderId
            // 
            this.TxtGiderId.Location = new System.Drawing.Point(200, 21);
            this.TxtGiderId.Name = "TxtGiderId";
            this.TxtGiderId.Size = new System.Drawing.Size(158, 20);
            this.TxtGiderId.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "GİDER ID";
            // 
            // FrmGiderGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(425, 366);
            this.Controls.Add(this.TxtGiderId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txttarih);
            this.Controls.Add(this.LblTarih);
            this.Controls.Add(this.Txttutar);
            this.Controls.Add(this.LblTutar);
            this.Controls.Add(this.Txttur);
            this.Controls.Add(this.LblTur);
            this.Controls.Add(this.Txtaciklama);
            this.Controls.Add(this.LblAciklama);
            this.Controls.Add(this.BtnGuncelle);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGiderGuncelle";
            this.Text = "Gider Guncelle";
            this.Load += new System.EventHandler(this.FrmGiderGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txttarih;
        private System.Windows.Forms.Label LblTarih;
        private System.Windows.Forms.TextBox Txttutar;
        private System.Windows.Forms.Label LblTutar;
        private System.Windows.Forms.TextBox Txttur;
        private System.Windows.Forms.Label LblTur;
        private System.Windows.Forms.TextBox Txtaciklama;
        private System.Windows.Forms.Label LblAciklama;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.TextBox TxtGiderId;
        private System.Windows.Forms.Label label1;
    }
}