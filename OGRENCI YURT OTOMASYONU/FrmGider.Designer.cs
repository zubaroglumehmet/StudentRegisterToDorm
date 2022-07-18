namespace OGRENCI_YURT_OTOMASYONU
{
    partial class FrmGider
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
            this.button1 = new System.Windows.Forms.Button();
            this.LblAciklama = new System.Windows.Forms.Label();
            this.Txtaciklama = new System.Windows.Forms.TextBox();
            this.Txttur = new System.Windows.Forms.TextBox();
            this.LblTur = new System.Windows.Forms.Label();
            this.Txttutar = new System.Windows.Forms.TextBox();
            this.LblTutar = new System.Windows.Forms.Label();
            this.Txttarih = new System.Windows.Forms.TextBox();
            this.LblTarih = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblAciklama
            // 
            this.LblAciklama.Location = new System.Drawing.Point(12, 36);
            this.LblAciklama.Name = "LblAciklama";
            this.LblAciklama.Size = new System.Drawing.Size(143, 30);
            this.LblAciklama.TabIndex = 1;
            this.LblAciklama.Text = "GİDERİN AÇIKLAMASI";
            // 
            // Txtaciklama
            // 
            this.Txtaciklama.Location = new System.Drawing.Point(163, 36);
            this.Txtaciklama.Name = "Txtaciklama";
            this.Txtaciklama.Size = new System.Drawing.Size(158, 20);
            this.Txtaciklama.TabIndex = 1;
            // 
            // Txttur
            // 
            this.Txttur.Location = new System.Drawing.Point(161, 136);
            this.Txttur.Name = "Txttur";
            this.Txttur.Size = new System.Drawing.Size(158, 20);
            this.Txttur.TabIndex = 3;
            // 
            // LblTur
            // 
            this.LblTur.Location = new System.Drawing.Point(12, 134);
            this.LblTur.Name = "LblTur";
            this.LblTur.Size = new System.Drawing.Size(143, 30);
            this.LblTur.TabIndex = 3;
            this.LblTur.Text = "GİDERİN TÜRÜ";
            // 
            // Txttutar
            // 
            this.Txttutar.Location = new System.Drawing.Point(163, 90);
            this.Txttutar.Name = "Txttutar";
            this.Txttutar.Size = new System.Drawing.Size(158, 20);
            this.Txttutar.TabIndex = 2;
            // 
            // LblTutar
            // 
            this.LblTutar.Location = new System.Drawing.Point(12, 90);
            this.LblTutar.Name = "LblTutar";
            this.LblTutar.Size = new System.Drawing.Size(143, 30);
            this.LblTutar.TabIndex = 5;
            this.LblTutar.Text = "GİDERİN TUTARI";
            // 
            // Txttarih
            // 
            this.Txttarih.Location = new System.Drawing.Point(161, 193);
            this.Txttarih.Name = "Txttarih";
            this.Txttarih.Size = new System.Drawing.Size(158, 20);
            this.Txttarih.TabIndex = 4;
            // 
            // LblTarih
            // 
            this.LblTarih.Location = new System.Drawing.Point(12, 193);
            this.LblTarih.Name = "LblTarih";
            this.LblTarih.Size = new System.Drawing.Size(143, 30);
            this.LblTarih.TabIndex = 7;
            this.LblTarih.Text = "GİDERİN TARİHİ";
            // 
            // FrmGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(333, 358);
            this.Controls.Add(this.Txttarih);
            this.Controls.Add(this.LblTarih);
            this.Controls.Add(this.Txttutar);
            this.Controls.Add(this.LblTutar);
            this.Controls.Add(this.Txttur);
            this.Controls.Add(this.LblTur);
            this.Controls.Add(this.Txtaciklama);
            this.Controls.Add(this.LblAciklama);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGider";
            this.Text = "Giderler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblAciklama;
        private System.Windows.Forms.TextBox Txtaciklama;
        private System.Windows.Forms.TextBox Txttur;
        private System.Windows.Forms.Label LblTur;
        private System.Windows.Forms.TextBox Txttutar;
        private System.Windows.Forms.Label LblTutar;
        private System.Windows.Forms.TextBox Txttarih;
        private System.Windows.Forms.Label LblTarih;
    }
}